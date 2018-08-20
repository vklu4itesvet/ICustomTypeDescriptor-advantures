using System;
using System.Drawing;
using System.Drawing.Design;

namespace TelerikPropertyGrid
{
    public class ColorPropertiesEditor : UITypeEditor
    {
        public override bool IsDropDownResizable
        {
            get { return true; }
        }

        public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            return Color.Green.ToArgb();
        }
        public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context)
        {
            return true;
        }

        public override void PaintValue(PaintValueEventArgs e)
        {
            var fillColor = Color.FromArgb(int.Parse(e.Value.ToString()));
            using (var brush = new SolidBrush(fillColor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }
        }
    }
}
