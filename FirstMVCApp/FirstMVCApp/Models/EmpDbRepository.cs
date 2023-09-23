using Microsoft.Data.SqlClient;
using System.Data;

namespace FirstMVCApp.Models
{
    public class EmpDbRepository
    {
            public static List<Employee> GetEmpList()
        {
            List<Employee> list = new List<Employee>();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectempcmd = cn.CreateCommand();
                String selectAllEmpds = "Select*from emptbl";
                
                selectempcmd.CommandText = selectAllEmpds;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    Employee emp = new Employee
                    {
                        eno = empdr.GetInt32(0),
                        name = empdr.GetString(1),
                        salary = empdr.GetDecimal(2),
                        city = empdr.GetString(3)
                    };
                    list.Add(emp);
                }
            }
            return list;
        }

        public static Employee GetEmpById(int id)
        {
            Employee empfound = null;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectemployeecmd = cn.CreateCommand();
                String selectionEmps = "Select*from emptbl where eno=@id";   //Parameter
                selectemployeecmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectemployeecmd.CommandText = selectionEmps;
                SqlDataReader employeedr = selectemployeecmd.ExecuteReader();
                while (employeedr.Read())
                {
                    empfound = new Employee
                    {
                        eno = employeedr.GetInt32(0),
                        name = employeedr.GetString(1),
                        salary = employeedr.GetDecimal(2),
                        city = employeedr.GetString(3),
                    };



                }



                return empfound;
            }
        }
            public static int AddNewEmp(Employee newEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertEmpcmd = cn.CreateCommand();
                String insertNewEmpQuery = "insert into emptbl values( @id,@name,@salary,@city )";
                insertEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = newEmp.eno;
                insertEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = newEmp.name;
                insertEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = newEmp.city;
                insertEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = newEmp.salary;
                insertEmpcmd.CommandText = insertNewEmpQuery;
                query_result = insertEmpcmd.ExecuteNonQuery();
            }
            return query_result;
            
        }
            public static int UpdateEmp(Employee modifiedEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateEmpcmd = cn.CreateCommand();
                String updateEmpQuery = "Update emptbl set name=@name, salary=@salary, city=@city where eno=@id";
                updateEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = modifiedEmp.eno;
                updateEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = modifiedEmp.name;
                updateEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = modifiedEmp.city;
                updateEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = modifiedEmp.salary;
                updateEmpcmd.CommandText = updateEmpQuery;
                query_result = updateEmpcmd.ExecuteNonQuery();
            }
            return query_result;
            

         }
            public static int DeleteEmp(int id)
            {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
                {
                    if (cn.State != ConnectionState.Open)
                    {
                    cn.Open();
                     }
                SqlCommand deleteEmpcmd = cn.CreateCommand();
                String deleteEmpQuery = "Delete from emptbl where eno=@id";
                deleteEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteEmpcmd.CommandText = deleteEmpQuery;
                query_result = deleteEmpcmd.ExecuteNonQuery();
                }
            return query_result;
            
            }
    }
}
