using Firebase.Auth;
using Gerocery.feature;
using Gerocery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Java.Util.Jar.Attributes;

namespace Gerocery.ViewModels
{
   public class LoginViewModel :BaseViewModel
    {

        signup signs = new signup();


        string _Email;
        public string email { set
            {
                _Email = value;
                onpropertyChange();
            }
            get { return _Email; }
        }

        string _password;
        public string password
        {
            set
            {
                _password = value;
                onpropertyChange();
            }
            get { return _password; }
        }
        public ICommand sign { get;}

        public LoginViewModel(FirebaseAuthClient authclient)
        {
            signs = new signup();
            sign = new Command(onsign);
          //  signup osign = new signup(this,authclient);
           // sign = new Command(osign);
        }

        public async void onsign()
        {
            try
            {
                if(string.IsNullOrEmpty(email)&&password.Length<7)
                {
                    await Shell.Current.DisplayAlert("info", "enter all information","ok");
                }
                else
                {
                    var resultid = await signs.create(email, password);
                    if(string.IsNullOrEmpty(resultid))
                    {
                        await Shell.Current.DisplayAlert("error", "enter all information", "ok");
                        return;
                    }
                    else
                    {
                        await Shell.Current.DisplayAlert("ok", "you create account", "ok");
                        await Shell.Current.GoToAsync("first/items");


                    }
                    

                }
                
                
            }
            catch(Exception ex)
            {

            }
        }

       

       
        //public async void OnBn()
        //{
        //    if (string.IsNullOrEmpty(name))

        //           Shell.Current.DisplayAlert("Error", "Please enter email", "cancel");

        //            //else if (string.IsNullOrEmpty(password.Text))

        //            //    DisplayAlert("Error", "Please enter password", "cancel");

        //        else

        //                await Shell.Current.GoToAsync("first/items");

        //}
    }
}
