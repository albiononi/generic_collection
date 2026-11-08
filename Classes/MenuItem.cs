using System;
using System.Collections.Generic;
using System.Text;

namespace generic_collection.Classes
{
    public class MenuItem
    {
        // Egenskaper som varje maträtt har
        // get hämtar värdet och set ändrar det
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Konstruktorn tar emot och sparar maträttens information
        public MenuItem(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        // Bestämmer hur maträtten ska visas som text
        // :C gör att priset visas som valuta
        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }
    }
}
