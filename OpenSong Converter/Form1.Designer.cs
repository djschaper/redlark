namespace OpenSong_Converter
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
            this.textBoxEditor = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.labelTempo = new System.Windows.Forms.Label();
            this.textBoxTempo = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.labelEditor = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAltTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelCopy = new System.Windows.Forms.Label();
            this.labelTimeSig = new System.Windows.Forms.Label();
            this.labelCCLI = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAltTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxCopy = new System.Windows.Forms.TextBox();
            this.textBoxCCLI = new System.Windows.Forms.TextBox();
            this.textBoxTimeSig = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxYouTube = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEditor
            // 
            this.textBoxEditor.AcceptsReturn = true;
            this.textBoxEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEditor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditor.Location = new System.Drawing.Point(283, 28);
            this.textBoxEditor.Multiline = true;
            this.textBoxEditor.Name = "textBoxEditor";
            this.textBoxEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEditor.Size = new System.Drawing.Size(471, 443);
            this.textBoxEditor.TabIndex = 10;
            this.textBoxEditor.TextChanged += new System.EventHandler(this.textBoxEditor_TextChanged);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(12, 235);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(25, 13);
            this.labelKey.TabIndex = 2;
            this.labelKey.Text = "Key";
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Location = new System.Drawing.Point(12, 209);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(40, 13);
            this.labelTempo.TabIndex = 5;
            this.labelTempo.Text = "Tempo";
            // 
            // textBoxTempo
            // 
            this.textBoxTempo.Location = new System.Drawing.Point(62, 206);
            this.textBoxTempo.Name = "textBoxTempo";
            this.textBoxTempo.Size = new System.Drawing.Size(37, 20);
            this.textBoxTempo.TabIndex = 7;
            this.textBoxTempo.TextChanged += new System.EventHandler(this.textBoxTempo_TextChanged);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(45, 232);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(51, 20);
            this.textBoxKey.TabIndex = 8;
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBoxKey_TextChanged);
            // 
            // labelEditor
            // 
            this.labelEditor.AutoSize = true;
            this.labelEditor.Location = new System.Drawing.Point(280, 13);
            this.labelEditor.Name = "labelEditor";
            this.labelEditor.Size = new System.Drawing.Size(34, 13);
            this.labelEditor.TabIndex = 7;
            this.labelEditor.Text = "Editor";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 53);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Title";
            // 
            // labelAltTitle
            // 
            this.labelAltTitle.AutoSize = true;
            this.labelAltTitle.Location = new System.Drawing.Point(12, 79);
            this.labelAltTitle.Name = "labelAltTitle";
            this.labelAltTitle.Size = new System.Drawing.Size(42, 13);
            this.labelAltTitle.TabIndex = 9;
            this.labelAltTitle.Text = "Alt Title";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(12, 105);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 10;
            this.labelAuthor.Text = "Author";
            // 
            // labelCopy
            // 
            this.labelCopy.AutoSize = true;
            this.labelCopy.Location = new System.Drawing.Point(12, 131);
            this.labelCopy.Name = "labelCopy";
            this.labelCopy.Size = new System.Drawing.Size(51, 13);
            this.labelCopy.TabIndex = 11;
            this.labelCopy.Text = "Copyright";
            // 
            // labelTimeSig
            // 
            this.labelTimeSig.AutoSize = true;
            this.labelTimeSig.Location = new System.Drawing.Point(12, 183);
            this.labelTimeSig.Name = "labelTimeSig";
            this.labelTimeSig.Size = new System.Drawing.Size(78, 13);
            this.labelTimeSig.TabIndex = 12;
            this.labelTimeSig.Text = "Time Signature";
            // 
            // labelCCLI
            // 
            this.labelCCLI.AutoSize = true;
            this.labelCCLI.Location = new System.Drawing.Point(12, 157);
            this.labelCCLI.Name = "labelCCLI";
            this.labelCCLI.Size = new System.Drawing.Size(40, 13);
            this.labelCCLI.TabIndex = 13;
            this.labelCCLI.Text = "CCLI #";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(45, 50);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(232, 20);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // textBoxAltTitle
            // 
            this.textBoxAltTitle.Location = new System.Drawing.Point(60, 76);
            this.textBoxAltTitle.Name = "textBoxAltTitle";
            this.textBoxAltTitle.Size = new System.Drawing.Size(217, 20);
            this.textBoxAltTitle.TabIndex = 2;
            this.textBoxAltTitle.TextChanged += new System.EventHandler(this.textBoxAltTitle_TextChanged);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(60, 102);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(217, 20);
            this.textBoxAuthor.TabIndex = 3;
            this.textBoxAuthor.TextChanged += new System.EventHandler(this.textBoxAuthor_TextChanged);
            // 
            // textBoxCopy
            // 
            this.textBoxCopy.Location = new System.Drawing.Point(69, 128);
            this.textBoxCopy.Name = "textBoxCopy";
            this.textBoxCopy.Size = new System.Drawing.Size(208, 20);
            this.textBoxCopy.TabIndex = 4;
            this.textBoxCopy.TextChanged += new System.EventHandler(this.textBoxCopy_TextChanged);
            // 
            // textBoxCCLI
            // 
            this.textBoxCCLI.Location = new System.Drawing.Point(58, 154);
            this.textBoxCCLI.Name = "textBoxCCLI";
            this.textBoxCCLI.Size = new System.Drawing.Size(100, 20);
            this.textBoxCCLI.TabIndex = 5;
            this.textBoxCCLI.TextChanged += new System.EventHandler(this.textBoxCCLI_TextChanged);
            // 
            // textBoxTimeSig
            // 
            this.textBoxTimeSig.Location = new System.Drawing.Point(96, 180);
            this.textBoxTimeSig.Name = "textBoxTimeSig";
            this.textBoxTimeSig.Size = new System.Drawing.Size(52, 20);
            this.textBoxTimeSig.TabIndex = 6;
            this.textBoxTimeSig.TextChanged += new System.EventHandler(this.textBoxTimeSig_TextChanged);
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
            // textBoxYouTube
            // 
            this.textBoxYouTube.Location = new System.Drawing.Point(92, 258);
            this.textBoxYouTube.Name = "textBoxYouTube";
            this.textBoxYouTube.Size = new System.Drawing.Size(185, 20);
            this.textBoxYouTube.TabIndex = 9;
            this.textBoxYouTube.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "YouTube Link";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 511);
            this.Controls.Add(this.textBoxYouTube);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxTimeSig);
            this.Controls.Add(this.textBoxCCLI);
            this.Controls.Add(this.textBoxCopy);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxAltTitle);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelCCLI);
            this.Controls.Add(this.labelTimeSig);
            this.Controls.Add(this.labelCopy);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelAltTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelEditor);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.labelTempo);
            this.Controls.Add(this.textBoxTempo);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textBoxEditor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 550);
            this.Name = "Form1";
            this.Text = "OpenSong Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEditor;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelTempo;
        private System.Windows.Forms.TextBox textBoxTempo;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label labelEditor;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAltTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelCopy;
        private System.Windows.Forms.Label labelTimeSig;
        private System.Windows.Forms.Label labelCCLI;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAltTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxCopy;
        private System.Windows.Forms.TextBox textBoxCCLI;
        private System.Windows.Forms.TextBox textBoxTimeSig;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxYouTube;
        private System.Windows.Forms.Label label1;
    }
}

