using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;

namespace DAL.DAO
{
    public class EmployeeDAO:EmployeeContext
    {
        public static void AddEmployee(EMPLOYEE employee)
        {
            try
            {
                db.EMPLOYEEs.InsertOnSubmit(employee);
                db.SubmitChanges();

            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<EMPLOYEE> GetUsers(int v)
        {
            return db.EMPLOYEEs.Where(x => x.UserNo == v).ToList();
        }

        public static List<EmployeeDetailDTO> GetEmployees()
        {
            List<EmployeeDetailDTO> employeeList = new List<EmployeeDetailDTO>();
            var list = (from e in db.EMPLOYEEs
                        join d in db.DEPARTMENTs on e.DepartmentID equals d.ID
                        join p in db.POSITIONs on e.PositionID equals p.ID
                        select new
                        {
                            UserNo = e.UserNo,
                            Name = e.Name,
                            Surname = e.Surname,
                            EmployeeID = e.ID,
                            Password = e.Password,
                            DepartmentName = d.DepartmentName,
                            PositionName = p.PositionName,
                            DepartmentID = d.ID,
                            PositionID = p.ID,
                            isAdmin = e.isAdmin,
                            Salary = e.Salary,
                            ImagePath = e.ImagePath,
                            BirthDay = e.BirthDay,
                            Address = e.Address,
                        }).OrderBy(x => x.UserNo).ToList();

            foreach (var item in list)
            {
                EmployeeDetailDTO dto = new EmployeeDetailDTO();
                dto.UserNo = item.UserNo;
                dto.Name = item.Name;
                dto.Surname = item.Surname;
                dto.EmployeeID = item.EmployeeID;
                dto.Password = item.Password;
                dto.DepartmentName = item.DepartmentName;
                dto.PositionName = item.PositionName;
                dto.DepartmentID = item.DepartmentID;
                dto.PositionID = item.PositionID;
                dto.isAdmin = item.isAdmin;
                dto.Salary = item.Salary;
                dto.ImagePath = item.ImagePath;
                dto.BirthDay = item.BirthDay;
                dto.Address = item.Address;
                employeeList.Add(dto);
            }
            return employeeList;
        }

        public static void UpdateEmployee(int employeeID, int amount)
        {
            try
            {
                EMPLOYEE employee = db.EMPLOYEEs.First(x => x.ID == employeeID);
                employee.Salary = amount;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<EMPLOYEE> GetEmployees(int v, string txtPassword)
        {
            try
            {
                List<EMPLOYEE> list = db.EMPLOYEEs.Where(x => (x.UserNo == v && x.Password == txtPassword)).ToList();
                return list;

            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
