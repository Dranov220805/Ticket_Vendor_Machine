namespace VendorMachineUI
{
    partial class ChooseDestination
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
            CustomerData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CustomerData).BeginInit();
            SuspendLayout();
            // 
            // CustomerData
            // 
            CustomerData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerData.Location = new Point(12, 93);
            CustomerData.Name = "CustomerData";
            CustomerData.RowHeadersWidth = 49;
            CustomerData.Size = new Size(776, 335);
            CustomerData.TabIndex = 0;
            // 
            // ChooseDestination
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CustomerData);
            Name = "ChooseDestination";
            Text = "ChooseDestination";
            ((System.ComponentModel.ISupportInitialize)CustomerData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CustomerData;
    }
}