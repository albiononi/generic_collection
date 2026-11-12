using System;
using System.Collections.Generic;
using System.Text;

namespace generic_collection.Classes
{
    public class MenuItem
    {
        // Här sparas maträttens ID, namn och pris.
        // get hämtar värdet och set gör att vi kan ändra det.
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Här tar konstruktorn emot informationen när en maträtt skapas.
        // Värdena sparas så restaurangen kan använda dem i menyn.
        public MenuItem(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        // Här bestämmer jag hur maträtten ska skrivas ut.
        // override ändrar ToString och :C visar priset som valuta.
        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }
    }
}
