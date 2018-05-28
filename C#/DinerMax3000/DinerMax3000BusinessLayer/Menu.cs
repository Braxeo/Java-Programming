using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business.DSDinerMax300TableAdapters;

namespace DinerMax3000.Business
{
    // Base class for different menu types
    public class Menu
    {
        public Menu()
        {
            // instantiate the item menu as soon as Menu launches
            Items = new List<MenuItem>();
        }
        private int _databaseId;

        public void SaveNewMenuItem(string Name, string Description, double Price)
        {
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();
            taMenuItem.InsertNewMenuItem(Name, Description, Price, DatabaseId);
        }

        public static List<Menu> GetAllMenus()
        {
            MenuTableAdapter taMenu = new MenuTableAdapter();
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();
            var dtMenu = taMenu.GetData();
            List<Menu> allMenus = new List<Menu>();


            foreach (DSDinerMax300.MenuRow menuRow in dtMenu.Rows)
            {
                Menu currentMenu = new Menu();
                currentMenu.Name = menuRow.Name;
                currentMenu.DatabaseId = menuRow.Id;
                allMenus.Add(currentMenu);

                var dtMenuItems = taMenuItem.GetMenuItemsByMenuId(menuRow.Id);
                foreach(DSDinerMax300.MenuItemRow menuItemRow in dtMenuItems.Rows)
                {
                    currentMenu.AddMenuItem(menuItemRow.Name, menuItemRow.Description, menuItemRow.Price);

                }
            }

            return allMenus;

        }

        public void AddMenuItem(string Title, string Description, double Price)
        {
            MenuItem item = new MenuItem();
            item.Title = Title;
            item.Description = Description;
            item.Price = Price;
            Items.Add(item);
        }

        public string Name { get; set; }
        public List<MenuItem> Items { get; set; }
        public int DatabaseId { get => _databaseId; set => _databaseId = value; }
    }
}
