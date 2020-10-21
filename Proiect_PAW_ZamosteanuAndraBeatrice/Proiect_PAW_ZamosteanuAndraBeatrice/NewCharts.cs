using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect_PAW_ZamosteanuAndraBeatrice
{
    public partial class NewCharts : UserControl
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andra.zamosteanu\source\repos\Proiect_PAW_ZamosteanuAndraBeatrice\Proiect_PAW_ZamosteanuAndraBeatrice\Database1.mdf;Integrated Security=True;";

        private List<Cont> conturi = new List<Cont>();

        public NewChartValues[] data { get; set; }
        public NewCharts()
        {
            InitializeComponent();
            const string stringSql = "SELECT * FROM Conturi";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var command = new SqlCommand(stringSql, connection);

                using (SqlDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        int id = (int)sqlReader["Id"];
                        long iban = (long)sqlReader["Iban"];
                        string detinator = (string)sqlReader["Detinator"];
                        string moneda = (string)sqlReader["Moneda"];
                        DateTime data = DateTime.Parse((string)sqlReader["DataDeschiderii"]);
                        double suma = (double)sqlReader["Suma"];
                        Boolean deschis = (Boolean)sqlReader["Deschis"];


                        Cont cont = new Cont(id, iban, detinator, moneda, data, suma, deschis);

                        conturi.Add(cont);
                    }
                }
                connection.Close();
            }
            ResizeRedraw = true;
            foreach(Cont cont in conturi)
            {
                new NewChartValues(cont.Detinator, cont.Suma);
                data = new NewChartValues[] { new NewChartValues(cont.Detinator.ToString(), cont.Suma) };
            }

  
        }
        private void NewChartControl_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void NewChart_Paint(object sender, PaintEventArgs e)
        {

            Graphics graphics = e.Graphics;
            Rectangle clipRectangle = e.ClipRectangle;

            var barWidth = Convert.ToSingle(clipRectangle.Width * 0.9);
            var maxBarHeight = clipRectangle.Height / data.Length; 
            var scalingFactor = maxBarHeight / data.Max(x => x.Value);

            Brush greenBrush = new SolidBrush(Color.ForestGreen);

            for (int i = 0; i < data.Length; i++)
            {
                var barHeight = data[i].Value * scalingFactor;

                graphics.FillRectangle(
                    greenBrush,
                    i * barWidth,
                    (float)(clipRectangle.Height - barHeight),
                    (float)(0.8 * barWidth),
                    (float)barHeight);
            }
        }
    }

}
    