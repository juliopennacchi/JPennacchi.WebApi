using FluentValidation;
using JPennacchi.Application.RequestReponse.Documento;

namespace JPennacchi.Application.Validators
{
    public class ObterDocumentoValidator : AbstractValidator<ObterDocumentoRequest>
    {
        public ObterDocumentoValidator()
        {
            RuleFor(x => x.TipoDocumento)
                .NotNull()
                .NotEmpty()
                .WithMessage("Deve informar o tipo do documento");

        }
    }
}
