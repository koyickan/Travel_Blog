using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Final_Project
{
    [Activity(Label = "ContactA")]
    public class ContactA : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Contact);
            // Create your application here

            Button btnCall = FindViewById<Button>(Resource.Id.button1);

            btnCall.Click += delegate {
           
                //dial call
                var uri2 = Android.Net.Uri.Parse("tel:3657774101");
                var callIntent = new Intent(Intent.ActionCall, uri2);
                StartActivity(callIntent);
            };

            Button btnEmail = FindViewById<Button>(Resource.Id.button2);

            btnEmail.Click += delegate {

                var email = new Intent(Android.Content.Intent.ActionSend);
                email.PutExtra(Android.Content.Intent.ExtraEmail,
                               new string[] { "jominWorld@gmail.com", "c0684667@mylambton.ca" });

                email.PutExtra(Android.Content.Intent.ExtraCc, new string[] { "jominWorld@gmail.com" });

                email.PutExtra(Android.Content.Intent.ExtraSubject, "Test Email");

                email.PutExtra(Android.Content.Intent.ExtraText, "This is a test email from XAMARIN Android CSD3184");

                email.SetType("message/rfc822");
                StartActivity(email);
            };
        }

    }
}