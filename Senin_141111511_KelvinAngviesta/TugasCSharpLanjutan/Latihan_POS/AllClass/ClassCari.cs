using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using Latihan_POS.AllClass;
using Latihan_POS.Properties;
using Latihan_POS.FormEdit;


namespace Latihan_POS.AllClass
{
    class ClassCari 
    {
        static MySqlConnection Connection = new MySqlConnection("Server=localhost;Database=database_latihan_pos;Uid=root;password=;");
        private void OpenConnection()
        {
            if (Connection.State != ConnectionState.Open)
                Connection.Open();
        }

        private void ConnectionClose()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();
        }
        public void Cari(string cari,string KodeEditCust,string NamaEditCust , string AlamatEditCust,string HpCust,string EmailCust)
        {
            if (cari.Trim() != "")
            {
                try
                {
                    MySqlCommand cmd = Connection.CreateCommand();
                    string query = "SELECT * from customer WHERE ID=" + cari;
                    cmd.CommandText = query;
                    OpenConnection();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    bool ketemu = false;
                    KodeEditCust = NamaEditCust = AlamatEditCust = HpCust=EmailCust="";
                    while (reader.Read())
                    {
                        ketemu = true;
                        KodeEditCust = reader.GetString("KodeCust");
                        NamaEditCust = reader.GetString("NamaCust");
                        AlamatEditCust = reader.GetString("AlamatCust");
                        HpCust =reader.GetString("HpCust");
                        EmailCust = reader.GetString("EmailCust");
                    }
                    ConnectionClose();
                     if (ketemu)
                    {

                        
                    }
                    else
                    {
                        MessageBox.Show("ID tidak ditemukan");
                    }
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
        }
    }
}
