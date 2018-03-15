using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SimpleRestServer.Models;

namespace SimpleRestServer.Controllers
{
    public class HomeController : ApiController
    {
        List<EmpModel> Empdetails = new List<EmpModel>()
        {
           new EmpModel{Empid=1,Name="Manish Patil",City="Dhule"},
           new EmpModel{Empid=2,Name="Manali Patil",City="Pune"},
           new EmpModel{Empid=3,Name="Pramod Patil",City="Mumbai"}
        };

        [HttpGet]
        public IEnumerable<EmpModel> GetEmployeeDetails()
        {
            return Empdetails;
        }

        [HttpGet]
        public IEnumerable<EmpModel> GetEmployeeDetailsbyID(int id)
        {
            List<EmpModel> objlist = new List<EmpModel>();

            var EmpList=(from a in Empdetails 
                where a.Empid.Equals(id)
                select new { a.Empid,a.Name,a.City}).ToList();

            return objlist;
        }


    }
}
