using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TelerikListViewXF
{
    public partial class SwipeAnItem : ContentPage
    {
        private static Random rand = new Random();
        public SwipeAnItem()
        {
            InitializeComponent();
            listView.ItemsSource = this.GetSource(10);
            listView.SwipeOffset = Device.OnPlatform<Thickness>(new Thickness(100, 0, 100, 0), 70, 0);
        }

        private System.Collections.IEnumerable GetSource(int count)
        {
            var items = new List<Item>();
            for (int i = 0; i < count; i++)
            {
                items.Add(new Item { Name = string.Format("product {0}", i), Value = rand.Next(20) });
            }

            return items;
        }

        private void IncreaseButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var item = button.BindingContext as Item;
            item.Value++;
            listView.EndItemSwipe();
        }

        private void DecreaseButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var item = button.BindingContext as Item;
            if (item.Value > 0)
            {
                item.Value--;
            }

            listView.EndItemSwipe();
        }
    }
}
