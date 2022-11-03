using Microsoft.EntityFrameworkCore.Query.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Class1
    {
        [JsonProperty]
        string name { get; set; }

        [JsonProperty]
        string confederacion { get; set; }

        public Class1(string name, string confederacion)
        {
            this.name = name;
            this.confederacion = confederacion;
        }
    }
}
