using System.ComponentModel;
using System.Drawing.Design;

namespace TelerikPropertyGrid
{
    public class Foo
    {
        public int Id { get; set; }

        [Browsable(true)]
        [Editor(typeof(ColorPropertiesEditor), typeof(UITypeEditor))]
        public string SomeColor { get; set; } 
    }
}
