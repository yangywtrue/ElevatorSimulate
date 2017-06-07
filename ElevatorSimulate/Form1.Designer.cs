﻿namespace ElevatorSimulate
{
    partial class Form1
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
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.txtMsg = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDeviceSelect = new System.Windows.Forms.Label();
            this.cbDeviceCode = new System.Windows.Forms.ComboBox();
            this.btnFloor1 = new System.Windows.Forms.Button();
            this.btnFloor2 = new System.Windows.Forms.Button();
            this.btnFloor3 = new System.Windows.Forms.Button();
            this.btnFloor4 = new System.Windows.Forms.Button();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblDoor = new System.Windows.Forms.Label();
            this.btnOpenDoor = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblException = new System.Windows.Forms.Label();
            this.btnExceptionOn = new System.Windows.Forms.Button();
            this.btnExceptionOff = new System.Windows.Forms.Button();
            this.gbOperation = new System.Windows.Forms.GroupBox();
            this.lblServerAddress = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblDeviceCode = new System.Windows.Forms.Label();
            this.txtDeviceCode = new System.Windows.Forms.TextBox();
            this.gbBasic = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbOperation.SuspendLayout();
            this.gbBasic.SuspendLayout();
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
            // gbMessage
            // 
            this.gbMessage.BackColor = System.Drawing.Color.Transparent;
            this.gbMessage.Controls.Add(this.txtMsg);
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
            // txtMsg
            // 
            this.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMsg.Location = new System.Drawing.Point(5, 17);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(422, 578);
            this.txtMsg.TabIndex = 1;
            this.txtMsg.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.gbBasic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbOperation, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.16667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.83334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(383, 600);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // cbDeviceCode
            // 
            this.cbDeviceCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeviceCode.FormattingEnabled = true;
            this.cbDeviceCode.Location = new System.Drawing.Point(106, 23);
            this.cbDeviceCode.Name = "cbDeviceCode";
            this.cbDeviceCode.Size = new System.Drawing.Size(247, 20);
            this.cbDeviceCode.TabIndex = 1;
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
            // btnFloor2
            // 
            this.btnFloor2.Location = new System.Drawing.Point(169, 57);
            this.btnFloor2.Name = "btnFloor2";
            this.btnFloor2.Size = new System.Drawing.Size(50, 23);
            this.btnFloor2.TabIndex = 3;
            this.btnFloor2.Text = "二楼";
            this.btnFloor2.UseVisualStyleBackColor = true;
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
            // btnFloor4
            // 
            this.btnFloor4.Location = new System.Drawing.Point(303, 57);
            this.btnFloor4.Name = "btnFloor4";
            this.btnFloor4.Size = new System.Drawing.Size(50, 23);
            this.btnFloor4.TabIndex = 5;
            this.btnFloor4.Text = "四楼";
            this.btnFloor4.UseVisualStyleBackColor = true;
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
            // lblDoor
            // 
            this.lblDoor.AutoSize = true;
            this.lblDoor.Location = new System.Drawing.Point(20, 94);
            this.lblDoor.Name = "lblDoor";
            this.lblDoor.Size = new System.Drawing.Size(47, 12);
            this.lblDoor.TabIndex = 7;
            this.lblDoor.Text = "开关门:";
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(239, 89);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "关门";
            this.btnClose.UseVisualStyleBackColor = true;
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
            // btnExceptionOn
            // 
            this.btnExceptionOn.Location = new System.Drawing.Point(106, 118);
            this.btnExceptionOn.Name = "btnExceptionOn";
            this.btnExceptionOn.Size = new System.Drawing.Size(75, 23);
            this.btnExceptionOn.TabIndex = 11;
            this.btnExceptionOn.Text = "发生异常";
            this.btnExceptionOn.UseVisualStyleBackColor = true;
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
            this.gbOperation.Location = new System.Drawing.Point(3, 123);
            this.gbOperation.Name = "gbOperation";
            this.gbOperation.Size = new System.Drawing.Size(377, 166);
            this.gbOperation.TabIndex = 1;
            this.gbOperation.TabStop = false;
            this.gbOperation.Text = "电梯操作";
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
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(106, 25);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(183, 21);
            this.txtIp.TabIndex = 1;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(304, 25);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(49, 21);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "9100";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(22, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(197, 85);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(156, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // lblDeviceCode
            // 
            this.lblDeviceCode.AutoSize = true;
            this.lblDeviceCode.Location = new System.Drawing.Point(20, 59);
            this.lblDeviceCode.Name = "lblDeviceCode";
            this.lblDeviceCode.Size = new System.Drawing.Size(59, 12);
            this.lblDeviceCode.TabIndex = 5;
            this.lblDeviceCode.Text = "设备编码:";
            // 
            // txtDeviceCode
            // 
            this.txtDeviceCode.Location = new System.Drawing.Point(106, 56);
            this.txtDeviceCode.Name = "txtDeviceCode";
            this.txtDeviceCode.Size = new System.Drawing.Size(247, 21);
            this.txtDeviceCode.TabIndex = 6;
            // 
            // gbBasic
            // 
            this.gbBasic.Controls.Add(this.txtDeviceCode);
            this.gbBasic.Controls.Add(this.lblDeviceCode);
            this.gbBasic.Controls.Add(this.btnStop);
            this.gbBasic.Controls.Add(this.btnStart);
            this.gbBasic.Controls.Add(this.txtPort);
            this.gbBasic.Controls.Add(this.txtIp);
            this.gbBasic.Controls.Add(this.lblServerAddress);
            this.gbBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBasic.Location = new System.Drawing.Point(3, 3);
            this.gbBasic.Name = "gbBasic";
            this.gbBasic.Size = new System.Drawing.Size(377, 114);
            this.gbBasic.TabIndex = 0;
            this.gbBasic.TabStop = false;
            this.gbBasic.Text = "基本配置";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 600);
            this.Controls.Add(this.splitContainer);
            this.Name = "Form1";
            this.Text = "电梯模拟器";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.gbMessage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbOperation.ResumeLayout(false);
            this.gbOperation.PerformLayout();
            this.gbBasic.ResumeLayout(false);
            this.gbBasic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.RichTextBox txtMsg;
        private System.Windows.Forms.GroupBox gbBasic;
        private System.Windows.Forms.TextBox txtDeviceCode;
        private System.Windows.Forms.Label lblDeviceCode;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
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
    }
}
