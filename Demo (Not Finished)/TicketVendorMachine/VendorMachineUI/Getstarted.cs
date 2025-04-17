using System;
using Microsoft.EntityFrameworkCore;
using DAL;
using BAL;
using System.Configuration;

namespace VendorMachineUI
{
    public partial class Getstarted : Form
    {
        public Getstarted()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.btnStart.Click += new EventHandler(this.btnStart_Click);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Open the main form
            var destinationForm = new ChooseDestination();
            destinationForm.Show();
            this.Hide();
        }
    }
}
