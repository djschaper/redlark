namespace redlark
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
            if (disposing && (components != null)) {
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
            this.lblKey = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblEditor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAltTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCopy = new System.Windows.Forms.Label();
            this.lblTimeSig = new System.Windows.Forms.Label();
            this.lblCCLI = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAltTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtCopy = new System.Windows.Forms.TextBox();
            this.txtCCLI = new System.Windows.Forms.TextBox();
            this.txtTimeSig = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.txtYouTube = new System.Windows.Forms.TextBox();
            this.lblYoutube = new System.Windows.Forms.Label();
            this.rtxtEditor = new System.Windows.Forms.RichTextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(12, 235);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(25, 13);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "Key";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(12, 209);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(40, 13);
            this.lblTempo.TabIndex = 5;
            this.lblTempo.Text = "Tempo";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(62, 206);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(37, 20);
            this.txtTempo.TabIndex = 7;
            this.txtTempo.TextChanged += new System.EventHandler(this.textBoxTempo_TextChanged);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(45, 232);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(51, 20);
            this.txtKey.TabIndex = 8;
            this.txtKey.TextChanged += new System.EventHandler(this.textBoxKey_TextChanged);
            // 
            // lblEditor
            // 
            this.lblEditor.AutoSize = true;
            this.lblEditor.Location = new System.Drawing.Point(280, 13);
            this.lblEditor.Name = "lblEditor";
            this.lblEditor.Size = new System.Drawing.Size(34, 13);
            this.lblEditor.TabIndex = 7;
            this.lblEditor.Text = "Editor";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title";
            // 
            // lblAltTitle
            // 
            this.lblAltTitle.AutoSize = true;
            this.lblAltTitle.Location = new System.Drawing.Point(12, 79);
            this.lblAltTitle.Name = "lblAltTitle";
            this.lblAltTitle.Size = new System.Drawing.Size(42, 13);
            this.lblAltTitle.TabIndex = 9;
            this.lblAltTitle.Text = "Alt Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(12, 105);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 10;
            this.lblAuthor.Text = "Author";
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Location = new System.Drawing.Point(12, 131);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(51, 13);
            this.lblCopy.TabIndex = 11;
            this.lblCopy.Text = "Copyright";
            // 
            // lblTimeSig
            // 
            this.lblTimeSig.AutoSize = true;
            this.lblTimeSig.Location = new System.Drawing.Point(12, 183);
            this.lblTimeSig.Name = "lblTimeSig";
            this.lblTimeSig.Size = new System.Drawing.Size(78, 13);
            this.lblTimeSig.TabIndex = 12;
            this.lblTimeSig.Text = "Time Signature";
            // 
            // lblCCLI
            // 
            this.lblCCLI.AutoSize = true;
            this.lblCCLI.Location = new System.Drawing.Point(12, 157);
            this.lblCCLI.Name = "lblCCLI";
            this.lblCCLI.Size = new System.Drawing.Size(40, 13);
            this.lblCCLI.TabIndex = 13;
            this.lblCCLI.Text = "CCLI #";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(45, 50);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(232, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // txtAltTitle
            // 
            this.txtAltTitle.Location = new System.Drawing.Point(60, 76);
            this.txtAltTitle.Name = "txtAltTitle";
            this.txtAltTitle.Size = new System.Drawing.Size(217, 20);
            this.txtAltTitle.TabIndex = 2;
            this.txtAltTitle.TextChanged += new System.EventHandler(this.textBoxAltTitle_TextChanged);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(60, 102);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(217, 20);
            this.txtAuthor.TabIndex = 3;
            this.txtAuthor.TextChanged += new System.EventHandler(this.textBoxAuthor_TextChanged);
            // 
            // txtCopy
            // 
            this.txtCopy.Location = new System.Drawing.Point(69, 128);
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.Size = new System.Drawing.Size(208, 20);
            this.txtCopy.TabIndex = 4;
            this.txtCopy.TextChanged += new System.EventHandler(this.textBoxCopy_TextChanged);
            // 
            // txtCCLI
            // 
            this.txtCCLI.Location = new System.Drawing.Point(58, 154);
            this.txtCCLI.Name = "txtCCLI";
            this.txtCCLI.Size = new System.Drawing.Size(100, 20);
            this.txtCCLI.TabIndex = 5;
            this.txtCCLI.TextChanged += new System.EventHandler(this.textBoxCCLI_TextChanged);
            // 
            // txtTimeSig
            // 
            this.txtTimeSig.Location = new System.Drawing.Point(96, 180);
            this.txtTimeSig.Name = "txtTimeSig";
            this.txtTimeSig.Size = new System.Drawing.Size(52, 20);
            this.txtTimeSig.TabIndex = 6;
            this.txtTimeSig.TextChanged += new System.EventHandler(this.textBoxTimeSig_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(13, 13);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(114, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open CCLI Text File";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(636, 476);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(118, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save OpenSong File";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // txtYouTube
            // 
            this.txtYouTube.Location = new System.Drawing.Point(92, 258);
            this.txtYouTube.Name = "txtYouTube";
            this.txtYouTube.Size = new System.Drawing.Size(185, 20);
            this.txtYouTube.TabIndex = 9;
            this.txtYouTube.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblYoutube
            // 
            this.lblYoutube.AutoSize = true;
            this.lblYoutube.Location = new System.Drawing.Point(12, 261);
            this.lblYoutube.Name = "lblYoutube";
            this.lblYoutube.Size = new System.Drawing.Size(74, 13);
            this.lblYoutube.TabIndex = 14;
            this.lblYoutube.Text = "YouTube Link";
            // 
            // rtxtEditor
            // 
            this.rtxtEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtEditor.DetectUrls = false;
            this.rtxtEditor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtEditor.Location = new System.Drawing.Point(283, 29);
            this.rtxtEditor.Name = "rtxtEditor";
            this.rtxtEditor.Size = new System.Drawing.Size(471, 441);
            this.rtxtEditor.TabIndex = 10;
            this.rtxtEditor.Text = "";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(10, 489);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(62, 13);
            this.lblVersion.TabIndex = 15;
            this.lblVersion.Text = "app version";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 511);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.rtxtEditor);
            this.Controls.Add(this.txtYouTube);
            this.Controls.Add(this.lblYoutube);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.txtTimeSig);
            this.Controls.Add(this.txtCCLI);
            this.Controls.Add(this.txtCopy);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtAltTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblCCLI);
            this.Controls.Add(this.lblTimeSig);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblAltTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEditor);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 550);
            this.Name = "Form1";
            this.Text = "OpenSong Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblEditor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAltTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.Label lblTimeSig;
        private System.Windows.Forms.Label lblCCLI;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAltTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtCopy;
        private System.Windows.Forms.TextBox txtCCLI;
        private System.Windows.Forms.TextBox txtTimeSig;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox txtYouTube;
        private System.Windows.Forms.Label lblYoutube;
        private System.Windows.Forms.RichTextBox rtxtEditor;
        private System.Windows.Forms.Label lblVersion;
    }
}

