using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.EFramework
{
    public class EFrameworkProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> list = new List<Product>()
            {
                new Product(){ProductName="kalem",ID=1,CategoryID=1},
                new Product(){ProductName="silgi",ID=2,CategoryID=1},
                new Product(){ProductName="defter",ID=3,CategoryID=1},
            };

            return list;
        }

        public List<Product> GetAllByCategoryID(int categoryID)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
