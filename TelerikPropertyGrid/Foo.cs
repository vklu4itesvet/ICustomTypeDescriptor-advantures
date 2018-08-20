using System.ComponentModel;
using System.Drawing.Design;

namespace TelerikPropertyGrid
{
    public class Foo
    {
        private string _someColor;

        public int Id { get; set; }

        [Browsable(true)]
        [Editor(typeof(ColorPropertiesEditor), typeof(UITypeEditor))]
        public string SomeColor
        {
            get
            {
                return _someColor;
            }

            set
            {
                _someColor = value;
            }
        }
    }
}
