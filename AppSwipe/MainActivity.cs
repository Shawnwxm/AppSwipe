using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;
using Android.Graphics;
using System.Collections.Generic;
using AppSwipe.SwipemenuListview;

namespace AppSwipe
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : Activity, ISwipeMenuCreator, IOnMenuItemClickListener
    {
        List<string> contacts = new List<string>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            contacts.Add("Item 1");
            contacts.Add("Item 2");
            contacts.Add("Item 3");
            contacts.Add("Item 4");
            contacts.Add("Item 5");
            contacts.Add("Item 6");
            contacts.Add("Item 7");
            contacts.Add("Item 8");
            contacts.Add("Item 9");
            contacts.Add("Item 10");

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SwipeMenuListView listview = FindViewById<SwipeMenuListView>(Resource.Id.listView);

            ArrayAdapter<string> ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, contacts);
            listview.Adapter = ListAdapter;

            listview.MenuCreator = this;
            listview.MenuItemClickListener = this;
        }
        public void Create(SwipeMenu menu)
        {
            SwipeMenuItem callItem = new SwipeMenuItem(this)
            {
                Width = 200,
                Background = new ColorDrawable(Color.AliceBlue),
                IconRes = Resource.Mipmap.icon_like
            };
            menu.AddMenuItem(callItem);

            SwipeMenuItem copyItem = new SwipeMenuItem(this)
            {
                Background = new ColorDrawable(Color.Azure),
                Width = 200,
                IconRes = Resource.Mipmap.icon_delete
            };
            menu.AddMenuItem(copyItem);
        }

        public bool OnMenuItemClick(int position, SwipeMenu menu, int index)
        {
            //var contact = ((listview.Adapter as SwipeMenuAdapter).WrappedAdapter as ContactUsSwipeAdapter).Items[position];
            string contact = contacts[position];
            switch (index)
            {
                case 0:
                    Toast.MakeText(this, "Like Button Clicked", ToastLength.Long).Show();
                    //int type = menu.GetViewType();
                    //if (menu.GetViewType() == 0)
                    //{

                    //}
                    //else
                    //{

                    //}
                    break;
                case 1: // copy
                    Toast.MakeText(this, "Delete Button Clicked", ToastLength.Long).Show();
                    break;
            }
            return false;
        }
    }
}

