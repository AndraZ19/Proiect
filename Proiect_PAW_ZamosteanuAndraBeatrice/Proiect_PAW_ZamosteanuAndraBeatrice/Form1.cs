using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect_PAW_ZamosteanuAndraBeatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//Connection String
        string cString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andra.zamosteanu\source\repos\Proiect_PAW_ZamosteanuAndraBeatrice\Proiect_PAW_ZamosteanuAndraBeatrice\Database1.mdf;Integrated Security=True;";
        //btn_Submit Click event
        private void BLogin_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "" || tbPass.Text == "")
            {
                MessageBox.Show("Va rugam introduceti un username si parola.");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection connect = new SqlConnection(cString);
                SqlCommand cmd = new SqlCommand("select username,password from Login where username='" + tbUser.Text + "'and password='" + tbPass.Text + "'", connect);
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataT = new DataTable();
                adapter.Fill(dataT);
                connect.Close();
                int count = dataT.Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Sunteti logat.");
                    this.Hide();
                    Main mainForm = new Main();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Verificati credentialele!");
                }
                adapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
