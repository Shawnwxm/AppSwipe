using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using AppSwipe.Model;

namespace AppSwipe.Adapters
{
    public class ListViewAdapter : BaseAdapter<Businesser>
    {
        readonly List<Businesser> _items;
        readonly Activity _context;
        public ListViewAdapter(Activity context, List<Businesser> items)
        {
            _context = context;
            _items = items;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override Businesser this[int position] => _items[position];

        public override int Count => _items.Count;

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _items[position];
            View view = convertView ?? _context.LayoutInflater.Inflate(Resource.Layout.listview_item, null);
            view.FindViewById<TextView>(Resource.Id.tv_item_bno).Text = item.BusinesserNO;
            view.FindViewById<TextView>(Resource.Id.tv_item_bname).Text = item.BusinesserName;
            return view;
        }
    }
}