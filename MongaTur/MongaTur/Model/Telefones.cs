using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongaTur.Model
{
    public class Telefones
    {
        int cd;
        string id, nome, tel;

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "cdTel")]
        public int Codigo
        {
            get { return cd; }
            set { cd = value; }
        }

        [JsonProperty(PropertyName = "nmTel")]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        [JsonProperty(PropertyName = "tel")]
        public string Telefone
        {
            get { return tel; }
            set { tel = value; }
        }
    }
}
