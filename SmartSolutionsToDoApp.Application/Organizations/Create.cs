using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SmartSolutionsToDoApp.Application.Core;
using SmartSolutionsToDoApp.Domain;
using SmartSolutionsToDoApp.Persistence.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartSolutionsToDoApp.Application.Organizations
{
    public class Create
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Organization Organization { get; set; }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Organization).SetValidator(new OrganizationValidator());
            }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly DataContext _context;
            private readonly UserManager<AppUser> _userManager;


            public Handler(
                DataContext context,
                UserManager<AppUser> userManager)
            {
                _context = context;
                _userManager = userManager;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Organizations.Add(request.Organization);

                var result = await _context.SaveChangesAsync() > 0;

                if (!result) return Result<Unit>.Failure("Failed to create organization");

                return Result<Unit>.Success(Unit.Value);

            }
        }
    }
}
