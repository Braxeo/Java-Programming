using System;

namespace ShoppingForm
{
    // Event 1 Delegate and Argument object creation
    public delegate bool CharCheckDelegate(object sender, CharCheckEventArgs args);

    public class CharCheckEventArgs : EventArgs
    {
        public string item_name { get; set; }
    }
}
