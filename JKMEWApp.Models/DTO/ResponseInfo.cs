namespace JKMEWApp.Models.DTO
{
    public class ResponseInfo
    {
        public string Message { get; set; }
        public string Title { get; set; }
        public object Value { get; set; }
        public int Status { get; set; }
        public object Errors { get; set; }
    }
}