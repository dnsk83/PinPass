using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PinPass.Pages
{
	public class MainMasterDetailPage : MasterDetailPage
	{
		public MainMasterDetailPage ()
		{
            Master = new MenuPage() { Title = "Menu" };
            Detail = new NavigationPage(new ListPage());
		}
	}
}