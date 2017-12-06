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
    [Activity(Label = "LocationVisited")]
    public class LocationVisited : Activity
    {
        List<TableItem> tableItems = new List<TableItem>();
        ListView listView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Location_Visited);

            // Create your application here
            listView = FindViewById<ListView>(Resource.Id.List);

            tableItems.Add(new TableItem() { Heading = "Korea", SubHeading = "Wonderful city with variey of foods", ImageResourceId = Resource.Drawable.korea });
            tableItems.Add(new TableItem() { Heading = "Maldives", SubHeading = "Land of beaches", ImageResourceId = Resource.Drawable.Maldives });
            tableItems.Add(new TableItem() { Heading = "Singapore", SubHeading = "Amazing city view ", ImageResourceId = Resource.Drawable.singapore });
            
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
