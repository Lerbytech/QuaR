namespace GraphicsTest
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
            this.components = new System.ComponentModel.Container();
            this.MsgTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ManualTextBox = new System.Windows.Forms.TextBox();
            this.SaveImgBtn = new System.Windows.Forms.Button();
            this.ManGenerateBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MsgTextBox
            // 
            this.MsgTextBox.Location = new System.Drawing.Point(185, 12);
            this.MsgTextBox.Name = "MsgTextBox";
            this.MsgTextBox.ReadOnly = true;
            this.MsgTextBox.Size = new System.Drawing.Size(125, 22);
            this.MsgTextBox.TabIndex = 0;
            // 
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(12, 12);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(92, 23);
            this.GenerateBtn.TabIndex = 1;
            this.GenerateBtn.Text = "Generate!";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "message:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "manual:";
            // 
            // ManualTextBox
            // 
            this.ManualTextBox.Location = new System.Drawing.Point(705, 13);
            this.ManualTextBox.Name = "ManualTextBox";
            this.ManualTextBox.Size = new System.Drawing.Size(100, 22);
            this.ManualTextBox.TabIndex = 4;
            // 
            // SaveImgBtn
            // 
            this.SaveImgBtn.Location = new System.Drawing.Point(336, 9);
            this.SaveImgBtn.Name = "SaveImgBtn";
            this.SaveImgBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveImgBtn.TabIndex = 5;
            this.SaveImgBtn.Text = "Save";
            this.SaveImgBtn.UseVisualStyleBackColor = true;
            this.SaveImgBtn.Click += new System.EventHandler(this.SaveImgBtn_Click);
            // 
            // ManGenerateBtn
            // 
            this.ManGenerateBtn.Location = new System.Drawing.Point(824, 10);
            this.ManGenerateBtn.Name = "ManGenerateBtn";
            this.ManGenerateBtn.Size = new System.Drawing.Size(75, 23);
            this.ManGenerateBtn.TabIndex = 6;
            this.ManGenerateBtn.Text = "Show";
            this.ManGenerateBtn.UseVisualStyleBackColor = true;
            this.ManGenerateBtn.Click += new System.EventHandler(this.ManGenerateBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1277, 617);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 670);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ManGenerateBtn);
            this.Controls.Add(this.SaveImgBtn);
            this.Controls.Add(this.ManualTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.MsgTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MsgTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ManualTextBox;
        private System.Windows.Forms.Button SaveImgBtn;
        private System.Windows.Forms.Button ManGenerateBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

