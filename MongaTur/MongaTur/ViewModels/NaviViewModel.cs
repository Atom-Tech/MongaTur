using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongaTur.View;

namespace MongaTur.ViewModels
{
    public class NaviViewModel
    {
        public static List<MasterPageItem> MenuItems()
        {
            var masterPageItems = new List<MasterPageItem>
            {
                new MasterPageItem
                {
                    Titulo = "Pontos Turísticos",
                    Icone = "http://i.imgur.com/2dF30n1.png?1",
                    Pagina = typeof(ListaPontos)
                },
                new MasterPageItem
                {
                    Titulo = "Praias",
                    Icone = "http://i.imgur.com/ppj7qLV.png?1",
                    Pagina = typeof(ListaPontos)
                },
                new MasterPageItem
                {
                    Titulo = "Telefones Úteis",
                    Icone = "http://i.imgur.com/7wRLogD.png?1",
                    Pagina = typeof(ListaPontos)
                },
                new MasterPageItem
                {
                    Titulo = "Onde Comer",
                    Icone = "http://i.imgur.com/yufbcSt.png?2",
                    Pagina = typeof(ListaPontos)
                },
                new MasterPageItem
                {
                    Titulo = "Onde Ficar",
                    Icone = "http://i.imgur.com/7laVU19.png?1",
                    Pagina = typeof(ListaLugarFicar)
                },
                new MasterPageItem
                {
                    Titulo = "Feiras Livres",
                    Icone = "http://i.imgur.com/DulbmFB.png?1",
                    Pagina = typeof(ListaPontos)
                }
            };
            return masterPageItems;
        }
    }
}
