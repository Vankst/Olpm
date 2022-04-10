using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using OpenXmlPowerTools;

namespace Olmp.Forms
{
    class DB
    {
        public string connectionString = "Host=localhost;Username=postgres;Password=' ';Database=DB";
        public void SigUp(string email, string password)
        {
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"INSERT INTO users(email, password) VALUES ('{email}', '{password}')", npgSqlConnection);
            npgSqlCommand.ExecuteNonQuery();
            npgSqlConnection.Close();

        }

        public void CheckEmail(string email, out bool checkEmail) {
            checkEmail = false;
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT email FROM users WHERE email = '{email}';", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (!npgSqlDataReader.HasRows)
                checkEmail = true;

        }


        public void SignIn(string email, out string password)
        {
            password = "";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"SELECT password FROM users WHERE email = '{email}';", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
            {
                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                    password = dbDataRecord["password"].ToString();
            }
        }
    }
}
