using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongaTur.Model
{
    public class Feiras
    {
        int cd;
        string id, local, diaSemana;

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "cdFeira")]
        public int Codigo
        {
            get { return cd; }
            set { cd = value; }
        }

        [JsonProperty(PropertyName = "localFeira")]
        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        [JsonProperty(PropertyName = "diaSemana")]
        public string DiaSemana
        {
            get { return diaSemana; }
            set { diaSemana = value; }
        }
    }
}
