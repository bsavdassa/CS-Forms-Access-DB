using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter adp;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Database1.accdb");
            con.Open();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            Refresh("Ders");
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            Refresh("Ogrenci");
        }

        private void Refresh(string table)
        {
            if (con == null) return;
            adp = new OleDbDataAdapter("SELECT * FROM " + table , con);
            dt = new DataTable();
            try{adp.Fill(dt);dataGridView1.DataSource = dt;}
            catch (OleDbException err) { MessageBox.Show(err.Message); }
        }
        private void Refresh(params string[] tables)
        {
            if (con == null) return;
            adp = new OleDbDataAdapter("SELECT * FROM " + tables[0], con);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh(txtTablo.Text);
        }

    }
}
