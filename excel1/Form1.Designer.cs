namespace excel1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.readExcel = new System.Windows.Forms.Button();
            this.writeToExcel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.productNameBox = new System.Windows.Forms.ComboBox();
            this.productName = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.numberbox = new System.Windows.Forms.TextBox();
            this.bankName = new System.Windows.Forms.Label();
            this.bankNameBox = new System.Windows.Forms.TextBox();
            this.due = new System.Windows.Forms.Label();
            this.duebox = new System.Windows.Forms.ComboBox();
            this.money = new System.Windows.Forms.Label();
            this.moneyBox = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Label();
            this.startTimer = new System.Windows.Forms.DateTimePicker();
            this.end = new System.Windows.Forms.Label();
            this.endTimer = new System.Windows.Forms.DateTimePicker();
            this.rate = new System.Windows.Forms.Label();
            this.rateBox = new System.Windows.Forms.TextBox();
            this.interest1 = new System.Windows.Forms.Label();
            this.interest1Box = new System.Windows.Forms.ComboBox();
            this.letterNo = new System.Windows.Forms.Label();
            this.letterNoBox = new System.Windows.Forms.TextBox();
            this.tag = new System.Windows.Forms.Label();
            this.tagBox = new System.Windows.Forms.ComboBox();
            this.manageFee = new System.Windows.Forms.Label();
            this.manageFeeBox = new System.Windows.Forms.TextBox();
            this.interest2 = new System.Windows.Forms.Label();
            this.interest2Box = new System.Windows.Forms.ComboBox();
            this.interFee = new System.Windows.Forms.Label();
            this.interFeeBox = new System.Windows.Forms.TextBox();
            this.interest3Box = new System.Windows.Forms.ComboBox();
            this.interest3 = new System.Windows.Forms.Label();
            this.paper1 = new System.Windows.Forms.Label();
            this.paper1Box = new System.Windows.Forms.TextBox();
            this.paper2 = new System.Windows.Forms.Label();
            this.paper2Box = new System.Windows.Forms.TextBox();
            this.stamp = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.account = new System.Windows.Forms.Label();
            this.accountBox = new System.Windows.Forms.TextBox();
            this.stampCard = new System.Windows.Forms.Label();
            this.stampCardBox = new System.Windows.Forms.TextBox();
            this.stampPlaceBox = new System.Windows.Forms.ComboBox();
            this.letterPlaceBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderColumnBox = new System.Windows.Forms.CheckBox();
            this.search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readExcel
            // 
            this.readExcel.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.readExcel.Location = new System.Drawing.Point(103, 37);
            this.readExcel.Name = "readExcel";
            this.readExcel.Size = new System.Drawing.Size(181, 70);
            this.readExcel.TabIndex = 0;
            this.readExcel.Text = "read excel";
            this.readExcel.UseVisualStyleBackColor = true;
            this.readExcel.Click += new System.EventHandler(this.readExcel_Click);
            // 
            // writeToExcel
            // 
            this.writeToExcel.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.writeToExcel.Location = new System.Drawing.Point(1331, 37);
            this.writeToExcel.Name = "writeToExcel";
            this.writeToExcel.Size = new System.Drawing.Size(333, 71);
            this.writeToExcel.TabIndex = 3;
            this.writeToExcel.Text = "write To Excel";
            this.writeToExcel.UseVisualStyleBackColor = true;
            this.writeToExcel.Click += new System.EventHandler(this.writeToExcelClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // productNameBox
            // 
            this.productNameBox.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.productNameBox.FormattingEnabled = true;
            this.productNameBox.Location = new System.Drawing.Point(275, 208);
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.Size = new System.Drawing.Size(694, 45);
            this.productNameBox.TabIndex = 4;
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.productName.Location = new System.Drawing.Point(96, 215);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(131, 38);
            this.productName.TabIndex = 8;
            this.productName.Text = "产品名";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.SystemColors.Control;
            this.info.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.info.ForeColor = System.Drawing.Color.LightSlateGray;
            this.info.Location = new System.Drawing.Point(368, 54);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(283, 38);
            this.info.TabIndex = 9;
            this.info.Text = "Show Info here";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.number.Location = new System.Drawing.Point(1041, 215);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(93, 38);
            this.number.TabIndex = 10;
            this.number.Text = "期数";
            // 
            // numberbox
            // 
            this.numberbox.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numberbox.Location = new System.Drawing.Point(1181, 203);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(110, 50);
            this.numberbox.TabIndex = 11;
            // 
            // bankName
            // 
            this.bankName.AutoSize = true;
            this.bankName.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bankName.Location = new System.Drawing.Point(96, 289);
            this.bankName.Name = "bankName";
            this.bankName.Size = new System.Drawing.Size(131, 38);
            this.bankName.TabIndex = 12;
            this.bankName.Text = "存款行";
            // 
            // bankNameBox
            // 
            this.bankNameBox.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bankNameBox.Location = new System.Drawing.Point(275, 289);
            this.bankNameBox.Name = "bankNameBox";
            this.bankNameBox.Size = new System.Drawing.Size(694, 50);
            this.bankNameBox.TabIndex = 13;
            // 
            // due
            // 
            this.due.AutoSize = true;
            this.due.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.due.Location = new System.Drawing.Point(1041, 289);
            this.due.Name = "due";
            this.due.Size = new System.Drawing.Size(93, 38);
            this.due.TabIndex = 14;
            this.due.Text = "期限";
            // 
            // duebox
            // 
            this.duebox.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.duebox.FormattingEnabled = true;
            this.duebox.Location = new System.Drawing.Point(1181, 286);
            this.duebox.Name = "duebox";
            this.duebox.Size = new System.Drawing.Size(244, 45);
            this.duebox.TabIndex = 15;
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.money.Location = new System.Drawing.Point(96, 377);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(93, 38);
            this.money.TabIndex = 16;
            this.money.Text = "金额";
            // 
            // moneyBox
            // 
            this.moneyBox.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.moneyBox.Location = new System.Drawing.Point(275, 365);
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.Size = new System.Drawing.Size(698, 50);
            this.moneyBox.TabIndex = 17;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start.Location = new System.Drawing.Point(96, 444);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(131, 38);
            this.start.TabIndex = 18;
            this.start.Text = "起息日";
            // 
            // startTimer
            // 
            this.startTimer.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startTimer.Location = new System.Drawing.Point(275, 444);
            this.startTimer.Name = "startTimer";
            this.startTimer.Size = new System.Drawing.Size(282, 44);
            this.startTimer.TabIndex = 19;
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.end.Location = new System.Drawing.Point(615, 444);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(131, 38);
            this.end.TabIndex = 20;
            this.end.Text = "支取日";
            // 
            // endTimer
            // 
            this.endTimer.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endTimer.Location = new System.Drawing.Point(759, 444);
            this.endTimer.Name = "endTimer";
            this.endTimer.Size = new System.Drawing.Size(282, 44);
            this.endTimer.TabIndex = 21;
            // 
            // rate
            // 
            this.rate.AutoSize = true;
            this.rate.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rate.Location = new System.Drawing.Point(96, 523);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(93, 38);
            this.rate.TabIndex = 22;
            this.rate.Text = "利率";
            // 
            // rateBox
            // 
            this.rateBox.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rateBox.Location = new System.Drawing.Point(275, 508);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(158, 50);
            this.rateBox.TabIndex = 23;
            // 
            // interest1
            // 
            this.interest1.AutoSize = true;
            this.interest1.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.interest1.Location = new System.Drawing.Point(538, 514);
            this.interest1.Name = "interest1";
            this.interest1.Size = new System.Drawing.Size(169, 38);
            this.interest1.TabIndex = 24;
            this.interest1.Text = "计息方式";
            // 
            // interest1Box
            // 
            this.interest1Box.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.interest1Box.FormattingEnabled = true;
            this.interest1Box.Location = new System.Drawing.Point(759, 511);
            this.interest1Box.Name = "interest1Box";
            this.interest1Box.Size = new System.Drawing.Size(210, 45);
            this.interest1Box.TabIndex = 25;
            // 
            // letterNo
            // 
            this.letterNo.AutoSize = true;
            this.letterNo.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.letterNo.Location = new System.Drawing.Point(989, 523);
            this.letterNo.Name = "letterNo";
            this.letterNo.Size = new System.Drawing.Size(169, 38);
            this.letterNo.TabIndex = 26;
            this.letterNo.Text = "存单编号";
            // 
            // letterNoBox
            // 
            this.letterNoBox.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.letterNoBox.Location = new System.Drawing.Point(1153, 511);
            this.letterNoBox.Name = "letterNoBox";
            this.letterNoBox.Size = new System.Drawing.Size(274, 50);
            this.letterNoBox.TabIndex = 27;
            // 
            // tag
            // 
            this.tag.AutoSize = true;
            this.tag.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tag.Location = new System.Drawing.Point(1041, 377);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(93, 38);
            this.tag.TabIndex = 28;
            this.tag.Text = "标的";
            // 
            // tagBox
            // 
            this.tagBox.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tagBox.FormattingEnabled = true;
            this.tagBox.Location = new System.Drawing.Point(1181, 370);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(244, 45);
            this.tagBox.TabIndex = 29;
            // 
            // manageFee
            // 
            this.manageFee.AutoSize = true;
            this.manageFee.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.manageFee.Location = new System.Drawing.Point(96, 591);
            this.manageFee.Name = "manageFee";
            this.manageFee.Size = new System.Drawing.Size(131, 38);
            this.manageFee.TabIndex = 30;
            this.manageFee.Text = "管理费";
            // 
            // manageFeeBox
            // 
            this.manageFeeBox.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.manageFeeBox.Location = new System.Drawing.Point(275, 588);
            this.manageFeeBox.Name = "manageFeeBox";
            this.manageFeeBox.Size = new System.Drawing.Size(158, 50);
            this.manageFeeBox.TabIndex = 31;
            // 
            // interest2
            // 
            this.interest2.AutoSize = true;
            this.interest2.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.interest2.Location = new System.Drawing.Point(538, 588);
            this.interest2.Name = "interest2";
            this.interest2.Size = new System.Drawing.Size(169, 38);
            this.interest2.TabIndex = 32;
            this.interest2.Text = "计息方式";
            // 
            // interest2Box
            // 
            this.interest2Box.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.interest2Box.FormattingEnabled = true;
            this.interest2Box.Location = new System.Drawing.Point(759, 591);
            this.interest2Box.Name = "interest2Box";
            this.interest2Box.Size = new System.Drawing.Size(210, 45);
            this.interest2Box.TabIndex = 33;
            // 
            // interFee
            // 
            this.interFee.AutoSize = true;
            this.interFee.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.interFee.Location = new System.Drawing.Point(96, 666);
            this.interFee.Name = "interFee";
            this.interFee.Size = new System.Drawing.Size(131, 38);
            this.interFee.TabIndex = 34;
            this.interFee.Text = "托管费";
            // 
            // interFeeBox
            // 
            this.interFeeBox.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.interFeeBox.Location = new System.Drawing.Point(275, 654);
            this.interFeeBox.Name = "interFeeBox";
            this.interFeeBox.Size = new System.Drawing.Size(158, 50);
            this.interFeeBox.TabIndex = 35;
            // 
            // interest3Box
            // 
            this.interest3Box.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.interest3Box.FormattingEnabled = true;
            this.interest3Box.Location = new System.Drawing.Point(759, 666);
            this.interest3Box.Name = "interest3Box";
            this.interest3Box.Size = new System.Drawing.Size(210, 45);
            this.interest3Box.TabIndex = 37;
            // 
            // interest3
            // 
            this.interest3.AutoSize = true;
            this.interest3.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.interest3.Location = new System.Drawing.Point(538, 666);
            this.interest3.Name = "interest3";
            this.interest3.Size = new System.Drawing.Size(169, 38);
            this.interest3.TabIndex = 36;
            this.interest3.Text = "计息方式";
            // 
            // paper1
            // 
            this.paper1.AutoSize = true;
            this.paper1.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paper1.Location = new System.Drawing.Point(96, 749);
            this.paper1.Name = "paper1";
            this.paper1.Size = new System.Drawing.Size(169, 38);
            this.paper1.TabIndex = 38;
            this.paper1.Text = "合同编号";
            // 
            // paper1Box
            // 
            this.paper1Box.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paper1Box.Location = new System.Drawing.Point(275, 749);
            this.paper1Box.Name = "paper1Box";
            this.paper1Box.Size = new System.Drawing.Size(606, 50);
            this.paper1Box.TabIndex = 39;
            // 
            // paper2
            // 
            this.paper2.AutoSize = true;
            this.paper2.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paper2.Location = new System.Drawing.Point(96, 819);
            this.paper2.Name = "paper2";
            this.paper2.Size = new System.Drawing.Size(169, 38);
            this.paper2.TabIndex = 40;
            this.paper2.Text = "补充协议";
            // 
            // paper2Box
            // 
            this.paper2Box.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paper2Box.Location = new System.Drawing.Point(275, 819);
            this.paper2Box.Name = "paper2Box";
            this.paper2Box.Size = new System.Drawing.Size(606, 50);
            this.paper2Box.TabIndex = 41;
            // 
            // stamp
            // 
            this.stamp.AutoSize = true;
            this.stamp.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stamp.Location = new System.Drawing.Point(96, 911);
            this.stamp.Name = "stamp";
            this.stamp.Size = new System.Drawing.Size(169, 38);
            this.stamp.TabIndex = 42;
            this.stamp.Text = "预留印鉴";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(302, 911);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 42);
            this.checkBox1.TabIndex = 44;
            this.checkBox1.Text = "法人章";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox2.Location = new System.Drawing.Point(487, 911);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(239, 42);
            this.checkBox2.TabIndex = 45;
            this.checkBox2.Text = "财务专用章";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox3.Location = new System.Drawing.Point(745, 911);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(163, 42);
            this.checkBox3.TabIndex = 46;
            this.checkBox3.Text = "产品章";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox4.Location = new System.Drawing.Point(930, 911);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(163, 42);
            this.checkBox4.TabIndex = 47;
            this.checkBox4.Text = "托管行";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.account.Location = new System.Drawing.Point(96, 981);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(93, 38);
            this.account.TabIndex = 48;
            this.account.Text = "账号";
            // 
            // accountBox
            // 
            this.accountBox.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountBox.Location = new System.Drawing.Point(275, 969);
            this.accountBox.Name = "accountBox";
            this.accountBox.Size = new System.Drawing.Size(606, 50);
            this.accountBox.TabIndex = 49;
            // 
            // stampCard
            // 
            this.stampCard.AutoSize = true;
            this.stampCard.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stampCard.Location = new System.Drawing.Point(96, 1061);
            this.stampCard.Name = "stampCard";
            this.stampCard.Size = new System.Drawing.Size(131, 38);
            this.stampCard.TabIndex = 50;
            this.stampCard.Text = "印鉴卡";
            // 
            // stampCardBox
            // 
            this.stampCardBox.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stampCardBox.Location = new System.Drawing.Point(263, 1049);
            this.stampCardBox.Name = "stampCardBox";
            this.stampCardBox.Size = new System.Drawing.Size(606, 50);
            this.stampCardBox.TabIndex = 51;
            // 
            // stampPlaceBox
            // 
            this.stampPlaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stampPlaceBox.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stampPlaceBox.FormattingEnabled = true;
            this.stampPlaceBox.Items.AddRange(new object[] {
            "存款行保管",
            "共用印鉴卡",
            "客户联"});
            this.stampPlaceBox.Location = new System.Drawing.Point(930, 1049);
            this.stampPlaceBox.Name = "stampPlaceBox";
            this.stampPlaceBox.Size = new System.Drawing.Size(244, 45);
            this.stampPlaceBox.TabIndex = 52;
            this.stampPlaceBox.SelectedIndexChanged += new System.EventHandler(this.stampPlaceBox_SelectedIndexChanged);
            // 
            // letterPlaceBox
            // 
            this.letterPlaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.letterPlaceBox.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.letterPlaceBox.FormattingEnabled = true;
            this.letterPlaceBox.Items.AddRange(new object[] {
            "资金方",
            "托管行"});
            this.letterPlaceBox.Location = new System.Drawing.Point(1153, 593);
            this.letterPlaceBox.Name = "letterPlaceBox";
            this.letterPlaceBox.Size = new System.Drawing.Size(274, 45);
            this.letterPlaceBox.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(1718, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 38);
            this.label1.TabIndex = 54;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(96, 1151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 38);
            this.label2.TabIndex = 55;
            this.label2.Text = " ";
            // 
            // orderColumnBox
            // 
            this.orderColumnBox.AutoSize = true;
            this.orderColumnBox.Checked = true;
            this.orderColumnBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.orderColumnBox.Location = new System.Drawing.Point(103, 155);
            this.orderColumnBox.Name = "orderColumnBox";
            this.orderColumnBox.Size = new System.Drawing.Size(114, 28);
            this.orderColumnBox.TabIndex = 56;
            this.orderColumnBox.Text = "序号栏";
            this.orderColumnBox.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.Location = new System.Drawing.Point(1470, 204);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(194, 50);
            this.search.TabIndex = 57;
            this.search.Text = "搜索!";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1806, 1203);
            this.Controls.Add(this.search);
            this.Controls.Add(this.orderColumnBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.letterPlaceBox);
            this.Controls.Add(this.stampPlaceBox);
            this.Controls.Add(this.stampCardBox);
            this.Controls.Add(this.stampCard);
            this.Controls.Add(this.accountBox);
            this.Controls.Add(this.account);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.stamp);
            this.Controls.Add(this.paper2Box);
            this.Controls.Add(this.paper2);
            this.Controls.Add(this.paper1Box);
            this.Controls.Add(this.paper1);
            this.Controls.Add(this.interest3Box);
            this.Controls.Add(this.interest3);
            this.Controls.Add(this.interFeeBox);
            this.Controls.Add(this.interFee);
            this.Controls.Add(this.interest2Box);
            this.Controls.Add(this.interest2);
            this.Controls.Add(this.manageFeeBox);
            this.Controls.Add(this.manageFee);
            this.Controls.Add(this.tagBox);
            this.Controls.Add(this.tag);
            this.Controls.Add(this.letterNoBox);
            this.Controls.Add(this.letterNo);
            this.Controls.Add(this.interest1Box);
            this.Controls.Add(this.interest1);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.endTimer);
            this.Controls.Add(this.end);
            this.Controls.Add(this.startTimer);
            this.Controls.Add(this.start);
            this.Controls.Add(this.moneyBox);
            this.Controls.Add(this.money);
            this.Controls.Add(this.duebox);
            this.Controls.Add(this.due);
            this.Controls.Add(this.bankNameBox);
            this.Controls.Add(this.bankName);
            this.Controls.Add(this.numberbox);
            this.Controls.Add(this.number);
            this.Controls.Add(this.info);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productNameBox);
            this.Controls.Add(this.writeToExcel);
            this.Controls.Add(this.readExcel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "录入小助手O(∩_∩)O哈哈~";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion

        private System.Windows.Forms.Button readExcel;
        private System.Windows.Forms.Button writeToExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox productNameBox;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TextBox numberbox;
        private System.Windows.Forms.Label bankName;
        private System.Windows.Forms.TextBox bankNameBox;
        private System.Windows.Forms.Label due;
        private System.Windows.Forms.ComboBox duebox;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.TextBox moneyBox;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.DateTimePicker startTimer;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.DateTimePicker endTimer;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.TextBox rateBox;
        private System.Windows.Forms.Label interest1;
        private System.Windows.Forms.ComboBox interest1Box;
        private System.Windows.Forms.Label letterNo;
        private System.Windows.Forms.TextBox letterNoBox;
        private System.Windows.Forms.Label tag;
        private System.Windows.Forms.ComboBox tagBox;
        private System.Windows.Forms.Label manageFee;
        private System.Windows.Forms.TextBox manageFeeBox;
        private System.Windows.Forms.Label interest2;
        private System.Windows.Forms.ComboBox interest2Box;
        private System.Windows.Forms.Label interFee;
        private System.Windows.Forms.TextBox interFeeBox;
        private System.Windows.Forms.ComboBox interest3Box;
        private System.Windows.Forms.Label interest3;
        private System.Windows.Forms.Label paper1;
        private System.Windows.Forms.TextBox paper1Box;
        private System.Windows.Forms.Label paper2;
        private System.Windows.Forms.TextBox paper2Box;
        private System.Windows.Forms.Label stamp;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label account;
        private System.Windows.Forms.TextBox accountBox;
        private System.Windows.Forms.Label stampCard;
        private System.Windows.Forms.TextBox stampCardBox;
        private System.Windows.Forms.ComboBox stampPlaceBox;
        private System.Windows.Forms.ComboBox letterPlaceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox orderColumnBox;
        private System.Windows.Forms.Button search;
    }
}

