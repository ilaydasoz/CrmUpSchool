using System;
using System.Collections.Generic;
using CrmUpSchool.EntityLayer.Concrete;

namespace CrmUpSchool.BusinessLayer.Abstract
{
    public interface IEmployeeTaskDetailService : IGenericService<EmployeeTaskDetail>
    {
        List<EmployeeTaskDetail> TGetEmployeeTaskDetailById(int id);
    }
}
