namespace ElevatorSimulate
{
    partial class Simulate
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbBasic = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblServerAddress = new System.Windows.Forms.Label();
            this.gbOperation = new System.Windows.Forms.GroupBox();
            this.btnExceptionOff = new System.Windows.Forms.Button();
            this.btnExceptionOn = new System.Windows.Forms.Button();
            this.lblException = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpenDoor = new System.Windows.Forms.Button();
            this.lblDoor = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.btnFloor4 = new System.Windows.Forms.Button();
            this.btnFloor3 = new System.Windows.Forms.Button();
            this.btnFloor2 = new System.Windows.Forms.Button();
            this.btnFloor1 = new System.Windows.Forms.Button();
            this.cbDeviceCode = new System.Windows.Forms.ComboBox();
            this.lblDeviceSelect = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.gridStatus = new System.Windows.Forms.DataGridView();
            this.gbElevatorInit = new System.Windows.Forms.GroupBox();
            this.txtDeviceCode = new System.Windows.Forms.TextBox();
            this.lblDeviceCode = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.richTextMsg = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbBasic.SuspendLayout();
            this.gbOperation.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStatus)).BeginInit();
            this.gbElevatorInit.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.gbMessage);
            this.splitContainer.Size = new System.Drawing.Size(819, 600);
            this.splitContainer.SplitterDistance = 383;
            this.splitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gbBasic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbOperation, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbStatus, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.gbElevatorInit, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.27273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.72727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(383, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbBasic
            // 
            this.gbBasic.Controls.Add(this.btnConnect);
            this.gbBasic.Controls.Add(this.txtPort);
            this.gbBasic.Controls.Add(this.txtIp);
            this.gbBasic.Controls.Add(this.lblServerAddress);
            this.gbBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBasic.Location = new System.Drawing.Point(3, 3);
            this.gbBasic.Name = "gbBasic";
            this.gbBasic.Size = new System.Drawing.Size(377, 86);
            this.gbBasic.TabIndex = 0;
            this.gbBasic.TabStop = false;
            this.gbBasic.Text = "基本配置";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(22, 54);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(331, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "创建连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(304, 25);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(49, 21);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "7100";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(106, 25);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(183, 21);
            this.txtIp.TabIndex = 1;
            // 
            // lblServerAddress
            // 
            this.lblServerAddress.AutoSize = true;
            this.lblServerAddress.Location = new System.Drawing.Point(20, 28);
            this.lblServerAddress.Name = "lblServerAddress";
            this.lblServerAddress.Size = new System.Drawing.Size(71, 12);
            this.lblServerAddress.TabIndex = 0;
            this.lblServerAddress.Text = "服务器地址:";
            // 
            // gbOperation
            // 
            this.gbOperation.Controls.Add(this.btnExceptionOff);
            this.gbOperation.Controls.Add(this.btnExceptionOn);
            this.gbOperation.Controls.Add(this.lblException);
            this.gbOperation.Controls.Add(this.btnClose);
            this.gbOperation.Controls.Add(this.btnOpenDoor);
            this.gbOperation.Controls.Add(this.lblDoor);
            this.gbOperation.Controls.Add(this.lblFloor);
            this.gbOperation.Controls.Add(this.btnFloor4);
            this.gbOperation.Controls.Add(this.btnFloor3);
            this.gbOperation.Controls.Add(this.btnFloor2);
            this.gbOperation.Controls.Add(this.btnFloor1);
            this.gbOperation.Controls.Add(this.cbDeviceCode);
            this.gbOperation.Controls.Add(this.lblDeviceSelect);
            this.gbOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOperation.Location = new System.Drawing.Point(3, 179);
            this.gbOperation.Name = "gbOperation";
            this.gbOperation.Size = new System.Drawing.Size(377, 150);
            this.gbOperation.TabIndex = 1;
            this.gbOperation.TabStop = false;
            this.gbOperation.Text = "电梯操作";
            // 
            // btnExceptionOff
            // 
            this.btnExceptionOff.Location = new System.Drawing.Point(239, 118);
            this.btnExceptionOff.Name = "btnExceptionOff";
            this.btnExceptionOff.Size = new System.Drawing.Size(75, 23);
            this.btnExceptionOff.TabIndex = 12;
            this.btnExceptionOff.Text = "取消异常";
            this.btnExceptionOff.UseVisualStyleBackColor = true;
            // 
            // btnExceptionOn
            // 
            this.btnExceptionOn.Location = new System.Drawing.Point(106, 118);
            this.btnExceptionOn.Name = "btnExceptionOn";
            this.btnExceptionOn.Size = new System.Drawing.Size(75, 23);
            this.btnExceptionOn.TabIndex = 11;
            this.btnExceptionOn.Text = "发生异常";
            this.btnExceptionOn.UseVisualStyleBackColor = true;
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(20, 123);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(35, 12);
            this.lblException.TabIndex = 10;
            this.lblException.Text = "异常:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(239, 89);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "关门";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnOpenDoor
            // 
            this.btnOpenDoor.Location = new System.Drawing.Point(106, 89);
            this.btnOpenDoor.Name = "btnOpenDoor";
            this.btnOpenDoor.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDoor.TabIndex = 8;
            this.btnOpenDoor.Text = "开门";
            this.btnOpenDoor.UseVisualStyleBackColor = true;
            // 
            // lblDoor
            // 
            this.lblDoor.AutoSize = true;
            this.lblDoor.Location = new System.Drawing.Point(20, 94);
            this.lblDoor.Name = "lblDoor";
            this.lblDoor.Size = new System.Drawing.Size(47, 12);
            this.lblDoor.TabIndex = 7;
            this.lblDoor.Text = "开关门:";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(20, 62);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(83, 12);
            this.lblFloor.TabIndex = 6;
            this.lblFloor.Text = "指定目的楼层:";
            // 
            // btnFloor4
            // 
            this.btnFloor4.Location = new System.Drawing.Point(303, 57);
            this.btnFloor4.Name = "btnFloor4";
            this.btnFloor4.Size = new System.Drawing.Size(50, 23);
            this.btnFloor4.TabIndex = 5;
            this.btnFloor4.Text = "四楼";
            this.btnFloor4.UseVisualStyleBackColor = true;
            // 
            // btnFloor3
            // 
            this.btnFloor3.Location = new System.Drawing.Point(239, 57);
            this.btnFloor3.Name = "btnFloor3";
            this.btnFloor3.Size = new System.Drawing.Size(50, 23);
            this.btnFloor3.TabIndex = 4;
            this.btnFloor3.Text = "三楼";
            this.btnFloor3.UseVisualStyleBackColor = true;
            // 
            // btnFloor2
            // 
            this.btnFloor2.Location = new System.Drawing.Point(169, 57);
            this.btnFloor2.Name = "btnFloor2";
            this.btnFloor2.Size = new System.Drawing.Size(50, 23);
            this.btnFloor2.TabIndex = 3;
            this.btnFloor2.Text = "二楼";
            this.btnFloor2.UseVisualStyleBackColor = true;
            // 
            // btnFloor1
            // 
            this.btnFloor1.Location = new System.Drawing.Point(106, 57);
            this.btnFloor1.Name = "btnFloor1";
            this.btnFloor1.Size = new System.Drawing.Size(50, 23);
            this.btnFloor1.TabIndex = 2;
            this.btnFloor1.Text = "一楼";
            this.btnFloor1.UseVisualStyleBackColor = true;
            // 
            // cbDeviceCode
            // 
            this.cbDeviceCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeviceCode.FormattingEnabled = true;
            this.cbDeviceCode.Location = new System.Drawing.Point(106, 23);
            this.cbDeviceCode.Name = "cbDeviceCode";
            this.cbDeviceCode.Size = new System.Drawing.Size(247, 20);
            this.cbDeviceCode.TabIndex = 1;
            // 
            // lblDeviceSelect
            // 
            this.lblDeviceSelect.AutoSize = true;
            this.lblDeviceSelect.Location = new System.Drawing.Point(20, 26);
            this.lblDeviceSelect.Name = "lblDeviceSelect";
            this.lblDeviceSelect.Size = new System.Drawing.Size(59, 12);
            this.lblDeviceSelect.TabIndex = 0;
            this.lblDeviceSelect.Text = "设备编码:";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.gridStatus);
            this.gbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbStatus.Location = new System.Drawing.Point(3, 335);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(377, 262);
            this.gbStatus.TabIndex = 2;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "状态";
            // 
            // gridStatus
            // 
            this.gridStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStatus.Location = new System.Drawing.Point(3, 17);
            this.gridStatus.Name = "gridStatus";
            this.gridStatus.RowTemplate.Height = 23;
            this.gridStatus.Size = new System.Drawing.Size(371, 242);
            this.gridStatus.TabIndex = 0;
            // 
            // gbElevatorInit
            // 
            this.gbElevatorInit.Controls.Add(this.txtDeviceCode);
            this.gbElevatorInit.Controls.Add(this.lblDeviceCode);
            this.gbElevatorInit.Controls.Add(this.btnStop);
            this.gbElevatorInit.Controls.Add(this.btnStart);
            this.gbElevatorInit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbElevatorInit.Location = new System.Drawing.Point(3, 95);
            this.gbElevatorInit.Name = "gbElevatorInit";
            this.gbElevatorInit.Size = new System.Drawing.Size(377, 78);
            this.gbElevatorInit.TabIndex = 3;
            this.gbElevatorInit.TabStop = false;
            this.gbElevatorInit.Text = "初始化";
            // 
            // txtDeviceCode
            // 
            this.txtDeviceCode.Location = new System.Drawing.Point(106, 20);
            this.txtDeviceCode.Name = "txtDeviceCode";
            this.txtDeviceCode.Size = new System.Drawing.Size(247, 21);
            this.txtDeviceCode.TabIndex = 10;
            this.txtDeviceCode.Text = "1";
            // 
            // lblDeviceCode
            // 
            this.lblDeviceCode.AutoSize = true;
            this.lblDeviceCode.Location = new System.Drawing.Point(20, 23);
            this.lblDeviceCode.Name = "lblDeviceCode";
            this.lblDeviceCode.Size = new System.Drawing.Size(59, 12);
            this.lblDeviceCode.TabIndex = 9;
            this.lblDeviceCode.Text = "设备编码:";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(197, 49);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(156, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(22, 49);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbMessage
            // 
            this.gbMessage.BackColor = System.Drawing.Color.Transparent;
            this.gbMessage.Controls.Add(this.richTextMsg);
            this.gbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMessage.ForeColor = System.Drawing.Color.Blue;
            this.gbMessage.Location = new System.Drawing.Point(0, 0);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.gbMessage.Size = new System.Drawing.Size(432, 600);
            this.gbMessage.TabIndex = 0;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "信息日志";
            // 
            // richTextMsg
            // 
            this.richTextMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextMsg.Location = new System.Drawing.Point(5, 17);
            this.richTextMsg.Name = "richTextMsg";
            this.richTextMsg.Size = new System.Drawing.Size(422, 578);
            this.richTextMsg.TabIndex = 1;
            this.richTextMsg.Text = "";
            // 
            // Simulate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 600);
            this.Controls.Add(this.splitContainer);
            this.Name = "Simulate";
            this.Text = "电梯模拟器";
            this.Load += new System.EventHandler(this.Simulate_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbBasic.ResumeLayout(false);
            this.gbBasic.PerformLayout();
            this.gbOperation.ResumeLayout(false);
            this.gbOperation.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStatus)).EndInit();
            this.gbElevatorInit.ResumeLayout(false);
            this.gbElevatorInit.PerformLayout();
            this.gbMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.RichTextBox richTextMsg;
        private System.Windows.Forms.GroupBox gbBasic;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblServerAddress;
        private System.Windows.Forms.GroupBox gbOperation;
        private System.Windows.Forms.Button btnExceptionOff;
        private System.Windows.Forms.Button btnExceptionOn;
        private System.Windows.Forms.Label lblException;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpenDoor;
        private System.Windows.Forms.Label lblDoor;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Button btnFloor4;
        private System.Windows.Forms.Button btnFloor3;
        private System.Windows.Forms.Button btnFloor2;
        private System.Windows.Forms.Button btnFloor1;
        private System.Windows.Forms.ComboBox cbDeviceCode;
        private System.Windows.Forms.Label lblDeviceSelect;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.DataGridView gridStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbElevatorInit;
        private System.Windows.Forms.TextBox txtDeviceCode;
        private System.Windows.Forms.Label lblDeviceCode;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
    }
}

