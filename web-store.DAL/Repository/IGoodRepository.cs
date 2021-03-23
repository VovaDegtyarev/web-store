using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using web_store.DAL.Model;

namespace web_store.DAL.Repository
{
    public interface IGoodRepository
    {
        Task AddGood(Good good);
    }
}
