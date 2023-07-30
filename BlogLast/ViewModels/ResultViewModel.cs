namespace BlogLast.ViewModels
{
    public class ResultViewModel<T> // Padronizar a forma de retorno
    {
        public ResultViewModel(T data, List<string> errorsList)
        {
            Data = data;
            ErrorsList = errorsList;
        }

        public ResultViewModel(T data)
        {
            Data = data;
        }

        public ResultViewModel(List<string> errors)
        {
            ErrorsList = errors;
        }

        public ResultViewModel(string error)
        {
            ErrorsList.Add(error);
        }

        public T Data { get; private set; }
        public List<string> ErrorsList { get; private set; } = new();
    }
}
