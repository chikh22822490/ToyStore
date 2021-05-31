using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ToyStore.Classes
{
    class Toy
    {
        public enum types
        {
            Reflex,
            Strategy,
            Society,
            Cards,
            Maths,
            puzzle,
            Education,
            Construction,
            Cars,
            Creativity,
            Dolls,
            Scientific,
            Wooden,
            Acoustic,
            Kitchen
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public double Price { get; set; }
        public int IdProvider { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
    }
}
