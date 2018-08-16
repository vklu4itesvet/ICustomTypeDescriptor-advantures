using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TelerikPropertyGrid
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //this.propertyGrid.SelectedObject = new Foo();

            var fooProperties = new FooProperties();
            fooProperties.Add(new Foo { Id = 1, SomeColor = Color.Blue });
            fooProperties.Add(new Foo { Id = 2, SomeColor = Color.Orange });

            propertyGridWinForms.SelectedObject = fooProperties;
            propertyGridTelerik.SelectedObject = fooProperties;
        }
    }
}
