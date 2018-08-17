using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;

namespace TelerikPropertyGrid
{
    public class Foo
    {
        public int Id { get; set; }

        [Browsable(true)]
        [Editor(typeof(UiImagePropertiesEditor), typeof(UITypeEditor))]
        public Color SomeColor { get; set; } = Color.Blue;
    }
}
