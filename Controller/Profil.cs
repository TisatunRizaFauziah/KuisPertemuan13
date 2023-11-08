using KuisPertemuan13.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan13.Controller
{
    internal class Profil : Model.Connection
    {
        Connection connec = new Connection();
        public DataTable tampil()
        {
            DataTable data = new DataTable();

            try
            {
                string tampil = "select * from pegawai";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public void hapus(string id)
        {
            string delete = "delete from pegawai where id=" + id;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal delete" + ex.Message);
            }

        }

        public DataTable Search(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlConnection connection = connec.GetConn(); // Pastikan Anda memiliki objek koneksi yang benar
                string query = "SELECT * FROM pegawai WHERE CONCAT(Id, Nama, Alamat, Agama, Umur) LIKE @search";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@search", "%" + search + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal search: " + ex.Message);
            }
            return table;
        }


    }


}

      