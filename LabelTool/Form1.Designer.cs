namespace LabelTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pic_main = new System.Windows.Forms.PictureBox();
            this.pic_prev = new System.Windows.Forms.PictureBox();
            this.pic_next = new System.Windows.Forms.PictureBox();
            this.lbl_image_id = new System.Windows.Forms.Label();
            this.txt_image_id = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_image_dir = new System.Windows.Forms.Button();
            this.lb_image_ext = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_image_progess = new System.Windows.Forms.ProgressBar();
            this.txt_score = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_main
            // 
            this.pic_main.Location = new System.Drawing.Point(228, 41);
            this.pic_main.Name = "pic_main";
            this.pic_main.Size = new System.Drawing.Size(368, 305);
            this.pic_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_main.TabIndex = 0;
            this.pic_main.TabStop = false;
            // 
            // pic_prev
            // 
            this.pic_prev.Location = new System.Drawing.Point(28, 41);
            this.pic_prev.Name = "pic_prev";
            this.pic_prev.Size = new System.Drawing.Size(160, 115);
            this.pic_prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_prev.TabIndex = 1;
            this.pic_prev.TabStop = false;
            // 
            // pic_next
            // 
            this.pic_next.Location = new System.Drawing.Point(628, 41);
            this.pic_next.Name = "pic_next";
            this.pic_next.Size = new System.Drawing.Size(160, 115);
            this.pic_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_next.TabIndex = 2;
            this.pic_next.TabStop = false;
            // 
            // lbl_image_id
            // 
            this.lbl_image_id.AutoSize = true;
            this.lbl_image_id.Location = new System.Drawing.Point(12, 291);
            this.lbl_image_id.Name = "lbl_image_id";
            this.lbl_image_id.Size = new System.Drawing.Size(95, 20);
            this.lbl_image_id.TabIndex = 3;
            this.lbl_image_id.Text = "DESEN_ID:";
            // 
            // txt_image_id
            // 
            this.txt_image_id.Location = new System.Drawing.Point(113, 288);
            this.txt_image_id.Name = "txt_image_id";
            this.txt_image_id.Size = new System.Drawing.Size(100, 26);
            this.txt_image_id.TabIndex = 4;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(480, 390);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(116, 32);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = "NEXT";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(228, 390);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(116, 32);
            this.btn_prev.TabIndex = 6;
            this.btn_prev.Text = "PREVIOUS";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_0);
            this.panel1.Controls.Add(this.btn_3);
            this.panel1.Controls.Add(this.btn_2);
            this.panel1.Controls.Add(this.btn_6);
            this.panel1.Controls.Add(this.btn_5);
            this.panel1.Controls.Add(this.btn_1);
            this.panel1.Controls.Add(this.btn_4);
            this.panel1.Controls.Add(this.btn_9);
            this.panel1.Controls.Add(this.btn_8);
            this.panel1.Controls.Add(this.btn_7);
            this.panel1.Location = new System.Drawing.Point(616, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 206);
            this.panel1.TabIndex = 7;
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(65, 155);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(49, 46);
            this.btn_0.TabIndex = 17;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(118, 103);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(49, 46);
            this.btn_3.TabIndex = 16;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(65, 103);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(49, 46);
            this.btn_2.TabIndex = 15;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(118, 54);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(49, 46);
            this.btn_6.TabIndex = 14;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(65, 55);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(49, 46);
            this.btn_5.TabIndex = 13;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(10, 103);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(49, 46);
            this.btn_1.TabIndex = 12;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(10, 54);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(49, 46);
            this.btn_4.TabIndex = 11;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(118, 3);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(49, 46);
            this.btn_9.TabIndex = 10;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(65, 3);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(49, 46);
            this.btn_8.TabIndex = 9;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(10, 3);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(49, 46);
            this.btn_7.TabIndex = 8;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_image_dir
            // 
            this.btn_image_dir.Location = new System.Drawing.Point(28, 178);
            this.btn_image_dir.Name = "btn_image_dir";
            this.btn_image_dir.Size = new System.Drawing.Size(169, 61);
            this.btn_image_dir.TabIndex = 8;
            this.btn_image_dir.Text = "Choose Image Directory";
            this.btn_image_dir.UseVisualStyleBackColor = true;
            this.btn_image_dir.Click += new System.EventHandler(this.btn_image_dir_Click);
            // 
            // lb_image_ext
            // 
            this.lb_image_ext.FormattingEnabled = true;
            this.lb_image_ext.ItemHeight = 20;
            this.lb_image_ext.Items.AddRange(new object[] {
            "png",
            "jpg",
            "jpeg",
            "bmp",
            "tif",
            "tiff"});
            this.lb_image_ext.Location = new System.Drawing.Point(132, 249);
            this.lb_image_ext.Name = "lb_image_ext";
            this.lb_image_ext.Size = new System.Drawing.Size(70, 24);
            this.lb_image_ext.TabIndex = 10;
            this.lb_image_ext.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Image ext:";
            // 
            // pb_image_progess
            // 
            this.pb_image_progess.Location = new System.Drawing.Point(228, 355);
            this.pb_image_progess.Name = "pb_image_progess";
            this.pb_image_progess.Size = new System.Drawing.Size(368, 23);
            this.pb_image_progess.TabIndex = 12;
            // 
            // txt_score
            // 
            this.txt_score.Location = new System.Drawing.Point(113, 320);
            this.txt_score.Name = "txt_score";
            this.txt_score.ReadOnly = true;
            this.txt_score.Size = new System.Drawing.Size(100, 26);
            this.txt_score.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "SCORE:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(358, 390);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(116, 32);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_image_progess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_image_ext);
            this.Controls.Add(this.btn_image_dir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.txt_image_id);
            this.Controls.Add(this.lbl_image_id);
            this.Controls.Add(this.pic_next);
            this.Controls.Add(this.pic_prev);
            this.Controls.Add(this.pic_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Label Tool";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_main;
        private System.Windows.Forms.PictureBox pic_prev;
        private System.Windows.Forms.PictureBox pic_next;
        private System.Windows.Forms.Label lbl_image_id;
        private System.Windows.Forms.TextBox txt_image_id;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_image_dir;
        private System.Windows.Forms.ListBox lb_image_ext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pb_image_progess;
        private System.Windows.Forms.TextBox txt_score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
    }
}

