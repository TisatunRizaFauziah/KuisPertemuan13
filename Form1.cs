using KuisPertemuan13.Controller;
using KuisPertemuan13.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan13
{
    public partial class Form1 : Form
    {
        Profil pro;
        Connection connec = new Connection();
        public Form1()
        {
            pro = new Profil();
            InitializeComponent();
            tampil();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void tampil()
        {

            dataGridViewTampil.DataSource = pro.tampil();
            dataGridViewTampil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool verify()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {

                    pro.hapus(txtID.Text);
                    tampil();
                    btnClear.PerformClick();

                    MessageBox.Show("Delete Berhasil", "Delete pegawai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-pegawai tidak terhapus", "Delete pegawai",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewTampil.DataSource=pro.Search(txtSearch.Text);
            dataGridViewTampil.RowTemplate.Height = 80;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (radioislam.Checked)
            {
                dataGridViewTampil.DataSource = pro.Search(radioislam.Text);
            }
            else if (radiokristen.Checked)
            {
                dataGridViewTampil.DataSource = pro.Search(radiokristen.Text);
            }
            else if (RadioAll.Checked)
            {
                dataGridViewTampil.DataSource = pro.Search(RadioAll.Text);
                tampil();
            }


        }
    }
}