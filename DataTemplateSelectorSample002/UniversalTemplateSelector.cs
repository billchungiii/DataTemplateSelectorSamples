using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace DataTemplateSelectorSample002
{
    public class UniversalTemplateSelector : DataTemplateSelector
    {
        public string Path { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {            
            var source = new ResourceDictionary { Source = new Uri(Path, UriKind.RelativeOrAbsolute) };
            var attribute = item?.GetType().GetCustomAttribute<DescriptionAttribute>();
            if (attribute != null && source.Contains(attribute.Description))
            {
                return source[attribute.Description] as DataTemplate;
            }
            return null;
        }
    }
}
