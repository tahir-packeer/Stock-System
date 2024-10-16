using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockkkSystem
{
    public class TransactionLog
    {
        public DateTime DateAndTime { get; set; }
        public string ItemStatus { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public int StockQuantity { get; set; }

        public TransactionLog(string status, string code, string name, int quantity)
        {
            DateAndTime = DateTime.Now;
            ItemStatus = status;
            StockCode = code;
            StockName = name;
            StockQuantity = quantity;
        }

        public void AddToTransactionLog(MySqlConnection connection)
        {
            // Check if a record with the same stockCode already exists in the transaction table
            string checkQuery = "SELECT COUNT(*) FROM transactiontablefinal WHERE stockCode = @stockCode";
            using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
            {
                checkCmd.Parameters.AddWithValue("@stockCode", StockCode);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                // Only insert if there is no existing record with the same stockCode
                if (count == 0)
                {
                    string transactionLogInsertQuery = "INSERT INTO transactiontablefinal(dateAndTimeOfTheTransaction, itemStatus, stockCode, stockName, stockQuantity) VALUES(@dateAndTime, @itemStatus, @stockCode, @stockName, @stockQuantity)";
                    using (MySqlCommand transactionLogCmd = new MySqlCommand(transactionLogInsertQuery, connection))
                    {
                        transactionLogCmd.Parameters.AddWithValue("@dateAndTime", DateAndTime);
                        transactionLogCmd.Parameters.AddWithValue("@itemStatus", ItemStatus);
                        transactionLogCmd.Parameters.AddWithValue("@stockCode", StockCode);
                        transactionLogCmd.Parameters.AddWithValue("@stockName", StockName);
                        transactionLogCmd.Parameters.AddWithValue("@stockQuantity", StockQuantity);
                        transactionLogCmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    // Handle the case where a record with the same stockCode already exists (optional)
                    // You can display a message or take other actions as needed.
                    Console.WriteLine("Record with stockCode already exists in the transaction table.");
                }
            }
        }
    }
}
