using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikPropertyGrid
{
    public class Foo
    {
        public int Id { get; set; }

        [Browsable(true)]
        [Editor(typeof(UiImagePropertiesEditor), typeof(UITypeEditor))]
        //[TypeConverter(typeof(ImageTypeConverter))]
        public Color SomeColor { get; set; } = Color.Blue;
    }
}
