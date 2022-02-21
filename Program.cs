using System;
using System.Collections.Generic;
using exercicio_heranca_polimorfismo.Entities;

namespace exercicio_heranca_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            Console.WriteLine("Quantos produtos serão inseridos: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<= n; i++)
            {
                Console.WriteLine($"insira informações sobre o produto{i}");
                Console.WriteLine("Comum, usado, importado? c/u/i");
                char status = char.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string name = Console.ReadLine();
                Console.WriteLine("Preço: ");
                double price = double.Parse(Console.ReadLine());
                if(status == 'c')
                {
                    list.Add(new Product (name, price));
                }
                else if(status == 'u')
                {
                    Console.WriteLine("Data de fabricação");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(date, name, price));
                }
                else
                {
                    Console.WriteLine("Taxa: ");
                    double fees = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(fees, name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.priceTag());
            }
        }
    }
}
