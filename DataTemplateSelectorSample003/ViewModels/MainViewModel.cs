using BindingLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DataTemplateSelectorSample003.ViewModels
{
    public class MainViewModel : NotifyPropertyBase
    {
        private ObservableCollection<Person> _people;
     

        public ObservableCollection<Person> People
        {
            get => _people;
            set => SetProperty(ref _people, value);
        }

        private ObservableCollection<Car> _cars;
        public ObservableCollection<Car> Cars
        {
            get => _cars;
            set => SetProperty(ref _cars, value);
        }


        public MainViewModel ()
        {
            CreateFakeData();
        }

        private void CreateFakeData()
        {
            People = new ObservableCollection<Person>
            {
                new Person { Name = "John" , Age= 17},
                new Person { Name = "Tom"  , Age=20},
                new Person { Name = "Alex" , Age= 25},
                new Person { Name = "Jeff"  , Age=18},
            };


            Cars = new ObservableCollection<Car>
            {
                new Car {Brand = "BMW", Color = Colors.LightBlue},
                new Car {Brand = "Benz", Color = Colors.LightGray},
                new Car {Brand = "Lexus", Color = Colors.RosyBrown},
            };
        }
    }
}
