using _DAO_KHAI_MINH_5951071058_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _DAO_KHAI_MINH_5951071058_.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var StudentInfList = new List<StudentInfo>();

            for (int i = 0; i < 10; i++)
            {
                var studentInfo = new StudentInfo
                {
                   Fullname = $"DAO KHAI MINH {i}",
                    MSV = i * 5951071058,
                    DateTime = DateTime.Now.ToUniversalTime()
                };
                StudentInfList.Add(studentInfo);
            }
            return StudentInfList;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                Fullname = $"DAO KHAI MINH {id}",
                MSV = id * 5951071058,
                DateTime = DateTime.Now.ToUniversalTime()
            };
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
