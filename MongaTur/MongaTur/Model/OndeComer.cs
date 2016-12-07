using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongaTur.Model
{
    public class OndeComer
    {
        int cd;
        string id, nome, endereco, tel;

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "cdLocal")]
        public int Codigo
        {
            get { return cd; }
            set { cd = value; }
        }

        [JsonProperty(PropertyName = "nmLocal")]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        [JsonProperty(PropertyName = "endLocal")]
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        [JsonProperty(PropertyName = "telLocal")]
        public string Telefone
        {
            get { return tel; }
            set { tel = value; }
        }
    }
}
