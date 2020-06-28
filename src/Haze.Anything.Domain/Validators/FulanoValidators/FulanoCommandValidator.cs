using FluentValidation;
using Haze.Anything.Domain.Commands.FulanoCommands;
using Haze.Core.Domain.Common;
using System;
using System.Data;

namespace Haze.Anything.Domain.Validators.FulanoValidators
{
    public abstract class FulanoCommandValidator<T> : AbstractValidator<T>
        where T : FulanoCommand<T>

    {
        protected void IdObrigatorio()
        {
            RuleFor(c => c.AggregateId)
                .NotEqual(Guid.Empty)
                .WithMessage(CoreUserMessages.ValorObrigatorioO.Format("Id").Message);
        }

        protected void NomeObrigatorio()
        {
            RuleFor(c => c.Entity.Nome)
                .NotEmpty()
                .WithMessage(CoreUserMessages.ValorObrigatorioO.Format("Nome").Message);
        }

        protected void ValorUnitarioObrigatorio()
        {
            RuleFor(c => c.Entity.ValorUnitario)
                .NotEmpty()
                .WithMessage(CoreUserMessages.ValorObrigatorioO.Format("Valor Unitário").Message);
        }

        protected void ValorUnitarioMaiorIgual()
        {
            RuleFor(c => c.Entity.ValorUnitario)
                .GreaterThanOrEqualTo(0)
                .WithMessage(CoreUserMessages.ValorDeveSerIgualMaiorQue.Format("Valor Unitário", 0).Message);
        }

        protected void AtivoObrigatorio()
        {
            RuleFor(c => c.Entity.Ativo)
                .NotEmpty()
                .WithMessage(CoreUserMessages.ValorDuplicadoO.Format("Ativo").Message);
        }
    }
}