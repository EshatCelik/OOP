using Business.Concreate;
using DataAccess.Concreate.EFramework;
using DataAccess.Concreate.InMemory;
using System;

namespace Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager p = new ProductManager(new InMemoryProductDal());
            ProductManager pp = new ProductManager(new EFrameworkProductDal());

            foreach (var item in pp.GetAll())
            {
                System.Console.WriteLine(item.ProductName);

            }
            
        }
    }
}
