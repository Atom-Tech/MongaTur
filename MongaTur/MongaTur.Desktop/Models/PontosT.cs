using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongaTur.Desktop.Models
{
    public class PontosT
    {
        int cd;
        string id, name, desc, local;

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "cdPonto")]
        public int Codigo
        {
            get { return cd; }
            set { cd = value; }
        }

        [JsonProperty(PropertyName = "nmPonto")]
        public string Nome
        {
            get { return name; }
            set { name = value; }
        }

        [JsonProperty(PropertyName = "dsPonto")]
        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        [JsonProperty(PropertyName = "localPonto")]
        public string Local
        {
            get { return local; }
            set { local = value; }
        }
    }
}
