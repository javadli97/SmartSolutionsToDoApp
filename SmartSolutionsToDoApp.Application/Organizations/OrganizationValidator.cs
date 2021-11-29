using FluentValidation;
using SmartSolutionsToDoApp.Domain;

namespace SmartSolutionsToDoApp.Application.Organizations
{
    public class OrganizationValidator : AbstractValidator<Organization>
    {
        public OrganizationValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.PhoneNumber).NotEmpty();
            RuleFor(x => x.Address).NotEmpty();
        }

    }
}
