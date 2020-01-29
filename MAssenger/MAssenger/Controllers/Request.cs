using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace MAssenger.Controllers
{
    public class Request
    {
        public string Content { set; get; }
        public T GetContent<T>()
        {
            if (Content == null)
                return default;
            T result = JsonConvert.DeserializeObject<T>(Content);
            return result;
        }
    }
}