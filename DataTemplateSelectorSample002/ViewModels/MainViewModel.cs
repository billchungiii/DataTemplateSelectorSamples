using BindingLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DataTemplateSelectorSample002.ViewModels
{
    public class MainViewModel : NotifyPropertyBase
    {
        private ObservableCollection<object> _data;

        public ObservableCollection<object> Data
        {
            get => _data;
            set => SetProperty(ref _data, value);
        }

        public MainViewModel ()
        {
            CreateFakeData();
        }

        private void CreateFakeData()
        {
            Data = new ObservableCollection<object>
            {
                new Person { Name = "John" , Age= 17},
                new Person { Name = "Tom"  , Age=20},
                new Car { Brand = "BMW"  , Color = Colors.LightBlue },
                new Car { Brand = "Benz" , Color = Colors.LightGray },
                new Car { Brand = "Lexus" , Color = Colors.RosyBrown },
                new Person { Name = "Alex" , Age= 25},
                new Person { Name = "Jeff"  , Age=18},
            };
        }
    }
}
