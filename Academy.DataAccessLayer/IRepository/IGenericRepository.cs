﻿using System.Threading.Tasks;

namespace Academy.DataAccessLayer.IRepository
{
    public interface IGenericRepository<TInPut, TOutPut> where TInPut : class where TOutPut : class
    {
        Task<TOutPut> ListAsync<Input,OutPut>(TInPut input);
    }
}
