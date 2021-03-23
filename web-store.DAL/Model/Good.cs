using System;
using System.Collections.Generic;
using System.Text;

namespace web_store.DAL.Model
{
    public class Good
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
