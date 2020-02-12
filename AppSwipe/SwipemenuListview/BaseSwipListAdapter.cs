
using Android.Widget;

namespace AppSwipe.SwipemenuListview
{
    public abstract class BaseSwipListAdapter : BaseAdapter
    {
        public bool getSwipEnableByPosition(int position)
        {
            return true;
        }
    }
}