﻿using System;
using System.Drawing;

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

            var fooProperties = new FooProperties();
            fooProperties.Add(new Foo { Id = 1, SomeColor = Color.Blue.ToArgb().ToString(), AnotherColor = Color.DarkBlue.ToArgb() });
            fooProperties.Add(new Foo { Id = 2, SomeColor = Color.Orange.ToArgb().ToString(), AnotherColor = Color.Red.ToArgb() });

            propertyGridWinForms.SelectedObject = fooProperties;
            propertyGridTelerik.SelectedObject = fooProperties;

            //propertyGridTelerik.SelectedObject = new Foo { Id = 2, SomeColor = Color.Orange };
        }
    }
}
