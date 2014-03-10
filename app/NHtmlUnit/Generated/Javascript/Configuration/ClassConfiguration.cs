// Generated class v2.14.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Configuration
{
   public partial class ClassConfiguration : ObjectWrapper
   {
      static ClassConfiguration()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.configuration.ClassConfiguration o) =>
            new ClassConfiguration(o));
      }

      public ClassConfiguration(com.gargoylesoftware.htmlunit.javascript.configuration.ClassConfiguration wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.javascript.configuration.ClassConfiguration WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.configuration.ClassConfiguration)WrappedObject; }
      }

      public ClassConfiguration(java.lang.Class hostClass, java.lang.Class[] domClasses, bool jsObject)
         : this(new com.gargoylesoftware.htmlunit.javascript.configuration.ClassConfiguration(hostClass, domClasses, jsObject)) {}


      public java.lang.Class HostClass
      {
         get
         {
            return WObj.getHostClass();
         }
      }

      public java.lang.Class[] DomClasses
      {
         get
         {
            return WObj.getDomClasses();
         }
      }

      public System.String ExtendedClassName
      {
         get
         {
            return WObj.getExtendedClassName();
         }
      }

      public java.lang.reflect.Method JsConstructor
      {
         get
         {
            return WObj.getJsConstructor();
         }
      }
// Generating method code for addFunction
      public virtual void AddFunction(java.lang.reflect.Method method)
      {
         WObj.addFunction(method);
      }

// Generating method code for addConstant
      public virtual void AddConstant(string name)
      {
         WObj.addConstant(name);
      }

// Generating method code for addProperty
      public virtual void AddProperty(string name, java.lang.reflect.Method getter, java.lang.reflect.Method setter)
      {
         WObj.addProperty(name, getter, setter);
      }

// Generating method code for isJsObject
      public virtual bool IsJsObject()
      {
         return WObj.isJsObject();
      }

// Generating method code for propertyEntries
      public virtual ICollection<System.Object> PropertyEntries()
      {

         return new ShallowCollectionWrapper<System.Object>(WObj.propertyEntries());
      }

// Generating method code for functionEntries
      public virtual ICollection<System.Object> FunctionEntries()
      {

         return new ShallowCollectionWrapper<System.Object>(WObj.functionEntries());
      }

// Generating method code for constants
      public virtual IList<System.String> Constants()
      {

         return new ShallowListWrapper<System.String>(WObj.constants());
      }

// Generating method code for functionKeys
      public virtual ICollection<System.String> FunctionKeys()
      {

         return new ShallowCollectionWrapper<System.String>(WObj.functionKeys());
      }

   }


}
