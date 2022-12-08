using System;
using CrmUpSchool.EntityLayer.Concrete;
using FluentValidation;

namespace CrmUpSchool.BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title can not be empty");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Content can not be empty");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Should contain at least 5 characters");
        }
    }
}
