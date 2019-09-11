using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSales.Entitys.Tables;

namespace NetSales.Entitys.Validations
{
    public class StockValidator:AbstractValidator<Stock>
    {
        public StockValidator()
        {
            RuleFor(p => p.StockCode).NotEmpty().WithMessage("Stok Kodu Boş Geçilemez");
            RuleFor(p => p.StockName).NotEmpty().WithMessage("Stok Adı Boş geçilemez").Length(5, 50).WithMessage("Stok Adı Alanı 5 ile 50 karakter arasında olmalıdır");
            RuleFor(p => p.Barcode).NotEmpty().WithMessage("Barkod alanı boş geçilemez.");
            RuleFor(p => p.BuyingPrice1).GreaterThanOrEqualTo(0).WithMessage("Alış fiyatı 1 alanı 0'dan büyük olmalıdır.");
            RuleFor(p => p.BuyingPrice2).GreaterThanOrEqualTo(0).WithMessage("Alış fiyatı 2 alanı 0'dan büyük olmalıdır.");
            RuleFor(p => p.BuyingPrice3).GreaterThanOrEqualTo(0).WithMessage("Alış fiyatı 3 alanı 0'dan büyük olmalıdır.");
            RuleFor(p => p.SalesPrice1).GreaterThanOrEqualTo(0).WithMessage("Satış fiyatı 1 alanı 0'dan büyük olmalıdır.");
            RuleFor(p => p.SalesPrice2).GreaterThanOrEqualTo(0).WithMessage("Satış fiyatı 2 alanı 0'dan büyük olmalıdır.");
            RuleFor(p => p.SalesPrice3).GreaterThanOrEqualTo(0).WithMessage("Satış fiyatı 3 alanı 0'dan büyük olmalıdır.");

        }
    }
}
