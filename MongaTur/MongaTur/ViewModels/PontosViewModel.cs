using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongaTur.Model;

namespace MongaTur.ViewModels
{
    public class PontosViewModel
    {
        public List<ImagensT> Lista { get; set; }
        private PontosT p;

        public PontosViewModel(PontosT p)
        {
            this.p = p;
        }

        public async Task Select(int codigo)
        {
            var tabela = App.client.GetTable<ImagensT>();
            Lista = await tabela
                .Where(l => l.CodigoPonto == codigo)
                .ToListAsync();
        }

        public string Nome
        {
            get { return p.Nome; }
        }

        public string Local
        {
            get { return p.Local; }
        }

        public string Descricao
        {
            get { return p.Desc; }
        }
        
    }
}
