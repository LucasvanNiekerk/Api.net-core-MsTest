using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherInformationsController : ControllerBase
    {
        // GET: api/WeatherInformations
        [HttpGet]
        public IEnumerable<WeatherInformation> Get()
        {
            List<WeatherInformation> result = new List<WeatherInformation>();
            string sqlCommand = "GET * FROM WeatherInformation";
            string connectionString = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlCommand))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(ReadNextElement(reader));
                }
                reader.Close();
                reader?.Dispose();
            }

            return result;
        }

        private WeatherInformation ReadNextElement(SqlDataReader reader)
        {
            WeatherInformation item = new WeatherInformation();
            item.Id = reader.GetInt16(0);
            item.RaspberryId = reader.GetString(1);
            item.Temperature = reader.GetString(2);
            item.Humidity = reader.GetString(3);
            item.TimeStamp = reader.GetString(4);

            return item;
        }

        // GET: api/WeatherInformations/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/WeatherInformations
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/WeatherInformations/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
