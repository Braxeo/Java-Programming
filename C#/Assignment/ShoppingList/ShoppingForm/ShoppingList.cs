using System.Collections.Generic;

namespace ShoppingListObj
{
    public class ShoppingList
    {
        // Shopping List object used in program
        public ShoppingList()
        {
            _list = new List<string>();
        }

        public List<string> GetList()
        {
            return _list;
        }
        public void setList(List<string> newlist)
        {
            if (newlist.GetType() == typeof(List<string>))
            {
                _list = newlist;
            }
        }
        public void Add(string item)
        {
            _list.Add(item);
        }
        public void RemoveItem(string item)
        {
            _list.Remove(item);
        }
        public void ClearList()
        {
            _list.Clear();
        }

        private List<string> _list;
    }
}
