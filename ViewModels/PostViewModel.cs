using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Postagens.ViewModels
{
    public partial class PostViewModel : ObservableObject
    {
        [ObservableProperty]
        private string titulo;

        [ObservableProperty]
        private string corpo;



    }
}
