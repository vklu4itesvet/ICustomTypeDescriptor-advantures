using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;

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
            var customizedProps = new PropertyDescriptorCollection(null);

            for (int i = 0; i < this.List.Count; i++)
            {
                var foo = this[i];
                var smColorPd = new ObjectBrowserPropertyDescriptor(foo, TypeDescriptor.GetProperties(foo)[1]);
                var anthrColorPd = new ObjectBrowserPropertyDescriptor(foo, TypeDescriptor.GetProperties(foo)[2]);
                customizedProps.Add(smColorPd);
                customizedProps.Add(anthrColorPd);
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
        private readonly Foo _foo;
        private readonly PropertyDescriptor _propertyDescriptor;

        public ObjectBrowserPropertyDescriptor(Foo foo, PropertyDescriptor pd) : base("#" + foo.Id.ToString(), null)
        {
            _foo = foo;
            _propertyDescriptor = pd;
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
            return _propertyDescriptor.Name == nameof(_foo.SomeColor) ? (object)_foo.SomeColor : (object)_foo.AnotherColor;
        }

        public override Type PropertyType
        {
            get { return _propertyDescriptor.GetType(); }
        }

        public override AttributeCollection Attributes
        {
            get
            {
                return _propertyDescriptor.Attributes;
            }
        }

        public override string Description
        {
            get
            {
                return "PropertyDescriptor.Description";
            }
        }

        public override bool CanResetValue(object component)
        {
            return _propertyDescriptor.CanResetValue(component);
        }

        public override Type ComponentType
        {
            get
            {
                return _propertyDescriptor.ComponentType;
            }
        }

        public override bool IsReadOnly
        {
            get { return _propertyDescriptor.IsReadOnly; }
        }

        public override string Name
        {
            get { return _propertyDescriptor.Name; }
        }

        public override void ResetValue(object component)
        {
            _propertyDescriptor.ResetValue(component);
        }

        public override void SetValue(object component, object value)
        {
            _propertyDescriptor.SetValue(_foo, value);
        }

        public override bool ShouldSerializeValue(object component)
        {
            return _propertyDescriptor.ShouldSerializeValue(component);
        }
    }
}