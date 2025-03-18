using System.Net;

namespace MbDevelopment.Eden.BotanicalAPI.Shared.Base;

public interface IResponse<T>
{
    public HttpStatusCode Status { get; set; }
    public string Message { get; set; }
    public string[] Errors { get; set; }
    public T Data { get; set; }
}