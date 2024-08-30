using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator: AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("You cannot pass the description part empty...!");

            RuleFor(x => x.Image1).NotEmpty().WithMessage("Please select visual ...! ...!");

            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Please enter an description of at least 50 characters ...!");

            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Please shorten the description ...");
        }
    }
}
