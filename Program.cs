using System;
using System.Collections.Generic;
using LinQTiendaAb3.View;
using LinQTiendaAb3.clases;
class Program
{
    public static void Main(string[] args)
    {
        int option;
        do
        {
            MainMenu menu = new MainMenu();
            option = menu.Menu();
            switch (option)
            {
                case 1:
                    
                    Product product = new Product();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    break;
            }

        } while (option != 6);
    }
}
