using System;
using System.Collections.Generic;
using System.Linq;
using CrmUpSchool.DataAccessLayer.Abstract;
using CrmUpSchool.DataAccessLayer.Concrete;
using CrmUpSchool.DataAccessLayer.Repository;
using CrmUpSchool.EntityLayer.Concrete;

namespace CrmUpSchool.DataAccessLayer.EntityFramework
{
    public class EfEmployeeTaskDetailDal : GenericRepository<EmployeeTaskDetail>, IEmployeeTaskDetailDal
    {
        public List<EmployeeTaskDetail> GetEmployeeTaskDetailById(int id)
        {
            using(var context = new Context())
            {
                return context.EmployeeTaskDetails.Where(x => x.EmployeeTaskID == id).ToList();
            } 
        }
    }
}
