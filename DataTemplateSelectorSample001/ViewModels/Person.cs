using BindingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DataTemplateSelectorSample001.ViewModels
{
    public class Person : NotifyPropertyBase
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }


        private int _age;
        public int Age
        {
            get => _age;
            set => SetProperty(ref _age, value);
        }
    }


    public class Car : NotifyPropertyBase
    {
        private string _brand;
       
        public string Brand
        {
            get => _brand;
            set => SetProperty(ref _brand, value);
        }

        private Color _color;
        public Color Color 
        {
            get => _color; 
            set => SetProperty(ref _color , value); 
        }
    }
}
