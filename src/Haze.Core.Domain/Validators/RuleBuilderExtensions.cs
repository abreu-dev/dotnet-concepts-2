using FluentValidation;
using Haze.Core.Domain.Common;

namespace Haze.Core.Domain.Validators
{
    public static class RuleBuilderExtensions
    {
        public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            var options = ruleBuilder
                .NotEmpty().WithMessage(CoreUserMessages.ValorObrigatorioA.Format("Password").Message);

            return options;
        }
    }
}
