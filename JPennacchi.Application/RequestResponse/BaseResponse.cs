using FluentValidation.Results;

namespace JPennacchi.Application.RequestResponse
{
    public class Response
    {
        public bool Valid
        {
            get { return this.Error == null; }
        }

        public ErrorResponse Error { get; private set; }

        public void AddError(List<ValidationFailure> fluentValidations) =>
            this.AddError(ErrorType.ValidationError, fluentValidations.Select(f => f.ErrorMessage).ToList());

        public void AddError(Exception exception)
        {
            this.AddError(ErrorType.InternalError, new List<string> { exception.Message });
        }

        public void AddError(ErrorType type, IList<string> messages)
        {
            this.Error ??= new ErrorResponse(type, messages);
        }
    }

    public class ErrorResponse
    {
        public ErrorResponse(ErrorType type, IList<string> messages)
        {
            this.Type = type;
            this.Messages = messages;
        }
        public ErrorType Type { get; set; }
        public IList<string> Messages { get; set; }
    }

    public enum ErrorType
    {
        Success = 100,
        ValidationError = 400,
        InternalError = 500
    }

}
