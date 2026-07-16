using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;


namespace SearchFilterSortApp
{
    public partial class Form1 : Form
    {
        private string connectionString =
    @"Server=(localdb)\MSSQLLocalDB;Database=CustomerDB;Trusted_Connection=True;TrustServerCertificate=True;";

        private void LoadCustomers(string sql)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvCustomers.DataSource = table;

                        UpdateRecordCount();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records.\n\n" + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void UpdateRecordCount()
        {
            int count = dgvCustomers.Rows.Count;

            lblRecordCount.Text = $"Records: {count}";
        }
        private void LoadCityFilter()
        {
            cmbCity.Items.Clear();
            cmbCity.Items.Add("All");

            string sql = "SELECT DISTINCT City FROM Customers ORDER BY City";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbCity.Items.Add(reader["City"].ToString());
                            }
                        }
                    }
                }

                cmbCity.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading city filter.\n\n" + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void LoadCustomerTypeFilter()
        {
            cmbCustomerType.Items.Clear();
            cmbCustomerType.Items.Add("All");

            string sql = "SELECT DISTINCT CustomerType FROM Customers ORDER BY CustomerType";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbCustomerType.Items.Add(reader["CustomerType"].ToString());
                            }
                        }
                    }
                }

                cmbCustomerType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer type filter.\n\n" + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadCustomers("SELECT Id, CustomerId, CustomerName, PhoneNumber, Email, City, CustomerType FROM Customers ORDER BY Id DESC");

            LoadCityFilter();
            LoadCustomerTypeFilter();

            lblRecordCount.Text = "Records: 0";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (searchText == "")
            {
                MessageBox.Show("Please enter a customer name to search.",
                                "Missing Search Text",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtSearch.Focus();
                return;
            }

            string sql = @"SELECT Id, CustomerId, CustomerName, PhoneNumber, Email, City, CustomerType
                   FROM Customers
                   WHERE CustomerName LIKE @SearchText
                   ORDER BY CustomerName";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvCustomers.DataSource = table;

                        UpdateRecordCount();

                        if (table.Rows.Count == 0)
                        {
                            MessageBox.Show("No matching customer found.",
                                            "Search Result",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching records.\n\n" + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string city = cmbCity.Text;
            string customerType = cmbCustomerType.Text;

            string sql = @"SELECT Id, CustomerId, CustomerName, PhoneNumber, Email, City, CustomerType
                   FROM Customers
                   WHERE 1 = 1";

            if (city != "All" && city != "")
            {
                sql += " AND City = @City";
            }

            if (customerType != "All" && customerType != "")
            {
                sql += " AND CustomerType = @CustomerType";
            }

            sql += " ORDER BY CustomerName";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                    {
                        if (city != "All" && city != "")
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@City", city);
                        }

                        if (customerType != "All" && customerType != "")
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@CustomerType", customerType);
                        }

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvCustomers.DataSource = table;

                        UpdateRecordCount();

                        if (table.Rows.Count == 0)
                        {
                            MessageBox.Show("No records found for the selected filter.",
                                            "Filter Result",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering records.\n\n" + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            if (cmbCity.Items.Count > 0)
            {
                cmbCity.SelectedIndex = 0;
            }

            if (cmbCustomerType.Items.Count > 0)
            {
                cmbCustomerType.SelectedIndex = 0;
            }

            LoadCustomers("SELECT Id, CustomerId, CustomerName, PhoneNumber, Email, City, CustomerType FROM Customers ORDER BY Id DESC");

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomers("SELECT Id, CustomerId, CustomerName, PhoneNumber, Email, City, CustomerType FROM Customers ORDER BY Id DESC");

            LoadCityFilter();
            LoadCustomerTypeFilter();

            txtSearch.Clear();

        }

        private void btnSortName_Click(object sender, EventArgs e)
        {

            LoadCustomers("SELECT Id, CustomerId, CustomerName, PhoneNumber, Email, City, CustomerType FROM Customers ORDER BY CustomerName ASC");

        }

        private void btnSortCity_Click(object sender, EventArgs e)
        {

            LoadCustomers("SELECT Id, CustomerId, CustomerName, PhoneNumber, Email, City, CustomerType FROM Customers ORDER BY City ASC, CustomerName ASC");

        }

        private void btnSortNewest_Click(object sender, EventArgs e)
        {
            LoadCustomers("SELECT Id, CustomerId, CustomerName, PhoneNumber, Email, City, CustomerType FROM Customers ORDER BY Id DESC");
        }
    }
}
