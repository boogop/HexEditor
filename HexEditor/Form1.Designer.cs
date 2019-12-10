namespace HexEditor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtHex = new System.Windows.Forms.RichTextBox();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuickShell = new System.Windows.Forms.Button();
            this.btnQuickBin = new System.Windows.Forms.Button();
            this.btnQuickHttp = new System.Windows.Forms.Button();
            this.pbShellex = new System.Windows.Forms.PictureBox();
            this.pbHTTP = new System.Windows.Forms.PictureBox();
            this.pbBinary = new System.Windows.Forms.PictureBox();
            this.pbEncrypted = new System.Windows.Forms.PictureBox();
            this.pbCompressed = new System.Windows.Forms.PictureBox();
            this.lblDOSHeader = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblHTTP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblShellEx = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBinary = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEncrypt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCompress = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAccessed = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCreated = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShellex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHTTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBinary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEncrypted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompressed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(351, 62);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtHex);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtText);
            this.splitContainer1.Size = new System.Drawing.Size(1187, 772);
            this.splitContainer1.SplitterDistance = 394;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtHex
            // 
            this.txtHex.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHex.Location = new System.Drawing.Point(0, 0);
            this.txtHex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(394, 772);
            this.txtHex.TabIndex = 0;
            this.txtHex.Text = "";
            // 
            // txtText
            // 
            this.txtText.BackColor = System.Drawing.Color.Gainsboro;
            this.txtText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtText.Location = new System.Drawing.Point(0, 0);
            this.txtText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(788, 772);
            this.txtText.TabIndex = 0;
            this.txtText.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DimGray;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 845);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1540, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.LightGray;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 20);
            this.lblStatus.Text = "Ready";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuickShell);
            this.groupBox1.Controls.Add(this.btnQuickBin);
            this.groupBox1.Controls.Add(this.btnQuickHttp);
            this.groupBox1.Controls.Add(this.pbShellex);
            this.groupBox1.Controls.Add(this.pbHTTP);
            this.groupBox1.Controls.Add(this.pbBinary);
            this.groupBox1.Controls.Add(this.pbEncrypted);
            this.groupBox1.Controls.Add(this.pbCompressed);
            this.groupBox1.Controls.Add(this.lblDOSHeader);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblLang);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblHTTP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblShellEx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblBinary);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblEncrypt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblCompress);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblAccessed);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Controls.Add(this.lblCreated);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(18, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(325, 763);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information && Search";
            // 
            // btnQuickShell
            // 
            this.btnQuickShell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuickShell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuickShell.ForeColor = System.Drawing.Color.Yellow;
            this.btnQuickShell.Image = global::HexEditor.Properties.Resources.ZoomHS;
            this.btnQuickShell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuickShell.Location = new System.Drawing.Point(53, 409);
            this.btnQuickShell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuickShell.Name = "btnQuickShell";
            this.btnQuickShell.Size = new System.Drawing.Size(100, 28);
            this.btnQuickShell.TabIndex = 71;
            this.btnQuickShell.Text = "  SHELL";
            this.btnQuickShell.UseVisualStyleBackColor = false;
            this.btnQuickShell.Click += new System.EventHandler(this.btnQuickShell_Click);
            // 
            // btnQuickBin
            // 
            this.btnQuickBin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuickBin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuickBin.ForeColor = System.Drawing.Color.Yellow;
            this.btnQuickBin.Image = global::HexEditor.Properties.Resources.ZoomHS;
            this.btnQuickBin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuickBin.Location = new System.Drawing.Point(53, 373);
            this.btnQuickBin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuickBin.Name = "btnQuickBin";
            this.btnQuickBin.Size = new System.Drawing.Size(100, 28);
            this.btnQuickBin.TabIndex = 70;
            this.btnQuickBin.Text = "  BIN";
            this.btnQuickBin.UseVisualStyleBackColor = false;
            this.btnQuickBin.Click += new System.EventHandler(this.btnQuickBin_Click);
            // 
            // btnQuickHttp
            // 
            this.btnQuickHttp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuickHttp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuickHttp.ForeColor = System.Drawing.Color.Yellow;
            this.btnQuickHttp.Image = global::HexEditor.Properties.Resources.ZoomHS;
            this.btnQuickHttp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuickHttp.Location = new System.Drawing.Point(53, 337);
            this.btnQuickHttp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuickHttp.Name = "btnQuickHttp";
            this.btnQuickHttp.Size = new System.Drawing.Size(100, 28);
            this.btnQuickHttp.TabIndex = 69;
            this.btnQuickHttp.Text = "  HTTP";
            this.btnQuickHttp.UseVisualStyleBackColor = false;
            this.btnQuickHttp.Click += new System.EventHandler(this.btnQuickHttp_Click);
            // 
            // pbShellex
            // 
            this.pbShellex.Image = global::HexEditor.Properties.Resources.greenon1;
            this.pbShellex.Location = new System.Drawing.Point(20, 225);
            this.pbShellex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbShellex.Name = "pbShellex";
            this.pbShellex.Size = new System.Drawing.Size(21, 21);
            this.pbShellex.TabIndex = 68;
            this.pbShellex.TabStop = false;
            // 
            // pbHTTP
            // 
            this.pbHTTP.Image = global::HexEditor.Properties.Resources.greenon1;
            this.pbHTTP.Location = new System.Drawing.Point(20, 198);
            this.pbHTTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbHTTP.Name = "pbHTTP";
            this.pbHTTP.Size = new System.Drawing.Size(21, 21);
            this.pbHTTP.TabIndex = 67;
            this.pbHTTP.TabStop = false;
            // 
            // pbBinary
            // 
            this.pbBinary.Image = global::HexEditor.Properties.Resources.greenon1;
            this.pbBinary.Location = new System.Drawing.Point(20, 170);
            this.pbBinary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBinary.Name = "pbBinary";
            this.pbBinary.Size = new System.Drawing.Size(21, 21);
            this.pbBinary.TabIndex = 66;
            this.pbBinary.TabStop = false;
            // 
            // pbEncrypted
            // 
            this.pbEncrypted.Image = global::HexEditor.Properties.Resources.greenon1;
            this.pbEncrypted.Location = new System.Drawing.Point(20, 142);
            this.pbEncrypted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbEncrypted.Name = "pbEncrypted";
            this.pbEncrypted.Size = new System.Drawing.Size(21, 21);
            this.pbEncrypted.TabIndex = 65;
            this.pbEncrypted.TabStop = false;
            // 
            // pbCompressed
            // 
            this.pbCompressed.Image = global::HexEditor.Properties.Resources.greenon1;
            this.pbCompressed.Location = new System.Drawing.Point(20, 113);
            this.pbCompressed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCompressed.Name = "pbCompressed";
            this.pbCompressed.Size = new System.Drawing.Size(21, 21);
            this.pbCompressed.TabIndex = 7;
            this.pbCompressed.TabStop = false;
            // 
            // lblDOSHeader
            // 
            this.lblDOSHeader.AutoSize = true;
            this.lblDOSHeader.Location = new System.Drawing.Point(145, 254);
            this.lblDOSHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOSHeader.Name = "lblDOSHeader";
            this.lblDOSHeader.Size = new System.Drawing.Size(83, 17);
            this.lblDOSHeader.TabIndex = 64;
            this.lblDOSHeader.Text = "Ref Shellex:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 254);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 63;
            this.label11.Text = "DOS Header:";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(145, 281);
            this.lblLang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(83, 17);
            this.lblLang.TabIndex = 62;
            this.lblLang.Text = "Ref Shellex:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 281);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 61;
            this.label10.Text = "Lang:";
            // 
            // lblHTTP
            // 
            this.lblHTTP.AutoSize = true;
            this.lblHTTP.Location = new System.Drawing.Point(145, 198);
            this.lblHTTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHTTP.Name = "lblHTTP";
            this.lblHTTP.Size = new System.Drawing.Size(75, 17);
            this.lblHTTP.TabIndex = 59;
            this.lblHTTP.Text = "Ref HTTP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Created:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Accessed:";
            // 
            // lblShellEx
            // 
            this.lblShellEx.AutoSize = true;
            this.lblShellEx.Location = new System.Drawing.Point(145, 225);
            this.lblShellEx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShellEx.Name = "lblShellEx";
            this.lblShellEx.Size = new System.Drawing.Size(83, 17);
            this.lblShellEx.TabIndex = 60;
            this.lblShellEx.Text = "Ref Shellex:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Compressed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Encrypted:";
            // 
            // lblBinary
            // 
            this.lblBinary.AutoSize = true;
            this.lblBinary.Location = new System.Drawing.Point(145, 171);
            this.lblBinary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(78, 17);
            this.lblBinary.TabIndex = 58;
            this.lblBinary.Text = "Ref Binary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Ref Binary:";
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.AutoSize = true;
            this.lblEncrypt.Location = new System.Drawing.Point(145, 144);
            this.lblEncrypt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(76, 17);
            this.lblEncrypt.TabIndex = 57;
            this.lblEncrypt.Text = "Encrypted:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 198);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Ref HTTP:";
            // 
            // lblCompress
            // 
            this.lblCompress.AutoSize = true;
            this.lblCompress.Location = new System.Drawing.Point(145, 117);
            this.lblCompress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompress.Name = "lblCompress";
            this.lblCompress.Size = new System.Drawing.Size(91, 17);
            this.lblCompress.TabIndex = 56;
            this.lblCompress.Text = "Compressed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "Ref Shellex:";
            // 
            // lblAccessed
            // 
            this.lblAccessed.AutoSize = true;
            this.lblAccessed.Location = new System.Drawing.Point(145, 90);
            this.lblAccessed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccessed.Name = "lblAccessed";
            this.lblAccessed.Size = new System.Drawing.Size(73, 17);
            this.lblAccessed.TabIndex = 55;
            this.lblAccessed.Text = "Accessed:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(145, 36);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(39, 17);
            this.lblSize.TabIndex = 53;
            this.lblSize.Text = "Size:";
            // 
            // lblCreated
            // 
            this.lblCreated.AutoSize = true;
            this.lblCreated.Location = new System.Drawing.Point(145, 63);
            this.lblCreated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(62, 17);
            this.lblCreated.TabIndex = 54;
            this.lblCreated.Text = "Created:";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackgroundImage = global::HexEditor.Properties.Resources.ace;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(53, 591);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 160);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HexEditor.Properties.Resources.DRAG1;
            this.pictureBox2.Location = new System.Drawing.Point(53, 565);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 18);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1540, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::HexEditor.Properties.Resources.saveHS;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::HexEditor.Properties.Resources.Book_openHS;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::HexEditor.Properties.Resources.DeleteHS;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HexEditor.Properties.Resources.split;
            this.pictureBox1.Location = new System.Drawing.Point(351, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 18);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1540, 870);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "HexEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShellex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHTTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBinary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEncrypted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompressed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.RichTextBox txtHex;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDOSHeader;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblHTTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblShellEx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBinary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEncrypt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCompress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAccessed;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.PictureBox pbShellex;
        private System.Windows.Forms.PictureBox pbHTTP;
        private System.Windows.Forms.PictureBox pbBinary;
        private System.Windows.Forms.PictureBox pbEncrypted;
        private System.Windows.Forms.PictureBox pbCompressed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnQuickShell;
        private System.Windows.Forms.Button btnQuickBin;
        private System.Windows.Forms.Button btnQuickHttp;
    }
}

