using System;
using System.Windows.Forms;

namespace RestaurantProject
{
    internal class gvMenu
    {
        public object Cells { get; internal set; }

        public static implicit operator gvMenu(DataGridViewRow v)
        {
            throw new NotImplementedException();
        }
    }
}