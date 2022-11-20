using System;
using System.Collections.Generic;
using CrmUpSchool.DataAccessLayer.Abstract;
using CrmUpSchool.EntityLayer.Concrete;

namespace CrmUpSchool.DataAccessLayer.Abstract
{
    public interface IEmployeeTaskDetailDal : IGenericDal<EmployeeTaskDetail>
    {
        List<EmployeeTaskDetail> GetEmployeeTaskDetailById(int id);

    }
}
