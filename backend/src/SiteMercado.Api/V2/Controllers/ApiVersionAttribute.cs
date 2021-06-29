using System;

namespace SiteMercado.Api.V2.Controllers
{
    internal class ApiVersionAttribute : Attribute
    {
        private string v;

        public ApiVersionAttribute(string v)
        {
            this.v = v;
        }

        public bool Deprecated { get; set; }
    }
}