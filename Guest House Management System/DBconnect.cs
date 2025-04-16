using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

internal class DBconnect
{
    private readonly string connectionString = "Server=localhost;Uid=root;Pwd=#Dila@200205;Database=thambapanniyadb;";

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    public DataTable GetData(string query, params MySqlParameter[] parameters)
    {
        using (MySqlConnection connection = GetConnection())
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddRange(parameters);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                }
                catch (MySqlException ex)
                {
                    LogError(ex);
                    MessageBox.Show("An error occurred while retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw; // Rethrow the exception for further handling
                }
                catch (Exception ex)
                {
                    LogError(ex);
                    MessageBox.Show("An unexpected error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw; // Rethrow the exception for further handling
                }

                return dataTable;
            }
        }
    }

    public int ExecuteQuery(string query, params MySqlParameter[] parameters)
    {
        using (MySqlConnection connection = GetConnection())
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddRange(parameters);
                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery(); // Return the number of affected rows
                }
                catch (MySqlException ex)
                {
                    LogError(ex);
                    MessageBox.Show("An error occurred while executing the query: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1; // Indicate an error occurred
                }
                catch (Exception ex)
                {
                    LogError(ex);
                    MessageBox.Show("An unexpected error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1; // Indicate an error occurred
                }
            }
        }
    }

    public int GetLastInsertedId()
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }

    public bool TestConnection()
    {
        using (MySqlConnection connection = GetConnection())
        {
            try
            {
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    private void LogError(Exception ex)
    {
        string logPath = "error_log.txt";
        string errorMessage = $"{DateTime.Now}: {ex.Message}\n{ex.StackTrace}\n\n";
        File.AppendAllText(logPath, errorMessage);
    }
}