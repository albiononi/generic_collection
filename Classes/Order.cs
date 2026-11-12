using System;
using System.Collections.Generic;
using System.Text;

namespace generic_collection.Classes
{
    public class Order
    {
        // Här börjar räknaren på 1. static gör att alla ordrar
        // delar samma räknare och får olika ID.
        static int orderIdCounter = 1;

        // Sparar ID-numret för just den här beställningen.
        private int _orderId;

        // Här sparas maträtterna som hör till ordern.
        // Jag använder List<MenuItem> eftersom en order kan ha flera rätter.
        private List<MenuItem> _orderItems;

        // Sparar vilket bord som gjort beställningen.
        private int _tableNumber;

        // Här tar jag emot listan med maträtter och bordsnumret
        // när en ny beställning skapas i Program.cs.
        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Ger ordern ett ID från räknaren.
            _orderId = orderIdCounter;
            // Ökar räknaren så nästa order får ett nytt ID.
            orderIdCounter++;

            // Här sparar jag maträtterna och bordet i ordern
            // så vi kan visa informationen senare.
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        // Den här metoden visar vilken order det är, bordet
        // och maträtterna som kunden har beställt.
        public void ShowOrder()
        {
            Console.WriteLine("Order ID: " + _orderId);
            Console.WriteLine("Bord: " + _tableNumber);

            // Här går foreach igenom maträtterna en i taget
            // så att alla rätter i beställningen skrivs ut.
            foreach (MenuItem item in _orderItems)
            {
                // Här används MenuItems ToString för att visa namn och pris.
                Console.WriteLine(item);
            }
        }
    }
}
