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
    [Activity(Label = "NextLocation")]
    public class NextLocation : Activity
    {
        List<TableItem> tableItems = new List<TableItem>();
        ListView listView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
                 base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Location_Visited);

            // Create your application here
            listView = FindViewById<ListView>(Resource.Id.List);

            tableItems.Add(new TableItem() { Heading = "canada", SubHeading = "Land of snow", ImageResourceId = Resource.Drawable.canada });
            tableItems.Add(new TableItem() { Heading = "usa", SubHeading = "Land of freedom", ImageResourceId = Resource.Drawable.usa });
            tableItems.Add(new TableItem() { Heading = "Australia", SubHeading = "kangaroo city ", ImageResourceId = Resource.Drawable.australia });
            
            listView.Adapter = new HomeScreenAdapter(this, tableItems);

            listView.ItemClick += OnListItemClick;
        }

        protected void OnListItemClick(object sender, Android.Widget.AdapterView.ItemClickEventArgs e)
        {
            var listView = sender as ListView;
            var t = tableItems[e.Position];
            Android.Widget.Toast.MakeText(this, t.Heading, Android.Widget.ToastLength.Short).Show();
            Console.WriteLine("Clicked on " + t.Heading);

            

        }
    }
}
