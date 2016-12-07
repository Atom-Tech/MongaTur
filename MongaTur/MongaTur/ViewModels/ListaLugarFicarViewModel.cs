using MongaTur.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MongaTur.ViewModels
{
    public class ListaLugarFicarViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<OndeFicar> Lista { get; set; }

        public async Task Select()
        {
            IsLoading = true;
            var tabela = App.client.GetTable<OndeFicar>();
            Lista = await tabela.OrderBy(x => x.Nome).ToListAsync();
            IsLoading = false;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool _isLoading;

        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                _isLoading = value;
                OnPropertyChanged();
            }
        }
    }
}
