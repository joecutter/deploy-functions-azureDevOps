namespace Function3.Dto
{
    public class ApiResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public object data { get; set; }

        public ApiResponse(int code, string message, object data)
        {
            Code = code;
            Message = message;
            this.data = data;
        }
    }
}