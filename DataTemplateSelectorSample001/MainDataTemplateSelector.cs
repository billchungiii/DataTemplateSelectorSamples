using DataTemplateSelectorSample001.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DataTemplateSelectorSample001
{
    public class MainDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {            
            if (container is FrameworkElement element)
            {
                if (item is Person)
                {
                    return GetTemplate("personTemplate");
                }

                if (item is Car)
                {
                    return GetTemplate("carTemplate");
                }
            }         
            return null;


            DataTemplate GetTemplate(string name)
            {
                return element.FindResource(name) as DataTemplate;
            }
        }
    }
}
