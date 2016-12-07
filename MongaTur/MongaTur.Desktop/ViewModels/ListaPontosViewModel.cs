using MongaTur.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MongaTur.Desktop.ViewModels
{
    public class ListaPontosViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<PontosT> Lista { get; set; }

        public async Task Select()
        {
            IsLoading = true;
            var tabela = App.client.GetTable<PontosT>();
            var pontos = await tabela.OrderBy(x => x.Nome).ToEnumerableAsync();
            Lista = new ObservableCollection<PontosT>(pontos);
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
