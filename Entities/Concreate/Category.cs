using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concreate
{
    public class Category:IEntity
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
    }
}
