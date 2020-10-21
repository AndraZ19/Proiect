using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect_PAW_ZamosteanuAndraBeatrice;

namespace Proiect_PAW_ZamosteanuAndraBeatrice
{
    [Serializable]

    public abstract class OperatiiContabile
    {
        public int Id { get; set; }
        public string nume { get; set; }

        public abstract void EfOperatie(string Nume, Cont cont, long suma);


    }

    [Serializable]
    public class InchidereCont : OperatiiContabile

    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andra.zamosteanu\source\repos\Proiect_PAW_ZamosteanuAndraBeatrice\Proiect_PAW_ZamosteanuAndraBeatrice\Database1.mdf;Integrated Security=True;";

        public InchidereCont()
        {
        }

        public InchidereCont(int id, string num)
        {
            Id = id;
            nume = num;
        }

        public override void EfOperatie(string Nume, Cont cont,long suma)
        {
            const string stringSql = " UPDATE Conturi SET Deschis = @deschis " +
                           "WHERE Id = @Id";
            cont.Deschis = false;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(stringSql, connection);
                command.Parameters.AddWithValue("@Id", cont.Id);
                command.Parameters.AddWithValue("@deschis", cont.Deschis);
                command.ExecuteNonQuery();
                connection.Close();
                
            }

        }
    }
    [Serializable]
    public class ModificaSuma : OperatiiContabile
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andra.zamosteanu\source\repos\Proiect_PAW_ZamosteanuAndraBeatrice\Proiect_PAW_ZamosteanuAndraBeatrice\Database1.mdf;Integrated Security=True;";

        public ModificaSuma()
        {
        }

        public ModificaSuma(int id, string num)
        {
            Id = id;
            nume = num;
        }

        public override void EfOperatie( string Nume, Cont cont, long suma)
        {

            const string stringSql = " UPDATE Conturi SET Suma = @suma " +
                           "WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(stringSql, connection);
                command.Parameters.AddWithValue("@Id", cont.Id);
                command.Parameters.AddWithValue("@suma", (cont.Suma +suma));
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        }

    }

