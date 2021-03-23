using Nelibur.ObjectMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using web_store.DAL.Context;
using web_store.DAL.Model;

namespace web_store.DAL.Repository
{
    public class GoodRepository : IGoodRepository
    {

        private readonly GoodDbContext goodDbContext;

        public GoodRepository(GoodDbContext goodDbContext)
        {
            this.goodDbContext = goodDbContext;
        }

        public async Task AddGood(Good good)
        {
            if (good == null)
            {
                throw new ArgumentNullException(nameof(good));
            }

            await goodDbContext.Goods.AddAsync(good);
            await goodDbContext.SaveChangesAsync();
        }
    }
}
