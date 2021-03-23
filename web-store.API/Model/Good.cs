using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_store.API.Model
{
    public class Good
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
