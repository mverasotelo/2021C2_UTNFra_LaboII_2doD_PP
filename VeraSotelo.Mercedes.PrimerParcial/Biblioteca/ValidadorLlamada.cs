using FluentValidation;

namespace Biblioteca
{
    public class ValidadorLlamada: AbstractValidator<Llamada>
    {
        public ValidadorLlamada()
        {
            RuleFor(x => x.CodigoPais).NotEmpty().MaximumLength(4).Matches("[0-9]+").WithMessage("El código país no es válido");
            RuleFor(x => x.PrefijoLocalidad).NotEmpty().MaximumLength(5).Matches("[0-9]").WithMessage("El prefijo no es válido");
            RuleFor(x => x.Numero).NotEmpty().MaximumLength(8).Matches("[0-9]").WithMessage("El número de teléfono no es válido");
        }
    }
}
