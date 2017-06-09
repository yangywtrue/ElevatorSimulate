using Connection;
using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility;

namespace ElevatorSimulate
{
    public partial class Simulate : Form
    {
        private SocketConn connect;
        private List<VMIController> elevators = new List<VMIController>();
        public Simulate()
        {
            InitializeComponent();
        }

        private void Simulate_Load(object sender, EventArgs e)
        {
            this.txtIp.Text = NetworkHelper.GetLocalIP();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (this.btnConnect.Text == "创建连接")
            {
                if (this.txtIp.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("请输入IP地址!");
                    return;
                }

                if (this.txtPort.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("请输入端口号!");
                    return;
                }

                string ip = this.txtIp.Text.Trim();
                int port = Convert.ToInt32(this.txtPort.Text.Trim());

                this.connect = new SocketConn(ip, port);
            }
            else
            {
                this.connect.Dispose();
                this.connect = null;
            }

            ToggleConnect();
        }

        private void ToggleConnect()
        {
            bool isEnable = !this.txtIp.Enabled;

            this.txtIp.Enabled = isEnable;
            this.txtPort.Enabled = isEnable;
            if (isEnable)
            {
                this.btnConnect.Text = "创建连接";
            }
            else
            {
                this.btnConnect.Text = "断开连接";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.connect == null)
            {
                MessageBox.Show("请先打开连接!");
                return;
            }

            string code = this.txtDeviceCode.Text.Trim();
            if (elevators.Where(el => el.DeviceCode == code).Count() > 0)
            {
                MessageBox.Show("已启动相同设备编码的电梯!");
                return;
            }

            VMIController controller = new VMIController(code);
            this.elevators.Add(controller);
            controller.onLogInfo += onLogInfo;
            this.connect.onReceiveMessage += controller.Receive;

            BindDeviceCode();
            MessageBox.Show("创建电梯成功!");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            string code = this.txtDeviceCode.Text.Trim();
            if (string.IsNullOrEmpty(code))
            {
                return;
            }
            VMIController controller = this.elevators.Where(el => el.DeviceCode == code).FirstOrDefault();
            this.elevators.Remove(controller);

            BindDeviceCode();
            MessageBox.Show("删除电梯成功!");
        }

        private void BindDeviceCode()
        {
            List<KeyValuePair<string,string>> itemList = new List<KeyValuePair<string, string>>();
            foreach (VMIController el in elevators)
            {
                KeyValuePair<string, string> item = new KeyValuePair<string, string>(el.DeviceCode, el.DeviceCode);
                itemList.Add(item);
            }
            cbDeviceCode.DisplayMember = "Value";
            cbDeviceCode.ValueMember = "Key";
            cbDeviceCode.DataSource = itemList;
        }

        private void onLogInfo(string str)
        {
            try
            {
                if (richTextMsg.InvokeRequired)
                {
                    richTextMsg.Invoke(new Action<string>(onLogInfo), str);
                }
                else
                {
                    if (richTextMsg.Lines.Length % 10000 == 0)
                    {
                        richTextMsg.Clear();
                    }
                    richTextMsg.AppendText(str + "\n");
                    richTextMsg.SelectionStart = richTextMsg.TextLength;
                    richTextMsg.ScrollToCaret();

                }
            }
            catch
            {
            }
        }
    }
}
