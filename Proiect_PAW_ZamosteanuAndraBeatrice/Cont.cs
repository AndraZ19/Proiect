using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_ZamosteanuAndraBeatrice
{
    public class Cont
    {
        public Cont()
        {
        }

        public Cont(long iban, string detinator, string moneda, DateTime dataDeschiderii, double suma, Boolean deschis)
        {
            Iban = iban;
            Detinator = detinator;
            Moneda = moneda;
            DataDeschiderii = dataDeschiderii;
            Suma = suma;
            Deschis = true;
        }
        public Cont(int id,long iban, string detinator, string moneda, DateTime dataDeschiderii, double suma, Boolean deschis)
        {
            Id = id;
            Iban = iban;
            Detinator = detinator;
            Moneda = moneda;
            DataDeschiderii = dataDeschiderii;
            Suma = suma;
            Deschis = true;
        }
        public int Id { get; set; }
        public long Iban {  get; set; }
        public string Detinator { get; set; }
        public string Moneda { get; set; }
        public double Suma { get; set; }

        public Boolean Deschis { get; set; }
        public DateTime DataDeschiderii { get; set; }


    }
}
