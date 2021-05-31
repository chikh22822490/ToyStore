using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore.Classes
{
    class Sale
    {
        public int Id { get; set; }
        public int IdCashier { get; set; }
        public DateTime Date { get; set; }
        public double Somme { get; set; }
        public string Reciept { get; set; }
    }
}
