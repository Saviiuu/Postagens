using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Postagens.ViewModels
{
    public partial class PostViewModel : ObservableObject
    {
        [ObservableProperty]
        private string titulo;

        [ObservableProperty]
        private string corpo;


        public ICommand displayPostsCommand { get; private set; }
        PostViewModel() 
        {

            displayPostsCommand = new Command(DisplayPosts);
        
        }

        public void DisplayPosts()
        {
            Titulo = Titulo + "A";
            Corpo = Corpo + "A";
        }


    }
}
