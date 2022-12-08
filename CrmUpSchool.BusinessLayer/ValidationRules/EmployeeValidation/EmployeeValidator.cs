using System;
using CrmUpSchool.EntityLayer.Concrete;
using FluentValidation;

namespace CrmUpSchool.BusinessLayer.ValidationRules
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.EmployeeName).NotEmpty().WithMessage("Employee name cannot be empty!");
            RuleFor(x => x.EmployeeSurname).NotEmpty().WithMessage("Employee surname cannot be empty!");
            RuleFor(x => x.EmployeeName).MinimumLength(2).WithMessage("Employee name cannot be shorter than 2 characters!");

        }
    }
}
