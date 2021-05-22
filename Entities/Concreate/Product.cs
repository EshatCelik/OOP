using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concreate
{
    public class Product:IEntity
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int  CategoryID { get; set; }
    }
}
