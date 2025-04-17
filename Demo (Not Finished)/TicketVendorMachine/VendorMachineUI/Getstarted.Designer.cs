namespace VendorMachineUI
{
    partial class Getstarted
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Getstarted));
            btnStart = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(297, 342);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(199, 60);
            btnStart.TabIndex = 0;
            btnStart.Text = "Get Started";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ImageLocation = "center";
            pictureBox1.Location = new Point(140, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 142);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.913044F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 222);
            label1.Name = "label1";
            label1.Size = new Size(291, 47);
            label1.TabIndex = 2;
            label1.Text = "Public Transport";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.913044F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(186, 269);
            label2.Name = "label2";
            label2.Size = new Size(400, 47);
            label2.TabIndex = 3;
            label2.Text = "Ticket Vendor Machine";
            // 
            // Getstarted
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnStart);
            Name = "Getstarted";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}
