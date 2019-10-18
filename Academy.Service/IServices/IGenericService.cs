using System.Threading.Tasks;

namespace Academy.Service.IServices
{
    public interface IGenericService<TInPut, TOutPut> where TInPut : class where TOutPut : class
    {
        Task<TOutPut> ListAsync<Input,OutPut>(TInPut input);
    }
}
