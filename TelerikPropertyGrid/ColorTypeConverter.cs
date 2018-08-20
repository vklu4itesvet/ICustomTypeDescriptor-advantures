using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

namespace TelerikPropertyGrid
{
    public class ColorTypeConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string)
              ? true
              : base.CanConvertTo(context, destinationType);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string)
              ? true
              : base.CanConvertTo(context, sourceType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
                return Color.FromArgb((int)value).ToKnownColor().ToString();
            else
                return base.ConvertTo(value, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            return value is string
              ? Color.FromKnownColor(((KnownColor)(Enum.Parse(typeof(KnownColor), value as string)))).ToArgb()
              : base.ConvertFrom(context, culture, value);
        }
    }
}
