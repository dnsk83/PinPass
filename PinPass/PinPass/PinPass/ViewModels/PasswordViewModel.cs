using PinPass.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PinPass.ViewModels
{
    public class PasswordViewModel
    {
        private PasswordModel _Model;

        public string Name => _Model.Name;
        public string Login => _Model.Login;
        public string Password => _Model.Password;

        public PasswordViewModel(PasswordModel model)
        {
            _Model = model;
        }
    }
}
