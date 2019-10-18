using Academy.DataAccessLayer.IRepository;
using System.Threading.Tasks;

namespace Academy.DataAccessLayer.Repository
{
    public class GenericRepository<TInPut, TOutPut> : IGenericRepository<TInPut, TOutPut> where TInPut : class where TOutPut : class
    {
        //private readonly AcademyDBContext _context;


        public GenericRepository(/*AcademyDBContext context*/)
        {
            //_context = context;
        }

        public Task<TOutPut> ListAsync<Input, OutPut>(TInPut input)
        {
            return null; //(Task<TOutPut>)_context.Set<TOutPut>().FromSql("dbo.S_Teacher2_List", sqlParams);
        }
    }
}
