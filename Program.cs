using System;
using System.Collections.Generic; 
using generic_collection.Classes;

namespace generic_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();


            // 2. Skapar fyra maträtter med ID, namn och pris
            // m gör att priset blir av typen decimal
            MenuItem pizza = new MenuItem(1, "Pizza", 120m);
            MenuItem burger = new MenuItem(2, "Hamburgare", 95m);
            MenuItem pasta = new MenuItem(3, "Pasta", 110m);
            MenuItem sallad = new MenuItem(4, "Sallad", 85m);

            // Lägger till maträtterna i restaurangens List
            restaurant.AddtoMenu(pizza);
            restaurant.AddtoMenu(burger);
            restaurant.AddtoMenu(pasta);
            restaurant.AddtoMenu(sallad);


            // 3. Visar alla maträtter i menyn
            restaurant.ShowMenu();


            // 4. Skapar tre beställningar med två maträtter i varje

            // Skapar en List som ska innehålla MenuItem-objekt
            // Vi använder en lista eftersom en order kan ha flera maträtter
            List<MenuItem> items1 = new List<MenuItem>();

            // Add lägger till maträtter i listan
            items1.Add(pizza);
            items1.Add(burger);

            // Skapar en beställning till bord 1
            Order order1 = new Order(items1, 1);


            List<MenuItem> items2 = new List<MenuItem>();

            items2.Add(pasta);
            items2.Add(sallad);

            Order order2 = new Order(items2, 2);


            List<MenuItem> items3 = new List<MenuItem>();

            items3.Add(pizza);
            items3.Add(pasta);

            Order order3 = new Order(items3, 3);


            // CreateOrder använder Enqueue i Restaurant
            // Det lägger beställningarna sist i Queue
            restaurant.CreateOrder(order1);
            restaurant.CreateOrder(order2);
            restaurant.CreateOrder(order3);


            // 5. Visar alla beställningar i kön
            // foreach används i Restaurant för att gå igenom kön
            restaurant.ShowOrders();


            // 6. Visar antalet beställningar med Count
            restaurant.ShowOrderCount();


            // 7. Visar nästa beställning
            // Peek används så att beställningen inte tas bort
            restaurant.ShowNextOrder();


            // 8. Hanterar den första beställningen
            // Dequeue tar bort den från kön
            restaurant.HandleOrder();


            // 9. Visar antalet beställningar efter att en tagits bort
            restaurant.ShowOrderCount();


            // 10. Skapar en ny beställning med två maträtter
            List<MenuItem> items4 = new List<MenuItem>();

            items4.Add(burger);
            items4.Add(sallad);

            // Skapar beställningen till bord 4
            Order order4 = new Order(items4, 4);

            // Enqueue används för att lägga ordern sist i kön
            restaurant.CreateOrder(order4);


            // 11. Visar det nya antalet beställningar
            restaurant.ShowOrderCount();


            // 12. Hanterar två beställningar
            // Varje anrop använder Dequeue och tar bort en order
            restaurant.HandleOrder();
            restaurant.HandleOrder();


            // 13. Visar hur många beställningar som finns kvar
            restaurant.ShowOrderCount();


            // 14. Visar nästa beställning med Peek
            restaurant.ShowNextOrder();


            // 15. Hanterar den sista beställningen
            restaurant.HandleOrder();
        }
    }
}