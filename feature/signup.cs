using Firebase.Auth;
using Firebase.Auth.Providers;
using Gerocery.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth;

namespace Gerocery.feature
{
    public class signup
    {

        private static FirebaseAuthConfig config = new FirebaseAuthConfig()
        {
            ApiKey = "AIzaSyBw86lHro7leNjNCY4PNfZLEEDiuwWHKms",
            AuthDomain = "gerocery-890c3.firebaseapp.com",
            Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                }
        };
        FirebaseAuthClient client = new FirebaseAuthClient(config);

        //create account

        public async Task<string> create(string email, string password)
        {
            var res = await client.CreateUserWithEmailAndPasswordAsync(email, password);
            return res.User.Info.Uid.ToString();
        }

        
    

               

               
    }
}
