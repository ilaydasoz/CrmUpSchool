using System;
using CrmUpSchool.BusinessLayer.Abstract;
using CrmUpSchool.BusinessLayer.Concrete;
using CrmUpSchool.DataAccessLayer.Abstract;
using CrmUpSchool.DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace CrmUpSchool.BusinessLayer.DIContainer
{
    public static class Extensions
    {
        public static void Containerdependencies(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EFCategoryDal>();

            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddScoped<IEmployeeDal, EfEmployeeDal>();

            services.AddScoped<IEmployeeTaskService, EmployeeTaskManager>();
            services.AddScoped<IEmployeeTaskDal, EfEmployeeTaskDal>();

            services.AddScoped<IEmployeeTaskDetailService, EmployeeTaskDetailManager>();
            services.AddScoped<IEmployeeTaskDetailDal, EfEmployeeTaskDetailDal>();

            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<IMessageDal, EfMessageDal>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
        }
    }
}
