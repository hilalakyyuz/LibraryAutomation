using System.Net;

namespace KutuphaneYeni.Token
{
    internal class HataMesaj<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Data { get; set; }
    }
}