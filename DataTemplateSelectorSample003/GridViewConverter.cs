using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace DataTemplateSelectorSample003
{
    public class GridViewConverter : IValueConverter
    {
        public string Path { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var source = new ResourceDictionary { Source = new Uri(Path, UriKind.RelativeOrAbsolute) };
            if (value == null)
            {
                return null;
            }

            var type = value.GetType();
            if (!type.IsGenericType)
            {
                return null;
            }

            var itemType = type.GetGenericArguments().Last();
            var gridView = new GridView();
            foreach (var p in itemType.GetProperties())
            {
                var column = new GridViewColumn();
                var attribute = p.GetCustomAttribute<DescriptionAttribute>();
                if (attribute != null && source.Contains(attribute.Description))
                {
                    var template = source[attribute.Description] as DataTemplate;
                    column.CellTemplate = template;
                    Debug.WriteLine(template?.DataTemplateKey);
                }
                gridView.Columns.Add(column);
            }

            return gridView;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
