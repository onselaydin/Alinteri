using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSales.Entitys.Tables;

namespace NetSales.Entitys.Validations
{
    public class CurrentValidator: AbstractValidator<Current>
    {
        public CurrentValidator()
        {
            RuleFor(p => p.CurrentCode).NotEmpty().WithMessage(" Cari kodu alanı boş geçilemez");
            RuleFor(p => p.CurrentName).NotEmpty().WithMessage(" Cari adı alanı boş geçilemez");
            RuleFor(p => p.AuthorizedPerson).NotEmpty().WithMessage("Yetkişi adı alanı boş geçilemez");
            RuleFor(p => p.InvoiceTitle).NotEmpty().WithMessage("Fatura ünvanı alanı boş geçilemez");
            RuleFor(p => p.EMail).EmailAddress().WithMessage("Girdiğiniz email adresi geçerli değil.");
            RuleFor(p => p.DiscountRate).GreaterThanOrEqualTo(0).WithMessage("İskonto oranı 0'dan güçük olamaz.");
            RuleFor(p => p.RiskLimit).GreaterThanOrEqualTo(0).WithMessage("Risk limiti 0'dan küçük olamaz.");


        }
    }
}
