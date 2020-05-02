using BindingLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DataTemplateSelectorSample003.ViewModels
{
   
    public class Person : NotifyPropertyBase
    {
        private string _name;

        [Description("personNameTemplate")]
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

      
        private int _age;
        [Description("personAgeTemplate")]
        public int Age
        {
            get => _age;
            set => SetProperty(ref _age, value);
        }
    }

    
    public class Car : NotifyPropertyBase
    {
        private string _brand;

        [Description("carBrandTemplate")]
        public string Brand
        {
            get => _brand;
            set => SetProperty(ref _brand, value);
        }

        private Color _color;
        [Description("carColorTemplate")]
        public Color Color 
        {
            get => _color; 
            set => SetProperty(ref _color , value); 
        }
    }
}
