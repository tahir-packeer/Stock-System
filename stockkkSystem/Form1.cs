using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace stockkkSystem


{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;user id=root;password=;database=stocksystemfinal");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(scode.Text) || string.IsNullOrWhiteSpace(sname.Text) || string.IsNullOrWhiteSpace(squantity.Text))
            {
                MessageBox.Show("Please input all fields.");
                return;
            }

            if (!int.TryParse(squantity.Text, out int stockQuantity))
            {
                MessageBox.Show("Invalid input for Stock Quantity. Please enter a valid number.");
                return;
            }

            if (!IsLettersOnly(sname.Text))
            {
                MessageBox.Show("Invalid input for Stock Name. Please use letters only.");
                return;
            }

            if (StockCodeExists(scode.Text))
            {
                MessageBox.Show("Stock item already exists.");
                return;
            }

            StockItem stockItem = new StockItem(scode.Text, sname.Text, stockQuantity);
            TransactionLog transactionLog = new TransactionLog("Added", scode.Text, sname.Text, stockQuantity);

            connection.Open();
            stockItem.AddStockItem(connection);
            transactionLog.AddToTransactionLog(connection);
            connection.Close();

            MessageBox.Show("Successfully saved to both tables");
        }

        private bool IsLettersOnly(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && input.All(char.IsLetter);
        }
        private bool StockCodeExists(string stockCode)
        {
            string query = "SELECT COUNT(*) FROM stocktablefinal WHERE stockCode = @stockCode";
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@stockCode", stockCode);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                return count > 0;
            }
        }
        private void viewStockBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=stocksystemfinal";
            string query = "SELECT * FROM stocktablefinal";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void viewTransBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=stocksystemfinal";
            string query = "SELECT * FROM transactiontablefinal";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Check if Stock Code is empty
            if (string.IsNullOrWhiteSpace(scode.Text))
            {
                MessageBox.Show("Please input the Stock Code.");
                return; // Exit the method without deleting
            }

            // Check if the item exists in the database
            if (!StockCodeExists(scode.Text))
            {
                MessageBox.Show("Stock item does not exist.");
                return; // Exit the method without deleting
            }

            // Check if Stock Quantity is greater than 0
            if (StockQuantityGreaterThanZero(scode.Text))
            {
                MessageBox.Show("You cannot delete this item because the quantity is greater than 0.");
                return; // Exit the method without deleting
            }

            // Stock item exists, and Stock Quantity is 0, proceed with deletion
            string stockName = GetStockName(scode.Text); // Get the stock name for the transaction log
            StockItem stockItem = new StockItem(scode.Text, "", 0);

            connection.Open();

            // Add a transaction log entry for the deletion
            TransactionLog transactionLog = new TransactionLog("Deleted", scode.Text, stockName, 0);
            transactionLog.AddToTransactionLog(connection);

            // Delete the stock item
            stockItem.DeleteStockItem(connection);

            connection.Close();

            MessageBox.Show("Deleted successfully!");
        }

        private string GetStockName(string stockCode)
        {
            string query = "SELECT stockName FROM stocktablefinal WHERE stockCode = @stockCode";
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@stockCode", stockCode);
                string stockName = cmd.ExecuteScalar() as string;
                conn.Close();

                return stockName;
            }
        }
        private bool StockQuantityGreaterThanZero(string stockCode)
        {
            string query = "SELECT stockQuantity FROM stocktablefinal WHERE stockCode = @stockCode";
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@stockCode", stockCode);
                int stockQuantity = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                return stockQuantity > 0;
            }
        }
    }
}