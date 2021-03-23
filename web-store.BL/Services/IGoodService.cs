using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using web_store.BL.Model;

namespace web_store.BL.Services
{
    public interface IGoodService
    {
        Task AddGood(Good good);
    }
}
