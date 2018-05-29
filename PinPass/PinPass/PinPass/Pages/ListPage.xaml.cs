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
	public partial class ListPage : ContentPage
	{
        public ListViewModel _VM { get; set; }

        public ListPage ()
		{
			InitializeComponent ();

            _VM =_VM ?? new ListViewModel();
            this.BindingContext = _VM;
		}

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            var selected = _VM.SelectedItem as PasswordModel;
            Navigation.PushAsync(new PasswordPage(selected));

            ((ListView)sender).SelectedItem = null;
        }
    }
}