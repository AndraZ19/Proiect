using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW_ZamosteanuAndraBeatrice
{
    public partial class OpForm : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andra.zamosteanu\source\repos\Proiect_PAW_ZamosteanuAndraBeatrice\Proiect_PAW_ZamosteanuAndraBeatrice\Database1.mdf;Integrated Security=True;";

        private readonly Cont _cont;
        public OpForm(Cont cont)
        {
            _cont = cont;
            InitializeComponent();
        }

        private void InitOperatie(string nume)
        {
            const string stringSql = " Insert into Operatii(Nume) " +
                           " values(@nume); ";


            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(stringSql, connection);
                command.Parameters.AddWithValue("@nume", nume);
                command.ExecuteNonQuery();
                connection.Close();

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string nume = "Modificare " + _cont.Id.ToString() + tbNumeOp.Text;
            long suma = Convert.ToInt64(tbSuma.Text.ToString());
            ModificaSuma modificare = new ModificaSuma();

            InitOperatie(nume);
            modificare.EfOperatie(nume, _cont, suma);
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.SetToolTip(tbSuma, "Completati suma daca doriti modificarea acesteia, apoi apasati butonul Modifica suma.");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

            string nume = "Inchidere " + _cont.Id.ToString()+tbNumeOp.Text;

            long suma = 0;
            InitOperatie(nume);
            InchidereCont inchidere = new InchidereCont();
            const string stringSql = " SELECT Id FROM Operatii WHERE nume = @nume ";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var command = new SqlCommand(stringSql, connection);
                command.Parameters.AddWithValue("@nume", nume);
                using (SqlDataReader sqlReader = command.ExecuteReader())
                {

                    while (sqlReader.Read())
                    {
                        int id = (int)sqlReader["Id"];
                        inchidere.Id = id;
                    }
                }
                connection.Close();
            }
            inchidere.nume = nume;
            inchidere.EfOperatie(nume, _cont, suma);

        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbNumeOp.Text);
        }

        private void BtnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                tbNumeOp.Text = Clipboard.GetText();
            }
            else
            {
                MessageBox.Show("Nu exista niciun text copiat!");
            }

        }

        private void TbSuma_Validated(object sender, EventArgs e)
        {
          
                errorProvider1.SetError((Control)sender, string.Empty);
            
        }

        private void TbSuma_Validating(object sender, CancelEventArgs e)
        {
           
                if (!IsSumaValid())
                {
                    e.Cancel = true;
                    errorProvider1.SetError((Control)sender, "Va rugam completati suma (format numeric)!");
                }
            
           
        }
        private bool IsSumaValid()
        {
            return (!string.IsNullOrWhiteSpace(tbSuma.Text.Trim()) && (double.TryParse(tbSuma.Text, out double result)));
        }
        private bool IsNumeValid()
        {
            return (!string.IsNullOrWhiteSpace(tbNumeOp.Text.Trim()));
        }
        private void TbNumeOp_Validating(object sender, CancelEventArgs e)
        {
            if (!IsNumeValid())
            {
                e.Cancel = true;
                errorProvider2.SetError((Control)sender, "Va rugam completati numele!");
            }
        }

        private void TbNumeOp_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError((Control)sender, string.Empty);
        }
    }
}
