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
    public partial class EditForm : Form
    {
        private readonly Cont _cont;
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andra.zamosteanu\source\repos\Proiect_PAW_ZamosteanuAndraBeatrice\Proiect_PAW_ZamosteanuAndraBeatrice\Database1.mdf;Integrated Security=True;";
        public EditForm(Cont cont)
        {
            _cont = cont;
            InitializeComponent();

        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            _cont.Iban = Convert.ToInt64( tbIban.Text);
            _cont.Detinator = tbDetinator.Text;
            _cont.Moneda = tbMoneda.Text;
            _cont.Suma= Convert.ToDouble(tbSuma.Text);
            const string stringSql = " UPDATE Conturi SET Iban = @iban, Detinator = @detinator, Moneda = @moneda, Suma = @suma " +
                          "WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(stringSql, connection);
                command.Parameters.AddWithValue("@Id", _cont.Id);
                command.Parameters.AddWithValue("@iban", _cont.Iban);
                command.Parameters.AddWithValue("@detinator", _cont.Detinator);
                command.Parameters.AddWithValue("@moneda", _cont.Moneda);
                command.Parameters.AddWithValue("@suma", _cont.Suma);
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            tbIban.Text = _cont.Iban.ToString();
            tbDetinator.Text = _cont.Detinator;
            tbMoneda.Text = _cont.Moneda;
            tbSuma.Text = _cont.Suma.ToString();
            
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

    }
}
