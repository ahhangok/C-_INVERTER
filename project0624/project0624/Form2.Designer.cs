
namespace project0624
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbx_Sendmany = new System.Windows.Forms.CheckBox();
            this.cbx_SendHexa = new System.Windows.Forms.CheckBox();
            this.cbx_RecHexa = new System.Windows.Forms.CheckBox();
            this.bt_Rec = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_RecData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Send = new System.Windows.Forms.Button();
            this.txb_Send = new System.Windows.Forms.TextBox();
            this.cmb_Baud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Comport = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Open = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_Sendmany
            // 
            this.cbx_Sendmany.AutoSize = true;
            this.cbx_Sendmany.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbx_Sendmany.Location = new System.Drawing.Point(498, 236);
            this.cbx_Sendmany.Name = "cbx_Sendmany";
            this.cbx_Sendmany.Size = new System.Drawing.Size(93, 19);
            this.cbx_Sendmany.TabIndex = 44;
            this.cbx_Sendmany.Text = "연속전송";
            this.cbx_Sendmany.UseVisualStyleBackColor = true;
            // 
            // cbx_SendHexa
            // 
            this.cbx_SendHexa.AutoSize = true;
            this.cbx_SendHexa.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbx_SendHexa.Location = new System.Drawing.Point(426, 236);
            this.cbx_SendHexa.Name = "cbx_SendHexa";
            this.cbx_SendHexa.Size = new System.Drawing.Size(70, 19);
            this.cbx_SendHexa.TabIndex = 43;
            this.cbx_SendHexa.Text = "HEXA";
            this.cbx_SendHexa.UseVisualStyleBackColor = true;
            // 
            // cbx_RecHexa
            // 
            this.cbx_RecHexa.AutoSize = true;
            this.cbx_RecHexa.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbx_RecHexa.Location = new System.Drawing.Point(426, 322);
            this.cbx_RecHexa.Name = "cbx_RecHexa";
            this.cbx_RecHexa.Size = new System.Drawing.Size(70, 19);
            this.cbx_RecHexa.TabIndex = 42;
            this.cbx_RecHexa.Text = "HEXA";
            this.cbx_RecHexa.UseVisualStyleBackColor = true;
            // 
            // bt_Rec
            // 
            this.bt_Rec.BackColor = System.Drawing.Color.LightGray;
            this.bt_Rec.Enabled = false;
            this.bt_Rec.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Rec.ForeColor = System.Drawing.Color.Black;
            this.bt_Rec.Location = new System.Drawing.Point(426, 347);
            this.bt_Rec.Name = "bt_Rec";
            this.bt_Rec.Size = new System.Drawing.Size(81, 41);
            this.bt_Rec.TabIndex = 41;
            this.bt_Rec.Text = "수신";
            this.bt_Rec.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(31, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "수신데이터";
            // 
            // txb_RecData
            // 
            this.txb_RecData.Location = new System.Drawing.Point(127, 307);
            this.txb_RecData.Multiline = true;
            this.txb_RecData.Name = "txb_RecData";
            this.txb_RecData.Size = new System.Drawing.Size(269, 80);
            this.txb_RecData.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(32, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "전송데이터";
            // 
            // bt_Send
            // 
            this.bt_Send.BackColor = System.Drawing.Color.LightGray;
            this.bt_Send.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Send.ForeColor = System.Drawing.Color.Black;
            this.bt_Send.Location = new System.Drawing.Point(426, 261);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(161, 41);
            this.bt_Send.TabIndex = 37;
            this.bt_Send.Text = "전송";
            this.bt_Send.UseVisualStyleBackColor = false;
            // 
            // txb_Send
            // 
            this.txb_Send.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txb_Send.Location = new System.Drawing.Point(127, 247);
            this.txb_Send.Name = "txb_Send";
            this.txb_Send.Size = new System.Drawing.Size(269, 25);
            this.txb_Send.TabIndex = 36;
            this.txb_Send.Text = "01 03 00 c8 00 01 05 f4";
            // 
            // cmb_Baud
            // 
            this.cmb_Baud.FormattingEnabled = true;
            this.cmb_Baud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmb_Baud.Location = new System.Drawing.Point(193, 181);
            this.cmb_Baud.Name = "cmb_Baud";
            this.cmb_Baud.Size = new System.Drawing.Size(121, 31);
            this.cmb_Baud.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(194, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "BaudRate 선택";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(39, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "COM Port 선택";
            // 
            // cmb_Comport
            // 
            this.cmb_Comport.FormattingEnabled = true;
            this.cmb_Comport.Location = new System.Drawing.Point(41, 181);
            this.cmb_Comport.Name = "cmb_Comport";
            this.cmb_Comport.Size = new System.Drawing.Size(121, 31);
            this.cmb_Comport.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_Sendmany);
            this.groupBox2.Controls.Add(this.bt_Open);
            this.groupBox2.Controls.Add(this.cbx_SendHexa);
            this.groupBox2.Controls.Add(this.bt_Close);
            this.groupBox2.Controls.Add(this.cbx_RecHexa);
            this.groupBox2.Controls.Add(this.txb_RecData);
            this.groupBox2.Controls.Add(this.bt_Rec);
            this.groupBox2.Controls.Add(this.cmb_Comport);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmb_Baud);
            this.groupBox2.Controls.Add(this.bt_Send);
            this.groupBox2.Controls.Add(this.txb_Send);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(31, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 443);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "통신";
            // 
            // bt_Open
            // 
            this.bt_Open.BackColor = System.Drawing.Color.LightGray;
            this.bt_Open.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Open.Location = new System.Drawing.Point(36, 44);
            this.bt_Open.Name = "bt_Open";
            this.bt_Open.Size = new System.Drawing.Size(124, 75);
            this.bt_Open.TabIndex = 4;
            this.bt_Open.Text = "통신 접속";
            this.bt_Open.UseVisualStyleBackColor = false;
            this.bt_Open.Click += new System.EventHandler(this.bt_Open_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.BackColor = System.Drawing.Color.LightGray;
            this.bt_Close.Enabled = false;
            this.bt_Close.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_Close.ForeColor = System.Drawing.Color.Black;
            this.bt_Close.Location = new System.Drawing.Point(183, 44);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(124, 75);
            this.bt_Close.TabIndex = 5;
            this.bt_Close.Text = "접속 해제";
            this.bt_Close.UseVisualStyleBackColor = false;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 478);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbx_Sendmany;
        private System.Windows.Forms.CheckBox cbx_SendHexa;
        private System.Windows.Forms.CheckBox cbx_RecHexa;
        private System.Windows.Forms.Button bt_Rec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_RecData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Send;
        private System.Windows.Forms.TextBox txb_Send;
        private System.Windows.Forms.ComboBox cmb_Baud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Comport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_Open;
        private System.Windows.Forms.Button bt_Close;
    }
}