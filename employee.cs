using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication3
{
   public class employee : INotifyPropertyChanged
    {
        private string name;
        private string title;
        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
                onChanged();
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                onChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;


        public void onChanged( [CallerMemberName] string PropertyName ="" )
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this,new PropertyChangedEventArgs(PropertyName));
        }

       

    }
}
