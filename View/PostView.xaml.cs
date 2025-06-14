using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Postagens.ViewModels;

namespace Postagens.View;

public partial class PostView : ContentPage
{
	public PostView()
	{
		InitializeComponent();
		BindingContext = new PostViewModel();
	}
}