using System;

namespace ShoppingForm
{
    // Event 2 Delegate and Argument object creation
    public delegate System.Drawing.Color MouseCheck(object sender, ColorArgs args);
    
    public class ColorArgs : EventArgs
    {
        public System.Drawing.Color color { get; set; }
    }
}
