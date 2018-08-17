using System;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace TelerikPropertyGrid
{
    public class ColorPropertiesEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            var t = context != null && context.Instance != null;

            return UITypeEditorEditStyle.DropDown;
        }
        public override bool IsDropDownResizable
        {
            get { return true; }
        }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService wfes = provider.GetService(
                typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;

            if (wfes == null) { return value; }
            string tmpValue = string.Empty;
            if (value is string)
            {
                tmpValue = value as string;
            }
            else
            {
                tmpValue = value.ToString();
            }

            UITypeEditorEditStyle editStyle = GetEditStyle(context);
            int cid = 1;
            int.TryParse(tmpValue, out cid);
            //using (WSColorIDPropertyControl control = new WSColorIDPropertyControl(cid, wfes))
            //{
            //    wfes.DropDownControl(control);
            //    cid = control.ColorID;
            //    value = cid.ToString();
            //}

            return value;
        }
        public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context)
        {
            return true;
        }
        public override void PaintValue(PaintValueEventArgs e)
        {
            try
            {
                Color FillColor = Color.BlueViolet;
                ;
                e.Graphics.FillRectangle(new SolidBrush(FillColor), e.Bounds);
            }
            catch (Exception)
            {
            }
        }
    }
}
