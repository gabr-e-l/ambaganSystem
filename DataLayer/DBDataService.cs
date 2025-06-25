using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using static AmbagCommon.AmbagData;


namespace DataLayer
{
    public class DBDataService : IAmbagDataService
    {
        private static string connectionString =
            "Data Source=AIELLO\\SQLEXPRESS; Initial Catalog=AmbaganDB; Integrated Security=True; TrustServerCertificate=True;";

        private static SqlConnection sqlConnection;

        public DBDataService()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void AddEntry(AmbagEntry entry)
        {
            var insertStatement = @"INSERT INTO Ambagan_Entries (ListName, Name, SetAmount, AmountGiven, Change) 
                                    VALUES (@ListName, @Name, @SetAmount, @AmountGiven, @Change)";
            SqlCommand cmd = new SqlCommand(insertStatement, sqlConnection);

            cmd.Parameters.AddWithValue("@ListName", entry.ListName);
            cmd.Parameters.AddWithValue("@Name", entry.Name);
            cmd.Parameters.AddWithValue("@SetAmount", entry.SetAmount);
            cmd.Parameters.AddWithValue("@AmountGiven", entry.AmountGiven);
            cmd.Parameters.AddWithValue("@Change", entry.Change);

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            UpdateTotals(entry.ListName);
        }

        public List<AmbagEntry> GetAllEntries()
        {
            string selectStatement = "SELECT * FROM Ambagan_Entries";
            SqlCommand cmd = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            var entries = new List<AmbagEntry>();

            while (reader.Read())
            {
                AmbagEntry entry = new AmbagEntry
                {
                    ListName = reader["ListName"].ToString(),
                    Name = reader["Name"].ToString(),
                    SetAmount = Convert.ToDouble(reader["SetAmount"]),
                    AmountGiven = Convert.ToDouble(reader["AmountGiven"]),
                    Change = Convert.ToDouble(reader["Change"])
                };

                entries.Add(entry);
            }

            sqlConnection.Close();
            return entries;
        }

        public bool RemoveEntry(string listName, string name)
        {
            string deleteStatement = "DELETE FROM Ambagan_Entries WHERE ListName = @ListName AND Name = @Name";
            SqlCommand cmd = new SqlCommand(deleteStatement, sqlConnection);
            cmd.Parameters.AddWithValue("@ListName", listName);
            cmd.Parameters.AddWithValue("@Name", name);

            sqlConnection.Open();
            int affectedRows = cmd.ExecuteNonQuery();
            sqlConnection.Close();

            if (affectedRows > 0)
            {
                UpdateTotals(listName);
                return true;
            }

            return false;
        }

        public bool RemoveList(string listName)
        {
            string deleteStatement = "DELETE FROM Ambagan_Entries WHERE ListName = @ListName";
            SqlCommand cmd = new SqlCommand(deleteStatement, sqlConnection);
            cmd.Parameters.AddWithValue("@ListName", listName);

            sqlConnection.Open();
            int affectedRows = cmd.ExecuteNonQuery();
            sqlConnection.Close();

            if (affectedRows > 0)
            {
                DeleteTotals(listName);
                return true;
            }

            return false;
        }

        public ListTotals GetTotals(string listName)
        {
            string selectStatement = @"SELECT 
                                           ISNULL(SUM(SetAmount), 0) AS TotalSet,
                                           ISNULL(SUM(AmountGiven), 0) AS TotalGiven,
                                           ISNULL(SUM(Change), 0) AS TotalChange
                                       FROM Ambagan_Entries
                                       WHERE ListName = @ListName";
            SqlCommand cmd = new SqlCommand(selectStatement, sqlConnection);
            cmd.Parameters.AddWithValue("@ListName", listName);

            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            ListTotals totals = new ListTotals();

            if (reader.Read())
            {
                totals.TotalSet = Convert.ToDouble(reader["TotalSet"]);
                totals.TotalGiven = Convert.ToDouble(reader["TotalGiven"]);
                totals.TotalChange = Convert.ToDouble(reader["TotalChange"]);
            }

            sqlConnection.Close();
            return totals;
        }

        public void UpdateTotals(string listName)
        {
            ListTotals totals = GetTotals(listName);

            string updateStatement = @"
                IF EXISTS (SELECT 1 FROM Ambagan_Totals WHERE ListName = @ListName)
                    UPDATE Ambagan_Totals
                    SET TotalSet = @TotalSet, TotalGiven = @TotalGiven, TotalChange = @TotalChange
                    WHERE ListName = @ListName
                ELSE
                    INSERT INTO Ambagan_Totals (ListName, TotalSet, TotalGiven, TotalChange)
                    VALUES (@ListName, @TotalSet, @TotalGiven, @TotalChange)";

            SqlCommand cmd = new SqlCommand(updateStatement, sqlConnection);
            cmd.Parameters.AddWithValue("@ListName", listName);
            cmd.Parameters.AddWithValue("@TotalSet", totals.TotalSet);
            cmd.Parameters.AddWithValue("@TotalGiven", totals.TotalGiven);
            cmd.Parameters.AddWithValue("@TotalChange", totals.TotalChange);

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void DeleteTotals(string listName)
        {
            string deleteStatement = "DELETE FROM Ambagan_Totals WHERE ListName = @ListName";
            SqlCommand cmd = new SqlCommand(deleteStatement, sqlConnection);
            cmd.Parameters.AddWithValue("@ListName", listName);

            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
