using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace TelerikListViewXF
{
    public partial class PullToRefresh : ContentPage
    {
        private int count = 10;

        public PullToRefresh()
        {
            InitializeComponent();
            listView.ItemsSource = Enumerable.Range(0, this.count);
            listView.RefreshRequested += this.RefreshRequested;
        }

        private async void RefreshRequested(object sender, PullToRefreshRequestedEventArgs e)
        {
            await Task.Delay(3000);
            listView.ItemsSource = Enumerable.Range(this.count, 10);
            this.count += 10;
            listView.EndRefresh();
        }
    }
}
