using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace TelerikListViewXF
{
    public class Item : INotifyPropertyChanged
    {
        private string name;
        private int age;
        private int value;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Value
        {
            get
            {
                return this.value;
            }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (this.age != value)
                {
                    this.age = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        private void RaisePropertyChanged([CallerMemberName]
                                          string propertyName = null)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                lock (handler)
                {
                    handler(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
    }
}
