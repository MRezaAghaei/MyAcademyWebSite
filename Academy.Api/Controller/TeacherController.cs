using System.Threading.Tasks;
using Academy.DataAccessLayer.Teacher;
using Academy.Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        //private readonly IGenericService<Teacher, DbSet<Teacher>> _service;

        //public TeacherController(IGenericService<Teacher, DbSet<Teacher>> service)
        //{
        //    _service = service;
        //}

        //[HttpGet]
        //[Route("[action]")]
        //public async Task<dynamic> ListAsync([FromBody] ListTeacherInDto model)
        //{
        //    //var x = await _service.ListAsync<ListTeacherInDto, GeneralResult>(model);
        //    return await _service.ListAsync<dynamic, GeneralResult>(new Teacher() { Id = 5 });
        //}

        //[HttpGet]
        //[Route("[action]")]
        //public string List()
        //{
        //    using (AcademyDBContext db = new AcademyDBContext())
        //    {
        //        //db.Database.OpenConnection();
        //        //DbCommand command = db.Database.GetDbConnection().CreateCommand();
        //        //DbParameter parameter = new SqlParameter("@Id", SqlDbType.BigInt);
        //        //parameter.Value = 45;

        //        //command.CommandText = "dbo.S_Teacher2_List";
        //        //command.CommandType = CommandType.StoredProcedure;
        //        //command.Parameters.Add(parameter);
        //        //var x = command.ExecuteReader();


        //        object[] sqlParams = {
        //            new SqlParameter("@Id", 45),
        //        };

        //        var y = db.Set<Teacher>().FromSql("S_Teacher2_List", sqlParams);
        //    }

            

        //    return "salam";
        //}
    }
}
