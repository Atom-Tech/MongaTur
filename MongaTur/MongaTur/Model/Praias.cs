using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongaTur.Model
{
    public class Praias
    {
        int cd;
        string id, nome;

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "cdPraia")]
        public int Codigo
        {
            get { return cd; }
            set { cd = value; }
        }

        [JsonProperty(PropertyName = "nmPraia")]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
