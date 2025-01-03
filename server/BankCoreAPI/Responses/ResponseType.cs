namespace BankCoreAPI.Responses
{
    public class ResponseType<T>
    {
        public T? Data { get; set; } = default;

        public string? Error { get; set; }
    }
}
