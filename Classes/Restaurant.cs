using System;
using System.Collections.Generic;
using System.Text;

namespace generic_collection.Classes
{
    public class Restaurant
    {
        // Här skapar jag en lista för alla rätter i restaurangens meny.
        // List<MenuItem> gör att listan bara innehåller maträtter.
        private List<MenuItem> menu = new List<MenuItem>();

        // Här skapar jag kön där beställningarna ska vänta.
        // Queue<Order> använder FIFO, alltså första ordern in hanteras först.
        private Queue<Order> orderQueue = new Queue<Order>();


        // Här tar jag emot en maträtt från Program.cs
        // och lägger in den i restaurangens meny.
        public void AddtoMenu(MenuItem menuItem)
        {
            // Add sparar maträtten i listan så vi kan visa den senare.
            menu.Add(menuItem);

            Console.WriteLine("Tillagd i menyn: " + menuItem);
        }


        // Här visar jag alla maträtter som lagts till i menyn.
        public void ShowMenu()
        {
            Console.WriteLine("\n--- MENY ---");

            // foreach går igenom listan och skriver ut en rätt i taget.
            foreach (MenuItem item in menu)
            {
                Console.WriteLine(item);
            }
        }


        // Här tar jag emot en beställning och lägger den i kön.
        public void CreateOrder(Order order)
        {
            // Enqueue lägger ordern sist i kön så att de äldre
            // beställningarna får hanteras före den nya.
            orderQueue.Enqueue(order);

            Console.WriteLine("\nNy beställning tillagd:");
            // Visar information om beställningen vi precis lagt till.
            order.ShowOrder();
        }


        // Här ska jag hantera den order som står först i kön.
        public void HandleOrder()
        {
            // Jag kontrollerar med Count att det finns en order i kön,
            // annars skulle Dequeue ge ett fel om kön är tom.
            if (orderQueue.Count > 0)
            {
                // Dequeue hämtar och tar bort den första ordern.
                // Jag sparar den i order så jag kan visa vad som hanterats.
                Order order = orderQueue.Dequeue();

                Console.WriteLine("\nHanterar beställning:");
                order.ShowOrder();
            }
            else
            {
                Console.WriteLine("Det finns inga beställningar.");
            }
        }


        // Den här metoden visar ordrarna som fortfarande väntar.
        public void ShowOrders()
        {
            Console.WriteLine("\n--- AKTUELLA BESTÄLLNINGAR ---");

            // Här går jag igenom alla beställningar med foreach.
            // ShowOrder visar varje order utan att ta bort den från kön.
            foreach (Order order in orderQueue)
            {
                order.ShowOrder();
                Console.WriteLine();
            }
        }


        // Här vill jag se vilken beställning som står näst på tur.
        public void ShowNextOrder()
        {
            if (orderQueue.Count > 0)
            {
                // Peek hämtar första ordern utan att ta bort den.
                // Då kan vi se nästa beställning utan att ändra kön.
                Order order = orderQueue.Peek();

                Console.WriteLine("\nNästa beställning:");
                order.ShowOrder();
            }
            else
            {
                Console.WriteLine("Det finns inga beställningar.");
            }
        }


        // Här visar jag hur många beställningar som finns kvar.
        // Count ändras när vi lägger till eller tar bort en order.
        public void ShowOrderCount()
        {
            Console.WriteLine("\nAntal beställningar i kön: " + orderQueue.Count);
        }
    }
}
