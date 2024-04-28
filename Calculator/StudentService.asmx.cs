using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace Calculator
{
    /// <summary>
    /// Summary description for StudentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class StudentService : System.Web.Services.WebService
    {

        [WebMethod]
        public Student GetDetailsById(int id)
        {
            Student student = new Student();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using(SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("GetDetails",con);                
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new SqlParameter("@id", id);
                cmd.Parameters.Add(parameter);
                con.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(datareader);
                for(int i = 0; i<dt.Rows.Count; i++)
                {
                    student.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    student.name = dt.Rows[i]["Name"].ToString();
                    student.age = Convert.ToInt32(dt.Rows[i]["Age"]);
                    student.marks = Convert.ToInt32(dt.Rows[i]["Marks"]);
                }
            }
            return student;

        }
    }
}
