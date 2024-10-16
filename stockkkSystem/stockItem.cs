using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockkkSystem
{
    public class StockItem
    {
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public int StockQuantity { get; set; }

        public StockItem(string code, string name, int quantity)
        {
            StockCode = code;
            StockName = name;
            StockQuantity = quantity;
        }

        public void AddStockItem(MySqlConnection connection)
        {
            string stockInsertQuery = "INSERT INTO stocktablefinal(stockCode, stockName, stockQuantity) VALUES(@stockCode, @stockName, @stockQuantity)";
            using (MySqlCommand stockCmd = new MySqlCommand(stockInsertQuery, connection))
            {
                stockCmd.Parameters.AddWithValue("@stockCode", StockCode);
                stockCmd.Parameters.AddWithValue("@stockName", StockName);
                stockCmd.Parameters.AddWithValue("@stockQuantity", StockQuantity);
                stockCmd.ExecuteNonQuery();
            }
        }

        public void DeleteStockItem(MySqlConnection connection)
        {
            // Check if the stock quantity is zero before deleting
            if (StockQuantity == 0)
            {
                string query = "DELETE FROM stocktablefinal WHERE stockCode = @stockCode";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@stockCode", StockCode);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                // Handle the case where the quantity is not zero (optional)
                // You can display a message or take other actions as needed.
                Console.WriteLine("Stock quantity is not zero, cannot delete.");
            }
        }
        }
    }

