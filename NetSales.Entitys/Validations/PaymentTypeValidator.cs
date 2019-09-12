using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSales.Entitys.Tables;

namespace NetSales.Entitys.Validations
{
    public class PaymentTypeValidator: AbstractValidator<PaymentType>
    {
        public PaymentTypeValidator()
        {
            RuleFor(p => p.PaymentTypeCode).NotEmpty().WithMessage("Ödeme Tipi boş geçilemez.");
            RuleFor(p => p.PaymentTypeName).NotEmpty().WithMessage("Ödeme Adı alanı boş geçilemez.");
        }

    }
}
