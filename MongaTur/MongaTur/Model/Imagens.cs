using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongaTur.Model
{
    public class ImagensT
    {
        private string id, link;
        private int cdI;

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "idPonto")]
        public int CódigoImagem
        {
            get { return cdI; }
            set { cdI = value; }
        }

        [JsonProperty(PropertyName = "linkImagem")]
        public string LinkImagem
        {
            get { return link; }
            set { link = value; }
        }
    }
}
