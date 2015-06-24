using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TelerikListViewXF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<string>() { "Brian Rinaldi", "Burke Holland", 
                "Cody Lindley", "Ed Charbeneau", "John Bristowe", "Jen Looper", 
                "Lohith G N", "Michael Crump", "Sam Basu", "Sebastian Witalec", 
                "TJ VanToll" };
        }
    }
}
