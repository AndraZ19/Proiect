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
    internal partial class Main : Form
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andra.zamosteanu\source\repos\Proiect_PAW_ZamosteanuAndraBeatrice\Proiect_PAW_ZamosteanuAndraBeatrice\Database1.mdf;Integrated Security=True;";
        private readonly List<Cont> _conturi;
        private int _currentContIndex;


        public Main()
        {
            InitializeComponent();
            _conturi = new List<Cont>();
        }

        
        public void ShowConturi()
        {
            lvAcc.Items.Clear();

            foreach (Cont cont in _conturi)
            {
                var listViewItem = new ListViewItem(cont.Id.ToString());
                listViewItem.SubItems.Add(cont.Iban.ToString());
                listViewItem.SubItems.Add(cont.Detinator);
                listViewItem.SubItems.Add(cont.Moneda);
                listViewItem.SubItems.Add(cont.DataDeschiderii.ToShortDateString());
                listViewItem.SubItems.Add(cont.Suma.ToString());
                listViewItem.SubItems.Add(cont.Deschis.ToString());
                listViewItem.Tag = cont;

                lvAcc.Items.Add(listViewItem);
            }
        }
        public void LoadConturi()
        {
            _conturi.Clear();
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
                        string moneda= (string)sqlReader["Moneda"];
                        DateTime data = DateTime.Parse((string)sqlReader["DataDeschiderii"]);
                        double suma = (double)sqlReader["Suma"];
                        Boolean deschis = (Boolean)sqlReader["Deschis"];


                        Cont cont = new Cont(id, iban, detinator, moneda, data, suma, deschis);

                        _conturi.Add(cont);
                    }
                }
                connection.Close();
            }
        }
        public void DeleteCont(Cont cont)
        {
            const string stringSql = "DELETE FROM Conturi WHERE Id=@id";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(stringSql, connection);
                command.Parameters.AddWithValue("@Id", cont.Id);

                command.ExecuteNonQuery();

                _conturi.Remove(cont);
            }
        }
       
      

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

            try
            {
                LoadConturi();
                ShowConturi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            if (lvAcc.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alegeti un cont.");
                return;
            }

            if (MessageBox.Show("Sunteti sigur?", "Sterge cont", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ListViewItem selectedItem = lvAcc.SelectedItems[0];
                    Cont cont = (Cont)selectedItem.Tag;

                    DeleteCont(cont);

                    ShowConturi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void BtOperation_Click(object sender, EventArgs e)
        {
            if (lvAcc.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alegeti un cont.");
                return;
            }
            try
            {
                ListViewItem selectedItem = lvAcc.SelectedItems[0];
                Cont cont = (Cont)selectedItem.Tag;
                OpForm op = new OpForm(cont);
                if (op.ShowDialog() == DialogResult.OK)
                {
                    LoadConturi();
                    ShowConturi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }


        

        private void AddAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            AddForm addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadConturi();
                ShowConturi();
            }
        }

      private void BtEdit_Click(object sender, EventArgs e)
        {
            if (lvAcc.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alegeti un cont.");
                return;
            }
            try
            {
                ListViewItem selectedItem = lvAcc.SelectedItems[0];
                Cont cont = (Cont)selectedItem.Tag;
                EditForm ed = new EditForm(cont);
                if (ed.ShowDialog() == DialogResult.OK)
                {
                    LoadConturi();
                    ShowConturi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       
        private void PrintToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _currentContIndex = 0;
        }
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Initialize the font to be used for printing.
            Font font = new Font("Microsoft Calibri", 24);

            var pageSettings = printDocument1.DefaultPageSettings;

            var intPrintAreaHeight = pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom;
            var intPrintAreaWidth = pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right;

            var marginLeft = pageSettings.Margins.Left;

            var marginTop = pageSettings.Margins.Top;

            if (printDocument1.DefaultPageSettings.Landscape)
            {
                var intTemp = intPrintAreaHeight;
                intPrintAreaHeight = intPrintAreaWidth;
                intPrintAreaWidth = intTemp;
            }

            const int rowHeight = 40;
            var columnWidth = intPrintAreaWidth / 3;


            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;
            while (_currentContIndex < _conturi.Count)
            {

                var currentX = marginLeft;


                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
               
                e.Graphics.DrawString(
                    _conturi[_currentContIndex].Id.ToString(),
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    fmt);

                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    _conturi[_currentContIndex].Iban.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    _conturi[_currentContIndex].Detinator,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    _conturi[_currentContIndex].Moneda,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt); currentX += columnWidth;
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    _conturi[_currentContIndex].Suma.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt); currentX += columnWidth;
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    _conturi[_currentContIndex].DataDeschiderii.ToShortDateString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    _conturi[_currentContIndex].Deschis.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);

                _currentContIndex++;

                currentY += rowHeight;

                if (currentY + rowHeight > intPrintAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        
    }

       

        private void WhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvAcc.BackColor = Color.White;
        }

        private void BlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvAcc.BackColor = Color.Lavender;

        }

        private void SeeOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatiiShow opShow = new OperatiiShow();
            if (opShow.ShowDialog() == DialogResult.OK)
            {
                LoadConturi();
                ShowConturi();
            }
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }
    }
}
