using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInformationSystem.DAL.DAO;
using EmployeeInformationSystem.DAL.Gateway;

namespace EmployeeInformationSystem.BLL
{
    class DesignationManager
    {
        public string Save(Designation aDesignation)
        {
            DesignationGateway aGateway = new DesignationGateway();
            Designation designationFound = aGateway.Find(aDesignation.Code);
            if (designationFound == null)
            {
                aGateway.Insert(aDesignation);
                return "Saved";
            }
            else
            {
                return "Duplicate. Not saved";
            }
        }
    }
}
