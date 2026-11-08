using System;
using System.Collections.Generic;
using System.Text;

namespace generic_collection.Classes
{
    public class Restaurant
    {
        // List<MenuItem> skapar en lista med maträtter
        // MenuItem betyder att listan bara kan innehålla maträtter
        // Vi använder List eftersom vi vill kunna lägga till flera rätter
        private List<MenuItem> menu = new List<MenuItem>();

        // Queue<Order> skapar en kö för våra beställningar
        // Order betyder att kön bara innehåller beställningar
        // Queue använder FIFO (First In, First Out)
        // Det betyder att första beställningen in hanteras först
        private Queue<Order> orderQueue = new Queue<Order>();


        // Lägger till en ny maträtt i menyn
        public void AddtoMenu(MenuItem menuItem)
        {
            // Add lägger till maträtten i vår List
            menu.Add(menuItem);

            Console.WriteLine("Tillagd i menyn: " + menuItem);
        }


        // Skriver ut alla maträtter i menyn
        public void ShowMenu()
        {
            Console.WriteLine("\n--- MENY ---");

            // foreach går igenom listan, en maträtt i taget
            // item är den maträtt vi är på just nu
            foreach (MenuItem item in menu)
            {
                Console.WriteLine(item);
            }
        }


        // Lägger till en ny beställning i kön
        public void CreateOrder(Order order)
        {
            // Enqueue lägger beställningen SIST i vår Queue
            // På så sätt hanteras äldre beställningar före nya
            orderQueue.Enqueue(order);

            Console.WriteLine("\nNy beställning tillagd:");
            order.ShowOrder();
        }


        // Hanterar den första beställningen i kön
        public void HandleOrder()
        {
            // Count visar hur många beställningar som finns
            // Vi kontrollerar att kön inte är tom innan vi tar bort något
            if (orderQueue.Count > 0)
            {
                // Dequeue tar ut och tar bort FÖRSTA beställningen
                // Vi sparar den i order för att kunna visa den
                Order order = orderQueue.Dequeue();

                Console.WriteLine("\nHanterar beställning:");
                order.ShowOrder();
            }
            else
            {
                // Om kön är tom finns inget att hantera
                Console.WriteLine("Det finns inga beställningar.");
            }
        }


        // Visar alla beställningar som finns kvar i kön
        public void ShowOrders()
        {
            Console.WriteLine("\n--- AKTUELLA BESTÄLLNINGAR ---");

            // foreach går igenom varje order i vår Queue
            // Den visar beställningarna utan att ta bort dem
            foreach (Order order in orderQueue)
            {
                order.ShowOrder();
                Console.WriteLine();
            }
        }


        // Visar beställningen som står först i kön
        public void ShowNextOrder()
        {
            // Kontrollerar att det finns minst en beställning
            if (orderQueue.Count > 0)
            {
                // Peek hämtar första beställningen UTAN att ta bort den
                // Till skillnad från Dequeue finns ordern kvar i kön
                Order order = orderQueue.Peek();

                Console.WriteLine("\nNästa beställning:");
                order.ShowOrder();
            }
            else
            {
                Console.WriteLine("Det finns inga beställningar.");
            }
        }


        // Visar antalet beställningar i kön
        public void ShowOrderCount()
        {
            // Count räknar hur många beställningar som finns just nu
            // Antalet ändras när vi använder Enqueue eller Dequeue
            Console.WriteLine("\nAntal beställningar i kön: " + orderQueue.Count);
        }
    }
}
