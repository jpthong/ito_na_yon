using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghotel
{
    internal class function
    {
        private string connectionString = "Host=coping-rooster-26499.j77.aws-ap-southeast-1.cockroachlabs.cloud;" +
            "Port=26257;Database=defaultdb;SSL Mode=Require;" +
            "Password=QwbNyu3UKcSZJsilx4dvxA;Username=francis;Trust Server Certificate=true";

        // Reusable connection method
        protected NpgsqlConnection getConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

        // For SELECT queries - returns a DataSet
        public DataSet getData(string query)
        {
            NpgsqlConnection con = getConnection();
            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        // For INSERT, UPDATE, DELETE queries
        public void setData(string query, string message)
        {
            NpgsqlConnection con = getConnection();
            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("'" + message + "'", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}