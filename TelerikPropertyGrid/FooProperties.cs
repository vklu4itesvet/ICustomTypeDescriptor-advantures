using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikPropertyGrid
{
    public class FooProperties : CollectionBase, ICustomTypeDescriptor
    {
        #region CollectionBase

        public void Add(Foo emp)
        {
            this.List.Add(emp);
        }
        public void Remove(Foo emp)
        {
            this.List.Remove(emp);
        }
        public Foo this[int index]
        {
            get
            {
                return (Foo)this.List[index];
            }
        }

        #endregion

        #region ICustomTypeDescriptor

        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            return GetProperties();
        }

        public PropertyDescriptorCollection GetProperties()
        {
            var standartProps = TypeDescriptor.GetProperties(this[0]);
            var customizedProps = new PropertyDescriptorCollection(null);

            for (int i = 0; i < this.List.Count; i++)
            {
                // For each employee create a property descriptor 
                // and add it to the 
                // PropertyDescriptorCollection instance
                var p = standartProps[i];
                var pd = new ObjectBrowserPropertyDescriptor(this[i]);
                customizedProps.Add(pd);
            }

            return customizedProps;
        }

        public String GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        public String GetComponentName()
        {
            return TypeDescriptor.GetComponentName(this, true);
        }

        public TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        #endregion
    }

    public class ObjectBrowserPropertyDescriptor : PropertyDescriptor
    {
        private readonly Foo _foo = null;

        public ObjectBrowserPropertyDescriptor(Foo foo) : base("#" + foo.Id.ToString(), null)
        {
            _foo = foo;
        }






        public override string DisplayName
        {
            get
            {
                return _foo.Id.ToString();
            }
        }

        public override object GetValue(object component)
        {
            return _foo.SomeColor;
        }

        public override Type PropertyType
        {
            get { return _foo.SomeColor.GetType(); }
        }






        public override string Description
        {
            get
            {
                return _foo.SomeColor.ToString();
            }
        }

        public override AttributeCollection Attributes
        {
            get
            {
                return new AttributeCollection(null);
            }
        }

        public override bool CanResetValue(object component)
        {
            return true;
        }

        public override Type ComponentType
        {
            get
            {
                return _foo.GetType();
            }
        }

        public override bool IsReadOnly
        {
            get { return true; }
        }

        public override string Name
        {
            get { return "#" + _foo.ToString(); }
        }

        public override void ResetValue(object component) { }

        public override void SetValue(object component, object value)
        {
           
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }
    }

}
