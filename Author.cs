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
    [Activity(Label = "Author")]
    public class Author : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.BlogAuthorLayout);

            Button showPopupMenu = FindViewById<Button>(Resource.Id.button1);
            showPopupMenu.Click += delegate
            {
                

                PopupMenu menu = new PopupMenu(this, showPopupMenu);
                menu.Inflate(Resource.Menu.popup_menu);

                menu.MenuItemClick += (s1, e1) =>
                {
                    Toast.MakeText(this, e1.Item.TitleFormatted.ToString(), ToastLength.Long).Show();

                    

                    switch (e1.Item.TitleFormatted.ToString())
                    {
                        case "Location Visited":
                            StartActivity(typeof(LocationVisited));
                            break;
                        case "Next Vacation Destination":
                            StartActivity(typeof(NextLocation));
                            break;
                        case "Contact Blogger":
                            StartActivity(typeof(ContactA));
                            break;                       
                    }
                };
                menu.Show();

            };
        }
    }
}