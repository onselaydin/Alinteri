using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSales.Entitys.Tables;

namespace NetSales.Entitys.Validations
{
    public class CaseValidator: AbstractValidator<Case>
    {
        public CaseValidator()
        {
            RuleFor(p => p.CaseCode).NotEmpty().WithMessage("Kasa kodu alanı boş geçilemez.");
            RuleFor(p => p.CaseName).NotEmpty().WithMessage("Kasa adı alanı boş geçilemez.");
        }

    }
}
