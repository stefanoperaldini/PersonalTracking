using DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class PermissionDAO : EmployeeContext
    {
        public static void AddPermission(PERMISSION permission)
        {
            try
            {
                db.PERMISSIONs.InsertOnSubmit(permission);
                db.SubmitChanges();

            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<PERMISSIONSTATE> GetStates()
        {
            return db.PERMISSIONSTATEs.ToList();
        }

        public static List<PermissionDetailDTO> GetPermissions()
        {
            List<PermissionDetailDTO> listPermissions = new List<PermissionDetailDTO>();
            var list = (from p in db.PERMISSIONs
                        join s in db.PERMISSIONSTATEs on p.PermissionState equals s.ID
                        join e in db.EMPLOYEEs on p.EmployeeID equals e.ID
                        select new
                        {
                            UserNo = e.UserNo,
                            Name = e.Name,
                            Surname = e.Surname,
                            StateName = s.StateName,
                            stateID = s.ID,
                            startDate = p.PermissionStartDate,
                            endDate = p.PermissionEndDate,
                            employeeID = p.EmployeeID,
                            permissionID = p.ID,
                            explanation = p.PermissionExplanation,
                            dayAmount = p.PermissionDay,
                            departmentID = e.DepartmentID,
                            positionID = e.PositionID,
                        }).OrderBy(x => x.startDate).ToList();

            foreach (var item in list)
            {
                PermissionDetailDTO dto = new PermissionDetailDTO();
                dto.UserNo = item.UserNo;
                dto.Name = item.Name;
                dto.Surname = item.Surname;
                dto.EmployeeID = item.employeeID;
                dto.PermissionDayAmount = item.dayAmount;
                dto.StartDate = item.startDate;
                dto.EndDate = item.endDate;
                dto.DepartmentID = item.departmentID;
                dto.PositionID = item.positionID;
                dto.State = item.stateID;
                dto.StateName = item.StateName;
                dto.Explanation = item.explanation;
                dto.PermissionID = item.permissionID;
                listPermissions.Add(dto);
            }
            return listPermissions;

        }

        public static void UpdatePermission(int permissionID, int approved)
        {
            try
            {
                PERMISSION pr = db.PERMISSIONs.First(x => x.ID == permissionID);
                pr.PermissionState = approved;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdatePermission(PERMISSION permission)
        {
            try
            {
                PERMISSION pr = db.PERMISSIONs.First(x => x.ID == permission.ID);
                pr.PermissionStartDate = permission.PermissionStartDate;
                pr.PermissionEndDate = permission.PermissionEndDate;
                pr.PermissionExplanation = permission.PermissionExplanation;
                pr.PermissionDay = permission.PermissionDay;
                db.SubmitChanges();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
