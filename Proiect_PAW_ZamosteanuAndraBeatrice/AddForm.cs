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
    public partial class AddForm : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andra.zamosteanu\source\repos\Proiect_PAW_ZamosteanuAndraBeatrice\Proiect_PAW_ZamosteanuAndraBeatrice\Database1.mdf;Integrated Security=True;";

        public AddForm()
        {
            InitializeComponent();
        }
        private void AddCont()
        {

            long Iban = Convert.ToInt64(tbIban.Text);
            string Detinator = tbDetinator.Text;
            string Moneda = tbMoneda.Text;
            double Suma = Convert.ToDouble(tbSuma.Text);
            DateTime Date = System.DateTime.Now;
            Boolean Deschis = true;
            var cont = new Cont(Iban, Detinator, Moneda, Date, Suma, Deschis);
            var queryString = "insert into Conturi(Iban, Detinator, Moneda, DataDeschiderii, Suma, Deschis)" +
                              " values(@iban,@detinator,@moneda,@datadeschiderii,@suma,@deschis);  ";
                              

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@iban", Iban);
                command.Parameters.AddWithValue("@detinator", Detinator);
                command.Parameters.AddWithValue("@moneda", Moneda);
                command.Parameters.AddWithValue("@datadeschiderii", System.DateTime.Now.ToShortDateString());
                command.Parameters.AddWithValue("@suma", Suma);
                command.Parameters.AddWithValue("@deschis", Deschis);

                command.ExecuteNonQuery();


            }
        }

        private void TbIban_Validating(object sender, CancelEventArgs e)
        {
            if (!IsIbanValid())
            {
                e.Cancel = true; 
                epIban.SetError((Control)sender, "Va rugam completati IBAN-ul (format numeric)!");
            }
        }
        private void TbIban_Validated(object sender, EventArgs e)
        {
            epIban.SetError((Control)sender, string.Empty);
        }
        private void TbDetinator_Validating(object sender, CancelEventArgs e)
        {
            if (!IsNameValid())
            {
                e.Cancel = true;
                epDetinator.SetError((Control)sender, "Va rugam completati numele detinatorului!");
            }
        }
        private void TbDetinator_Validated(object sender, EventArgs e)
        {


                epDetinator.SetError((Control)sender, string.Empty);
    
        }

        private void TbMoneda_Validating(object sender, CancelEventArgs e)
        {
            if (!IsMonedaValid())
            {
                e.Cancel = true;
                epMoneda.SetError((Control)sender, "Va rugam completati moneda!");
            }
        }
        private void TbMoneda_Validated(object sender, EventArgs e)
        {
          
                epMoneda.SetError((Control)sender, string.Empty);

        }

        private void TbSuma_Validating(object sender, CancelEventArgs e)
        {
            if (!IsSumaValid())
            {
                e.Cancel = true;
                epSuma.SetError((Control)sender, "Va rugam completati suma!");
            }
        }
        private void TbSuma_Validated(object sender, EventArgs e)
        {
            epSuma.SetError((Control)sender, string.Empty);
        }
        private bool IsIbanValid()
        {
            return (!string.IsNullOrWhiteSpace(tbIban.Text.Trim()) && (long.TryParse(tbIban.Text, out long result)));

        }
        private bool IsNameValid()
        {
            return (!string.IsNullOrWhiteSpace(tbDetinator.Text.Trim()));
        }
        private bool IsMonedaValid()
        {
            return (!string.IsNullOrWhiteSpace(tbMoneda.Text.Trim()));
        }
        private bool IsSumaValid()
        {
            return (!string.IsNullOrWhiteSpace(tbSuma.Text.Trim()) && (double.TryParse(tbSuma.Text, out double result)));
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Va rugam corectati campurile completate gresit!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            try
            {
                AddCont();
            }
            
            catch (Exception)
            {

                MessageBox.Show("Eroare interna!");

            }
        }
    }
}
