using JokeApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data.Common;

namespace JokeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokesController : ControllerBase
    {
        private IConfiguration _conf;
        public JokesController(IConfiguration conf)
        {
            _conf = conf;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(null);
        }

        [HttpPost]
        public IActionResult Post(JokesModel m)
        {
            DbConnection db = Connect();

            string commande = @"
            INSERT INTO [dbo].[Jokes]
           ( 
           [Title]
           ,[Content]
           ,[IdUser]
           ,[CreationDate]
           ,[Rating])
            OUTPUT inserted.Id
            VALUES
           ( 
           @Title 
           ,@Content 
           ,@IdUser
           ,@CreationDate 
           ,@Rating )";

            SqlCommand command =(SqlCommand)db.CreateCommand();
            command.CommandText = commande;
            command.Parameters.AddWithValue("Title", m.Title);
            command.Parameters.AddWithValue("Content", m.Content);
            command.Parameters.AddWithValue("IdUser", m.IdUser);
            command.Parameters.AddWithValue("CreationDate", m.CreationDate);
            command.Parameters.AddWithValue("Rating", m.Rating);
            int id = 0;
            try
            {
               id=(int) command.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }

            return Created($"/api/Get/{id}", m);


        }

        private DbConnection Connect()
        {
#if DEBUG
            DbConnection oConn = new SqlConnection(_conf.GetConnectionString("JDBDev"));
#else
  DbConnection oConn = new SqlConnection(_conf.GetConnectionString("JDBProd"));

#endif
            try
            {
                oConn.Open();
                return oConn;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
