namespace FaceRecogniztion
{
    partial class faceDetect
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(faceDetect));
            this.picShow = new System.Windows.Forms.PictureBox();
            this.sampleBox = new System.Windows.Forms.PictureBox();
            this.fullname = new System.Windows.Forms.TextBox();
            this.获取样本图片 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.recognizerType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picShow
            // 
            this.picShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShow.Location = new System.Drawing.Point(12, 12);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(415, 329);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShow.TabIndex = 0;
            this.picShow.TabStop = false;
            // 
            // sampleBox
            // 
            this.sampleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sampleBox.Location = new System.Drawing.Point(467, 35);
            this.sampleBox.Name = "sampleBox";
            this.sampleBox.Size = new System.Drawing.Size(100, 100);
            this.sampleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sampleBox.TabIndex = 2;
            this.sampleBox.TabStop = false;
            this.sampleBox.Click += new System.EventHandler(this.sampleBox_Click);
            // 
            // fullname
            // 
            this.fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullname.Location = new System.Drawing.Point(483, 163);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(104, 21);
            this.fullname.TabIndex = 3;
            // 
            // 获取样本图片
            // 
            this.获取样本图片.Location = new System.Drawing.Point(467, 190);
            this.获取样本图片.Name = "获取样本图片";
            this.获取样本图片.Size = new System.Drawing.Size(91, 24);
            this.获取样本图片.TabIndex = 4;
            this.获取样本图片.Text = "保存样本图片";
            this.获取样本图片.UseVisualStyleBackColor = true;
            this.获取样本图片.Click += new System.EventHandler(this.获取样本图片_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(436, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(564, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 24);
            this.button4.TabIndex = 6;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "姓名：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "设置识别类";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // recognizerType
            // 
            this.recognizerType.FormattingEnabled = true;
            this.recognizerType.Items.AddRange(new object[] {
            "EigenFaceRecognizer",
            "FisherFaceRecognizer",
            "LBPHFaceRecognizer"});
            this.recognizerType.Location = new System.Drawing.Point(437, 223);
            this.recognizerType.Name = "recognizerType";
            this.recognizerType.Size = new System.Drawing.Size(149, 20);
            this.recognizerType.TabIndex = 12;
            this.recognizerType.Text = "EigenFaceRecognizer";
            // 
            // faceDetect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 352);
            this.Controls.Add(this.recognizerType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.获取样本图片);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.sampleBox);
            this.Controls.Add(this.picShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "faceDetect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人脸识别";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.PictureBox sampleBox;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.Button 获取样本图片;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox recognizerType;
    }
}