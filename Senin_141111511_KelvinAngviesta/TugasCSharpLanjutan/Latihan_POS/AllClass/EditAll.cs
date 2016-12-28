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
    class EditAll 
    {
        
        MySqlConnection conn;
        String connString = "Server=Localhost; Database=database_latihan_pos; Uid=root; pwd=''";
        MySqlCommand cmd;

        public int isNumber(String number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if ((int)number[i] < (int)'0' || (int)number[i] > (int)'9')
                {
                    return -1;
                }
            }
            return 0;
        }
        public void editCariBrg(string IdBarang,string KodeBrg,string NamaBrg,string JlhBrg,string HargaHpp,string HargaJual)
        {
            conn = new MySqlConnection(connString);
             if(IdBarang == "Barang")
             {
                 try
                 {

                     conn.Open();
                     DateTime now = DateTime.Now;
                     String DateBrgNow = now.ToString("yyyy/MM/dd HH:mm:ss");
                     String sql = "UPDATE tblbarang SET id='" + IdBarang + "'" + "," + "kode='" + KodeBrg+ "'" + "," + "nama='" + NamaBrg+ "'" + "," + "jumlahAwal='" + JlhBrg + "'" + "," + "hargaHpp= '" + Convert.ToDecimal(HargaHpp) + "'" + "," + "hargajual='" + Convert.ToDecimal(HargaJual) + "'" + "," + "tglupdatebarang='" + DateBrgNow + "'" + "WHERE id='" + IdBarang+ "'";
                     MessageBox.Show(sql);
                     cmd = new MySqlCommand(sql, conn);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Produk barang berhasil diubah", "Edited");    
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
                 finally
                 {
                     conn.Close();
                 }
             }
             else
             {
                 MessageBox.Show("kode tidak ditemukan");
             }       
            }
            public void editCustomer(string IdCust, string NamaCust,string AlamatEditCust,string HpEditCust,string EmailCust)
            {
                conn = new MySqlConnection(connString);
                if(isNumber(HpEditCust)==-1)
                {
                    MessageBox.Show("Digit HP Diisi dengan angka!");
                }
                else if(HpEditCust.Length > 12)
                {
                    MessageBox.Show("Digit Hp Tidak boleh lebih panjang dari 12 digit!");
                }
                else if( HpEditCust.Length < 11)
                {
                    MessageBox.Show("Digit HP Minimal 11 Digit!");
                }
                else
                {
                    try
                    {
                        conn.Open();
                        DateTime now = DateTime.Now;
                        String DateCustNow = now.ToString("yyyy/MM/dd HH:mm:ss");
                        String sql = "UPDATE tblcustomer SET KodeCust='" + IdCust + "'" + "," + "NamaCust='" + NamaCust + "'" + "," + "AlamatCust= '" + AlamatEditCust + "'" + "," + "HpCust='" + HpEditCust + "'" + "," + "EmailCust='" + EmailCust + "'" + "," + "DateUpdate='" + DateCustNow + "'" + "WHERE KodeCust='" + IdCust + "'";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tabel Customer sudah berhasil diubah", "Edited");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            public void editSupplier(string KodeSup, string NamaSup, string AlamatSup,string EmailSup,string HpSup)
            {
                conn = new MySqlConnection(connString);
                if (isNumber(HpSup)==-1)
                {
                    MessageBox.Show("Nomor HP Diisi dengan angka");
                }
                else if (HpSup.Length > 12)
                {
                    MessageBox.Show("Nomor HP Tidak boleh lebih panjang dari 12 digit");
                }
                else if (HpSup.Length < 11)
                {
                    MessageBox.Show("Nomor HP Minimal 11 Digit");
                    
                }
                else
                {
                    try
                    {
                        conn.Open();
                        DateTime now = DateTime.Now;
                        String DateSupNow = now.ToString("yyyy/MM/dd HH:mm:ss");
                        String sql = "UPDATE tblsupplier SET KodeSup='" + KodeSup + "'" + "," + "NamaSup='" + NamaSup + "'" + "," + "AlamatSup= '" +AlamatSup + "'" + "," + "HpSup='" + HpSup + "'" + "," +"EmailSup='" +EmailSup + "'" + "," + "DateUpdate='" + DateSupNow + "'" + "WHERE KodeSup='" + KodeSup + "'";
                        cmd = new MySqlCommand(sql, conn);
                        MessageBox.Show(sql);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tabel Supplier sudah berhasil diubah", "Edited");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
          }
     }
 
