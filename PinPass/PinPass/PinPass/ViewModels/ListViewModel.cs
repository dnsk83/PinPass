using PinPass.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PinPass.ViewModels
{
    public class ListViewModel
    {
        public ObservableCollection<IListable> Items { get; set; }
        public IListable SelectedItem { get; set; }

        public ListViewModel()
        {
            Items = new ObservableCollection<IListable>();

            Items.Add(new PasswordModel() { Name = "Gmail", Login = "damihin", Password = "1235" });
            Items.Add(new PasswordModel() { Name = "VTB", Login = "12345", Password = "hello" });
            Items.Add(new PasswordModel() { Name = "Noringa", Login = "test@test.com", Password = "123pass" });
        }
    }
}
