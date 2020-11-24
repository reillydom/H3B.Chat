using H3B.Chat.Validation;
using H3B.Chat.Validation.Rules;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace H3B.Chat.Models.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        private ValidatableObject<string> _userName = new ValidatableObject<string>();
        public ValidatableObject<string> UserName
        {
            get => _userName;
            set => base.SetProperty(ref _userName, value);
        }

        private ValidatableObject<string> _password = new ValidatableObject<string>();
        public ValidatableObject<string> Password
        {
            get => _password;
            set => base.SetProperty(ref _password, value);
        }

        public ICommand LoginCommand { get; private set; }
        public ICommand ValidateUserNameCommand { get; private set; }
        public LoginViewModel()
        {
            this.AddValidationRules();

            this.LoginCommand = new Command(() =>
            {
                if (this.IsFormValid())
                {

                }
            });
            this.ValidateUserNameCommand = new Command(() => IsUserNameValid());
        }


        #region Private methods
        private void AddValidationRules()
        {
            _userName.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A username is required." });
        }

        private bool IsFormValid()
        {
            bool isValidUser = this.IsUserNameValid();
            return isValidUser;
        }


        private bool IsUserNameValid()
        {
            return _userName.Validate();
        }

        #endregion


    }
}
