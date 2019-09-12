using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSales.Entitys.Tables;


namespace NetSales.Entitys.Validations
{
    public class DefinationValidator: AbstractValidator<Defination>
    {
        public DefinationValidator()
        {
            RuleFor(p => p.Def).NotEmpty().WithMessage("Tanım alanı Boş Geçilemez");
            RuleFor(p => p.Type).NotEmpty().WithMessage("Tanım türü alanı Boş Geçilemez");
        }
    }
}
