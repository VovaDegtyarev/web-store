using Nelibur.ObjectMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using web_store.BL.Model;
using web_store.DAL.Repository;

namespace web_store.BL.Services
{
    public class GoodService : IGoodService
    {
        private readonly IGoodRepository goodRepository;

        public GoodService(IGoodRepository goodRepository)
        {
            this.goodRepository = goodRepository;
        }

        public async Task AddGood(Good good)
        {
            TinyMapper.Bind<Good, web_store.DAL.Model.Good>();
            var newGood = TinyMapper.Map<web_store.DAL.Model.Good>(good);

            await goodRepository.AddGood(newGood);
        }
    }
}
