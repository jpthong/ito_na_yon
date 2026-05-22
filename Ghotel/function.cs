using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ghotel
{
    internal class function
    {
        private string connectionString =
            "Host=coping-rooster-26499.j77.aws-ap-southeast-1.cockroachlabs.cloud;" +
            "Port=26257;Database=defaultdb;SSL Mode=Require;" +
            "Password=QwbNyu3UKcSZJsilx4dvxA;Username=francis;Trust Server Certificate=true";

        public NpgsqlConnection getConnection()
        { 
            return new NpgsqlConnection(connectionString);
        }

        public DataSet getData(string query)
        {
            using (NpgsqlConnection con = getConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public void setData(string query, string message)
        {
            using (NpgsqlConnection con = getConnection())
            {
                con.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show(message, "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public NpgsqlDataReader getForCombo(string query)
        {
            NpgsqlConnection con = getConnection();
            con.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}