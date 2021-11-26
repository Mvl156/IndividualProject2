using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IndividueelProjectSemester2.Models;
using Microsoft.Data.SqlClient;

namespace IndividueelProjectSemester2.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        //Get account
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        /*
        [HttpPost]
        public ActionResult Verify(Account account)
        {
            bool flag = false;
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from tbl_login";
            dr = com.ExecuteReader();
            while(dr.Read())
            {
                Request[""]
                if (dr[1].ToString() == 
                {
                    flag = true;
                    break;
                }
            }
            
        }
        */
    }
}
