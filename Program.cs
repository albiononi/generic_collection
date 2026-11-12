using System;
using System.Collections.Generic; 
using generic_collection.Classes;

namespace generic_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Här skapar jag restaurangen som ska hålla menyn och orderkön.
            Restaurant restaurant = new Restaurant();


            // 2. Skapar fyra maträtter med ID, namn och pris.
            // m betyder att priset är av typen decimal.
            MenuItem pizza = new MenuItem(1, "Pizza", 120m);
            MenuItem burger = new MenuItem(2, "Hamburgare", 95m);
            MenuItem pasta = new MenuItem(3, "Pasta", 110m);
            MenuItem sallad = new MenuItem(4, "Sallad", 85m);

            // Lägger in rätterna i restaurangens meny med AddtoMenu.
            restaurant.AddtoMenu(pizza);
            restaurant.AddtoMenu(burger);
            restaurant.AddtoMenu(pasta);
            restaurant.AddtoMenu(sallad);


            // 3. Här visar vi alla maträtter vi har lagt till.
            restaurant.ShowMenu();



            // 4. Här skapar jag en lista för första beställningens maträtter.
            // List<MenuItem> används för att en order kan ha flera rätter.
            List<MenuItem> items1 = new List<MenuItem>();

            // Add lägger till pizza och hamburgare i första listan.
            items1.Add(pizza);
            items1.Add(burger);

            // Här skapar jag första ordern till bord 1.
            // Order-klassen sparar maträtterna och bordsnumret.
            Order order1 = new Order(items1, 1);


            // Här skapar jag en egen lista med pasta och sallad till bord 2.
            List<MenuItem> items2 = new List<MenuItem>();

            items2.Add(pasta);
            items2.Add(sallad);

            Order order2 = new Order(items2, 2);


            // Tredje ordern får en lista med pizza och pasta till bord 3.
            List<MenuItem> items3 = new List<MenuItem>();

            items3.Add(pizza);
            items3.Add(pasta);

            Order order3 = new Order(items3, 3);


            // Här lägger jag de tre beställningarna i restaurangens kö.
            // Order1 hamnar först eftersom den läggs in först.
            restaurant.CreateOrder(order1);
            restaurant.CreateOrder(order2);
            restaurant.CreateOrder(order3);


            // 5. Visar alla beställningar som väntar i kön.
            restaurant.ShowOrders();


            // 6. Visar antalet ordrar i kön, som nu är 3.
            restaurant.ShowOrderCount();


            // 7. Peek används för att visa order1 utan att ta bort den.
            restaurant.ShowNextOrder();


            // 8. Här hanteras order1 och tas bort från kön med Dequeue.
            restaurant.HandleOrder();


            restaurant.ShowOrderCount();


            // 10. Här skapar jag en ny lista med hamburgare och sallad till bord 4.
            List<MenuItem> items4 = new List<MenuItem>();

            items4.Add(burger);
            items4.Add(sallad);

            // Skapar order4 med maträtterna och bordsnumret.
            Order order4 = new Order(items4, 4);

            // Lägger order4 sist i kön efter de andra ordrarna.
            restaurant.CreateOrder(order4);


            restaurant.ShowOrderCount();


            restaurant.HandleOrder();
            restaurant.HandleOrder();


            restaurant.ShowOrderCount();


            restaurant.ShowNextOrder();


            restaurant.HandleOrder();
        }
    }
}