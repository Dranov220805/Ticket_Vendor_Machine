using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DAL;
using BAL;

namespace VendorMachineUI
{
    public partial class ChooseDestination : Form
    {
        private readonly CustomerService _customerService;
        public ChooseDestination()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _customerService = new CustomerService();
            CustomerData_Load();
        }
        private void CustomerData_Load()
        {
            Load_Data();
        }

        private void Load_Data()
        {
            var customers = _customerService.GetAllCustomers();

            if (customers == null || !customers.Any())
            {
                MessageBox.Show("No customers found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable table = new DataTable();
            table.Columns.Add("txtCustomerId", typeof(string));
            table.Columns.Add("txtCustomerName", typeof(string));
            table.Columns.Add("txtPhoneNumber", typeof(string));

            foreach (var customer in customers)
            {
                table.Rows.Add(
                    customer.CustomerId,
                    customer.CustomerName,
                    customer.PhoneNumber
                );
            }

            // Bind the DataTable to the existing DataGridView
            CustomerData.DataSource = table;

            //Ensure the columns match the predefined ones
            CustomerData.Columns["txtCustomerId"].DataPropertyName = "txtCustomerId";
            CustomerData.Columns["txtCustomerName"].DataPropertyName = "txtCustomerName";
            CustomerData.Columns["txtPhoneNumber"].DataPropertyName = "txtPhoneNumber";
        }
    }
}
