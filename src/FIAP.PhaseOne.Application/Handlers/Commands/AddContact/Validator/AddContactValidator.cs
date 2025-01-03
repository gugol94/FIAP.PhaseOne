﻿using FIAP.PhaseOne.Application.Dto.Validators;
using FluentValidation;

namespace FIAP.PhaseOne.Application.Handlers.Commands.AddContact.Validator;

public class AddContactValidator : AbstractValidator<AddContactRequest>
{
    public AddContactValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(150);

        RuleFor(x => x.Name)
           .Matches("^[A-Za-záéíóúàèìòùâêîôûãõçñ]+(?: [A-Za-záéíóúàèìòùâêîôûãõçñ]+)+$")
           .WithMessage("Formato inválido");

        RuleFor(x => x.Email)
            .NotEmpty()
            .MaximumLength(100)
            .EmailAddress();

        RuleFor(x => x.Address)
            .NotEmpty();

        RuleFor(x => x.Phone)
           .NotEmpty();

        RuleFor(x => x.Address).SetValidator(new AddressDtoValidator());

        RuleFor(x => x.Phone).SetValidator(new PhoneDtoValidator());
    }
}
