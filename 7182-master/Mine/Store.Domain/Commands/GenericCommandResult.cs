using Store.Domain.Commands.Interfaces;

namespace Store.Domain.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult() { }

        public GenericCommandResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        // Compare this snippet from Mine\Store.Domain\Commands\GenericCommandResult.cs:
        // public object Data { get; set; }
        public object Data { get; private set; }
    }
}