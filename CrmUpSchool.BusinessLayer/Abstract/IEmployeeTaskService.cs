using System;
using System.Collections.Generic;
using CrmUpSchool.EntityLayer.Concrete;

namespace CrmUpSchool.BusinessLayer.Abstract
{
    public interface IEmployeeTaskService : IGenericService<EmployeeTask>
    {
        List<EmployeeTask> TGetEmployeeTaskByEmployee();
        List<EmployeeTask> TGetEmployeeTaskById(int id);
    }
}
