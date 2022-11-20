using System;
using System.Collections.Generic;
using CrmUpSchool.EntityLayer.Concrete;

namespace CrmUpSchool.DataAccessLayer.Abstract
{
    public interface IEmployeeTaskDal : IGenericDal<EmployeeTask>
    {
        List<EmployeeTask> GetEmployeeTaskByEmployee();
        List<EmployeeTask> GetEmployeeTaskById(int id);
    }
}
