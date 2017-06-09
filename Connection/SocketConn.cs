using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Connection
{
    public class SocketConn : IDisposable
    {
        private Socket socket;
        private Task receiveTask;
        private CancellationTokenSource tokenSource;

        public event Action<string> onReceiveMessage;

        public SocketConn(string host, int port)
        {
            IPAddress ip = IPAddress.Parse(host);
            IPEndPoint ipe = new IPEndPoint(ip, port);

            this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            //this.socket.ReceiveTimeout = 0;

            try
            {
                socket.Connect(ipe);
            }
            catch (Exception ex)
            {
                throw new Exception($"无法打开Socket连接：{ex.Message}");
            }

            StartReceiveThread();
        }

        public void Send(string data)
        {
            Send(System.Text.Encoding.UTF8.GetBytes(data));
        }

        private void Send(byte[] byteData)
        {
            try
            {
                int length = byteData.Length;
                byte[] head = BitConverter.GetBytes(length);
                byte[] data = new byte[head.Length + byteData.Length];
                Array.Copy(head, data, head.Length);
                Array.Copy(byteData, 0, data, head.Length, byteData.Length);
                this.socket.BeginSend(data, 0, data.Length, 0, new AsyncCallback(SendCallback), this.socket);
            }
            catch (SocketException ex)
            { }
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                Socket handler = (Socket)ar.AsyncState;
                handler.EndSend(ar);
            }
            catch (SocketException ex)
            { }
        }

        private void StartReceiveThread()
        {
            this.tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            this.receiveTask = new Task(() =>
            {
                byte[] headerBuf = new byte[1];
                byte[] bodyBuf = new byte[9];

                string header = string.Empty;

                int msgLength = 9;
                int length = 0;
                while (true)
                {
                    if (token.IsCancellationRequested)
                    {
                        break;
                    }

                    try
                    {
                        if (socket == null || socket.Connected == false)
                        {
                            break;
                        }
                        //接收来自电梯发出的消息，Receive不断等待
                        length = socket.Receive(headerBuf, 1, SocketFlags.None);
                        header = System.Text.Encoding.ASCII.GetString(headerBuf, 0, length);
                        if (header != ":")
                        {
                            continue;
                        }
                        length = socket.Receive(bodyBuf, msgLength - 1, SocketFlags.None);
                        string body = System.Text.Encoding.ASCII.GetString(bodyBuf, 0, msgLength - 1);
                        if (!body.EndsWith("!") || body.Length != msgLength - 1)
                        {
                            continue;
                        }

                        string msg = header + body;

                        //string getCheckSum = msg.Substring(6, 2);
                        //string calcCheckSum = GetCheckSum(msg.Substring(1, msg.Length-4));
                        //验证checksum是否相等，如果不等要返回
                        //if (getCheckSum != calcCheckSum)
                        //{
                        //    continue;
                        //}

                        BroadCastMessage(msg);

                    }
                    catch (Exception ex)
                    {
                        if (socket == null || socket.Connected == false)
                        {
                            this.socket.Close();
                            this.socket.Dispose();
                            break;
                        }
                    }
                }
            }, token, TaskCreationOptions.LongRunning);
            receiveTask.Start();
        }

        private void BroadCastMessage(string msg)
        {
            if (onReceiveMessage == null)
            {
                return;
            }
            foreach (Delegate method in onReceiveMessage.GetInvocationList())
            {
                try
                {
                    Action<string> action = (Action<string>)method;
                    action.BeginInvoke(msg, null, null);
                }
                catch (Exception ex)
                {
                    continue;
                }
            }
        }

        private string GetCheckSum(string data)
        {
            int result = ':' ^ '!';
            char[] charData = data.ToCharArray();
            for (int i = 0; i < charData.Length; i++)
            {
                result = result ^ charData[i];
            }
            return Convert.ToString(result, 16).PadLeft(2, '0').ToUpper();
        }

        public void Dispose()
        {
            tokenSource.Cancel();
            this.socket.Close();
            this.socket.Dispose();
        }
    }
}
