using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
           // WithMessage("ürünler A harfi ile başlamalı"); bunu kullanarak kendi mesajımızı yazabiliriz yoksa zaten valid
           // productmanager de errror icine verdiğimizde otomatik kendisi hatayı tarayıcı dilinde yazıyor 
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MaximumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("ürünler A harfi ile başlamalı");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
