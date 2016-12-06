using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MongaTur.Model;

namespace MongaTur.ViewModels
{
    public class PontosViewModel : INotifyPropertyChanged
    {
        public List<ImagensT> Lista { get; set; }
        private PontosT p;

        public PontosViewModel()
        {
            p = new PontosT();
        }

        public void AddPonto(PontosT p)
        {
            this.p = p;
            Nome = p.Nome;
        }

        public async Task Select(int codigo)
        {
            var tabela = App.client.GetTable<ImagensT>();
            Lista = await tabela
                .Where(l => l.CodigoPonto == codigo)
                .ToListAsync();
            Imagem = Lista[0].LinkImagem;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _nome;

        public string Local
        {
            get { return p.Local; }
        }

        public string Descricao
        {
            get { return p.Desc; }
        }

        public string Imagem
        {
            get { return _Imagem; }
            set { _Imagem = value; OnPropertyChanged(nameof(Imagem)); }
        }

        private string _Imagem;
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
