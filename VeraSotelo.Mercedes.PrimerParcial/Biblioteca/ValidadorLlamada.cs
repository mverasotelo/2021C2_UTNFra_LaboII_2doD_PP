using FluentValidation;

namespace Biblioteca
{
    public class ValidadorLlamada: AbstractValidator<Llamada>
    {
        /// <summary>
        /// Valida que los números ingresados para llamadas sean válidos
        /// </summary>
        public ValidadorLlamada()
        {
            RuleFor(x => x.CodigoPais).NotEmpty().MaximumLength(4).Matches("^[0-9]*$").WithMessage("El código país no es válido");
            RuleFor(x => x.PrefijoLocalidad).NotEmpty().MinimumLength(2).MaximumLength(5).Matches("^[0-9]*$").WithMessage("El prefijo no es válido");
            RuleFor(x => x.Numero).NotEmpty().MinimumLength(6).MaximumLength(8).Matches("^[0-9]*$").WithMessage("El número de teléfono no es válido");
        }
    }
}
