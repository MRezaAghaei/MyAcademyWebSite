using Academy.Service.IServices;
using System;
using System.Threading.Tasks;
using Academy.DataAccessLayer.IRepository;

namespace Academy.Service.Services
{
    public class GenericService<TInPut, TOutPut> : IGenericService<TInPut, TOutPut> where TInPut : class where TOutPut : class
    {
        private readonly IGenericRepository<TInPut, TOutPut> _repository;

        public GenericService(IGenericRepository<TInPut, TOutPut> repository)
        {
            _repository = repository;
        }

        public async Task<TOutPut> ListAsync<Input, OutPut>(TInPut input)
        {
            return await _repository.ListAsync<TInPut,TOutPut>(input);
        }
    }
}
