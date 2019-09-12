using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSales.Entitys.Tables;

namespace NetSales.Entitys.Validations
{
    public class WarehouseValidator: AbstractValidator<Warehouse>
    {
        public WarehouseValidator()
        {
            RuleFor(p => p.WarehouseCode).NotEmpty().WithMessage("Depo Kodu Alanı boş geçilemez.");
            RuleFor(p => p.WarehouseName).NotEmpty().WithMessage("Depo Adı Alanı boş geçilemez.");
        }
    }
}
