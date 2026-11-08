using System;
using System.Collections.Generic;
using System.Text;

namespace generic_collection.Classes
{
    public class Order
    {
        // Räknar upp ID för varje ny beställning
        // static gör att alla beställningar delar samma räknare
        static int orderIdCounter = 1;

        // Sparar beställningens ID
        private int _orderId;

        // List<MenuItem> är en lista som bara innehåller MenuItem-objekt
        // Vi använder den eftersom en order kan ha flera maträtter
        private List<MenuItem> _orderItems;

        // Sparar vilket bord som gjorde beställningen
        private int _tableNumber;

        // Konstruktorn skapar en beställning
        // Den tar emot en lista med maträtter och ett bordsnummer
        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Ger beställningen ett ID och ökar räknaren
            _orderId = orderIdCounter;
            orderIdCounter++;

            // Sparar listan med maträtter och bordsnumret
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        // Visar information om en beställning
        public void ShowOrder()
        {
            Console.WriteLine("Order ID: " + _orderId);
            Console.WriteLine("Bord: " + _tableNumber);

            // foreach går igenom alla maträtter i vår List
            // item är en maträtt i taget från listan
            foreach (MenuItem item in _orderItems)
            {
                // Skriver ut maträtten med hjälp av ToString
                Console.WriteLine(item);
            }
        }
    }
}
