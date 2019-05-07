using System.Web.Http;

namespace Owin
{
    public class TestController : ApiController
    {
        // GET
        public string Get()
        {
            return "Hello Owin";
        }
    }
}