using FluentValidation;
using Vb.Schema;

namespace Vb.Business.Validator;

public class CreateAccountValidator : AbstractValidator<AccountRequest>
{
    public CreateAccountValidator()
    {
        RuleFor(x => x.CustomerId).NotEmpty();
        RuleFor(x => x.AccountNumber).NotEmpty();
        RuleFor(x => x.IBAN).NotEmpty().MaximumLength(34);
        RuleFor(x => x.Balance).NotEmpty().ScalePrecision(4,18,false);
        RuleFor(x => x.CurrencyType).NotEmpty().MaximumLength(3);
        RuleFor(x => x.OpenDate).NotEmpty();
        
    }
}