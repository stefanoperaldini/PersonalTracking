using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;
using DAL.DAO;
using DAL;

namespace BLL
{
    public class EmployeeBLL
    {
        public static EmployeeDTO GetAll()
        {
            EmployeeDTO dto = new EmployeeDTO();
            dto.Departments = DepartmentDAO.GetDepartments();
            dto.Positions = PositionDAO.GetPositions();
            dto.Employees = EmployeeDAO.GetEmployees();
            return dto;
        }

        public static void AddEmployee(EMPLOYEE employee)
        {
            EmployeeDAO.AddEmployee(employee);
        }

        public static bool isUnique(int v)
        {
            List<EMPLOYEE> listEmployee = EmployeeDAO.GetUsers(v);
            if (listEmployee.Count > 0)
            {
                return false;
            }
            return true;
        }

        public static List<EMPLOYEE> GetEmployees(int v, string txtPassword)
        {
            return EmployeeDAO.GetEmployees(v, txtPassword);
        }
    }
}
