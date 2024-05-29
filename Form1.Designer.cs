namespace mome
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ckhide = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Kor",
            "Eng",
            "Jap",
            "Chi"});
            this.cb1.Location = new System.Drawing.Point(388, 126);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(273, 20);
            this.cb1.TabIndex = 4;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt1.Location = new System.Drawing.Point(99, 152);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt1.Size = new System.Drawing.Size(273, 351);
            this.txt1.TabIndex = 6;
            // 
            // txt2
            // 
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2.Location = new System.Drawing.Point(388, 152);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt2.Size = new System.Drawing.Size(273, 351);
            this.txt2.TabIndex = 7;
            // 
            // btnT
            // 
            this.btnT.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnT.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnT.FlatAppearance.BorderSize = 0;
            this.btnT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnT.Location = new System.Drawing.Point(575, 94);
            this.btnT.Margin = new System.Windows.Forms.Padding(0);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(86, 29);
            this.btnT.TabIndex = 10;
            this.btnT.Text = "Translate";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hobo BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(376, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Olive Translator";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(22, 510);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 32);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(315, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 51);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(44, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 17);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt3
            // 
            this.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt3.Location = new System.Drawing.Point(680, 152);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt3.Size = new System.Drawing.Size(273, 351);
            this.txt3.TabIndex = 15;
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "Kor",
            "Eng",
            "Jap",
            "Chi"});
            this.cb2.Location = new System.Drawing.Point(680, 126);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(273, 20);
            this.cb2.TabIndex = 14;
            this.cb2.SelectedIndexChanged += new System.EventHandler(this.cb2_SelectedIndexChanged);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.ckhide);
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.button2);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(170, 551);
            this.panel.TabIndex = 18;
            this.panel.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 56);
            this.button2.TabIndex = 20;
            this.button2.Text = "PDF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(0, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 56);
            this.button1.TabIndex = 21;
            this.button1.Text = "Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckhide
            // 
            this.ckhide.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ckhide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ckhide.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ckhide.FlatAppearance.BorderSize = 0;
            this.ckhide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ckhide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ckhide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckhide.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ckhide.Location = new System.Drawing.Point(0, 525);
            this.ckhide.Name = "ckhide";
            this.ckhide.Size = new System.Drawing.Size(168, 24);
            this.ckhide.TabIndex = 22;
            this.ckhide.Text = "<";
            this.ckhide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckhide.UseVisualStyleBackColor = true;
            this.ckhide.CheckedChanged += new System.EventHandler(this.ckhide_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(988, 551);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.cb1);
            this.Name = "Form1";
            this.Text = "Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckhide;
        private System.Windows.Forms.Timer timer;
    }
}

