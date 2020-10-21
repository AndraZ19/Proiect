using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Proiect_PAW_ZamosteanuAndraBeatrice
{
    public partial class OperatiiShow : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andra.zamosteanu\source\repos\Proiect_PAW_ZamosteanuAndraBeatrice\Proiect_PAW_ZamosteanuAndraBeatrice\Database1.mdf;Integrated Security=True;";

        private readonly List<OperatiiContabile> _operatii; 
        public OperatiiShow()
        {


            InitializeComponent();
          _operatii =  new List<OperatiiContabile>();

        }
        public void LoadOperatii()
        {
           if(_operatii != null)
                _operatii.Clear();
            const string stringSql = "SELECT * FROM Operatii";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var command = new SqlCommand(stringSql, connection);

                using (SqlDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        int id = (int)sqlReader["Id"];
                        string nume = (string)sqlReader["Nume"];
                        if (nume.Contains("Inchidere"))
                        {
                            InchidereCont inchidere = new InchidereCont(id, nume);

                            _operatii.Add(inchidere);
                        }
                        else
                        {
                            ModificaSuma modifica = new ModificaSuma(id, nume);
                            _operatii.Add(modifica);
                        }


                    }
                }
            }
        }
        public void DisplayOperatii()
        {
            lvOP.Items.Clear();
            foreach (OperatiiContabile op in _operatii)
            {
                var listViewItem = new ListViewItem(op.Id.ToString());
                listViewItem.SubItems.Add(op.nume);
                listViewItem.Tag = op;

                lvOP.Items.Add(listViewItem);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void LvOP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OperatiiShow_Load(object sender, EventArgs e)
        {
        }

        private void BtnSerialize_Click(object sender, EventArgs e)
        {
            LoadOperatii();
            XmlSerializer serializer = new XmlSerializer(typeof(List<OperatiiContabile>), new Type[] { typeof(ModificaSuma), typeof(InchidereCont) });

            using (FileStream s = File.Create("SerializedXML.xml"))
                serializer.Serialize(s, _operatii);
        }

        private void BtnDeserialize_Click(object sender, EventArgs e)
        {

            FileStream s = File.OpenRead("SerializedXML.xml");
            LoadOperatii();
            DisplayOperatii();

        }

        private void LvOP_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                      contextMenuStrip1.Show(this, new Point(e.X, e.Y));
                    }
                    break;
            }
        }

        private void ShowDetilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(OperatiiContabile  op in _operatii)
            {
                this.chart1.Series["Operatii"].Points.AddXY(op.nume, _operatii.FindAll(x => x.nume == op.nume).Count());

            }


        }
    }
}
