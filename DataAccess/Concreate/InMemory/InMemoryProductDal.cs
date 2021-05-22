using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _productList;
        public InMemoryProductDal()
        {
            _productList = new List<Product>
            {
                new Product(){ID=1,ProductName="Telefon",CategoryID=1},
                new Product(){ID=2,ProductName="Kamera",CategoryID=1},
                new Product(){ID=3,ProductName="Bilgisayar",CategoryID=1},
                new Product(){ID=4,ProductName="Tablet",CategoryID=1}
            }; 
        }
        public void Add(Product product)
        {
            _productList.Add(product);
        }

        public void Delete(Product product)
        {
            var p = _productList.Where(x => x.ID == product.ID).FirstOrDefault();
            if (p !=null)
            {
                _productList.Remove(p); 
            }
        }

        public List<Product> GetAll()
        {
            return _productList;
        }

        public List<Product> GetAllByCategoryID(int categoryID)
        {
            return  _productList.Where(x => x.CategoryID == categoryID).ToList();
            
        }

        public void Update(Product product)
        {
            var p = _productList.Where(x => x.ID == product.ID).FirstOrDefault();
            p.ProductName = product.ProductName;
            
        }
    }
}
