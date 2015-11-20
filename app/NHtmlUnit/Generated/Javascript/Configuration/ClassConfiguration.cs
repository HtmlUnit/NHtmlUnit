// Generated class v2.19.0.0, don't modify

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

      public ClassConfiguration(java.lang.Class hostClass, java.lang.Class[] domClasses, bool jsObject, bool definedInStandardsMode, string className)
         : this(new com.gargoylesoftware.htmlunit.javascript.configuration.ClassConfiguration(hostClass, domClasses, jsObject, definedInStandardsMode, className)) {}


      public System.String ClassName
      {
         get
         {
            return WObj.getClassName();
         }
      }

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

      public ICollection<System.Object> PropertyEntries
      {
         get
         {
            return new ShallowCollectionWrapper<System.Object>(
               WObj.getPropertyEntries());
         }
       }

      public ICollection<System.Object> FunctionEntries
      {
         get
         {
            return new ShallowCollectionWrapper<System.Object>(
               WObj.getFunctionEntries());
         }
       }

      public ICollection<System.Object> StaticPropertyEntries
      {
         get
         {
            return new ShallowCollectionWrapper<System.Object>(
               WObj.getStaticPropertyEntries());
         }
       }

      public ICollection<System.Object> StaticFunctionEntries
      {
         get
         {
            return new ShallowCollectionWrapper<System.Object>(
               WObj.getStaticFunctionEntries());
         }
       }

      public ICollection<System.String> FunctionKeys
      {
         get
         {
            return new ShallowCollectionWrapper<System.String>(
               WObj.getFunctionKeys());
         }
       }

      public System.String HostClassSimpleName
      {
         get
         {
            return WObj.getHostClassSimpleName();
         }
      }

      public java.lang.reflect.Member JsConstructor
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

// Generating method code for addStaticProperty
      public virtual void AddStaticProperty(string name, java.lang.reflect.Method getter, java.lang.reflect.Method setter)
      {
         WObj.addStaticProperty(name, getter, setter);
      }

// Generating method code for addStaticFunction
      public virtual void AddStaticFunction(java.lang.reflect.Method method)
      {
         WObj.addStaticFunction(method);
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

// Generating method code for isDefinedInStandardsMode
      public virtual bool IsDefinedInStandardsMode()
      {
         return WObj.isDefinedInStandardsMode();
      }

   }


}
