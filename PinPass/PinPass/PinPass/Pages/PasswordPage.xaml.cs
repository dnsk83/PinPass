using PinPass.Models;
using PinPass.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PinPass.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PasswordPage : ContentPage
	{
        public PasswordViewModel _VM { get; set; }

        public PasswordPage (PasswordModel model)
		{
			InitializeComponent ();

            _VM = _VM ?? new PasswordViewModel(model);
            this.BindingContext = _VM;
        }
	}
}