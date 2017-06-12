using Common.Enum;
using Connection;
using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

            RefreshGridView();
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
            controller.onSendMessage += this.connect.Send;
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
            this.connect.onReceiveMessage -= controller.Receive;
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

        private void btnFloor1_Click(object sender, EventArgs e)
        {
            string code = this.cbDeviceCode.SelectedValue.ToString();
            VMIController controller = this.elevators.Where(el => el.DeviceCode == code).FirstOrDefault();
            controller.GoToFloor(1);
        }

        private void btnFloor2_Click(object sender, EventArgs e)
        {
            string code = this.cbDeviceCode.SelectedValue.ToString();
            VMIController controller = this.elevators.Where(el => el.DeviceCode == code).FirstOrDefault();
            controller.GoToFloor(2);

        }

        private void btnFloor3_Click(object sender, EventArgs e)
        {
            string code = this.cbDeviceCode.SelectedValue.ToString();
            VMIController controller = this.elevators.Where(el => el.DeviceCode == code).FirstOrDefault();
            controller.GoToFloor(3);
        }

        private void btnFloor4_Click(object sender, EventArgs e)
        {
            string code = this.cbDeviceCode.SelectedValue.ToString();
            VMIController controller = this.elevators.Where(el => el.DeviceCode == code).FirstOrDefault();
            controller.GoToFloor(4);
        }

        private void btnOpenDoor_Click(object sender, EventArgs e)
        {
            string code = this.cbDeviceCode.SelectedValue.ToString();
            VMIController controller = this.elevators.Where(el => el.DeviceCode == code).FirstOrDefault();
            controller.OpenDoor();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string code = this.cbDeviceCode.SelectedValue.ToString();
            VMIController controller = this.elevators.Where(el => el.DeviceCode == code).FirstOrDefault();
            controller.CloseDoor();
        }

        private void btnExceptionOn_Click(object sender, EventArgs e)
        {
            string code = this.cbDeviceCode.SelectedValue.ToString();
            VMIController controller = this.elevators.Where(el => el.DeviceCode == code).FirstOrDefault();
            controller.SetException(true);
        }

        private void btnExceptionOff_Click(object sender, EventArgs e)
        {
            string code = this.cbDeviceCode.SelectedValue.ToString();
            VMIController controller = this.elevators.Where(el => el.DeviceCode == code).FirstOrDefault();
            controller.SetException(false);
        }

        private void RefreshGridView()
        {
            Task taskRefreshStatus = new Task(() =>
            {
                while (true)
                {
                    BindGridView();
                    Thread.Sleep(500);
                }
            }, TaskCreationOptions.LongRunning);
            taskRefreshStatus.Start();
        }

        private void BindGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("DeviceCode");
            dt.Columns.Add("CurrentFloor");
            dt.Columns.Add("RunningDirction");
            dt.Columns.Add("DoorStatus");
            dt.Columns.Add("HasException");

            foreach (VMIController el in elevators)
            {
                DataRow dr = dt.NewRow();
                dr["DeviceCode"] = el.DeviceCode;
                dr["CurrentFloor"] = el.CurrentFloor;

                string temp = "未知";
                switch (el.RunningDirection)
                {
                    case ElevatorDirectionEnum.Unknown:
                        break;
                    case ElevatorDirectionEnum.Up:
                        temp = "向上";
                        break;
                    case ElevatorDirectionEnum.Down:
                        temp = "向下";
                        break;
                    case ElevatorDirectionEnum.Stop:
                        temp = "停止";
                        break;
                    default:
                        break;
                }
                dr["RunningDirction"] = temp;

                temp = "未知";
                switch (el.DoorStatus)
                {
                    case ElevatorDoorStatusEnum.Unknown:
                        break;
                    case ElevatorDoorStatusEnum.Opened:
                        temp = "已开门";
                        break;
                    case ElevatorDoorStatusEnum.Closed:
                        temp = "已关门";
                        break;
                    case ElevatorDoorStatusEnum.Opening:
                        temp = "开门中";
                        break;
                    case ElevatorDoorStatusEnum.Closing:
                        temp = "关门中";
                        break;
                    default:
                        break;
                }
                dr["DoorStatus"] = temp;
                dr["HasException"] = el.HasException;
                dt.Rows.Add(dr);
            }
            gridStatus.Invoke(new Action(() =>
            {
                for (int i = 0; i < elevators.Count; i++)
                {
                    VMIController el = elevators[i];
                    if (el.HasException)
                    {
                        gridStatus.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
                gridStatus.AutoGenerateColumns = false;
                gridStatus.DataSource = dt;
                gridStatus.ClearSelection();
            }));
            
        }

        private void gridStatus_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            bool hasException = Convert.ToBoolean(gridStatus.Rows[e.RowIndex].Cells["colHasException"].Value.ToString());
            if (hasException)
            {
                gridStatus.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
        }
    }
}
