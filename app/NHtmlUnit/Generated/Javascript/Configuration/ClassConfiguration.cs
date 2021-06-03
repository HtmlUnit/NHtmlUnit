// Generated class v2.50.0.0, don't modify

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

      public ClassConfiguration(java.lang.Class hostClass, java.lang.Class[] domClasses, bool jsObject, string className, string extendedClassName)
         : this(new com.gargoylesoftware.htmlunit.javascript.configuration.ClassConfiguration(hostClass, domClasses, jsObject, className, extendedClassName)) {}


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

      public java.util.Map PropertyMap
      {
         get
         {
            return WObj.getPropertyMap();
         }
      }

      public java.util.Map FunctionMap
      {
         get
         {
            return WObj.getFunctionMap();
         }
      }

      public java.util.Map SymbolMap
      {
         get
         {
            return WObj.getSymbolMap();
         }
      }

      public java.util.Map StaticPropertyMap
      {
         get
         {
            return WObj.getStaticPropertyMap();
         }
      }

      public java.util.Map StaticFunctionMap
      {
         get
         {
            return WObj.getStaticFunctionMap();
         }
      }

      public System.String HostClassSimpleName
      {
         get
         {
            return WObj.getHostClassSimpleName();
         }
      }

      public java.lang.reflect.Executable JsConstructor
      {
         get
         {
            return WObj.getJsConstructor();
         }
      }
// Generating method code for addSymbol
      public virtual void AddSymbol(net.sourceforge.htmlunit.corejs.javascript.Symbol symbol, java.lang.reflect.Method method)
      {
         WObj.addSymbol(symbol, method);
      }

// Generating method code for addFunction
      public virtual void AddFunction(string name, java.lang.reflect.Method method)
      {
         WObj.addFunction(name, method);
      }

// Generating method code for addStaticProperty
      public virtual void AddStaticProperty(string name, java.lang.reflect.Method getter, java.lang.reflect.Method setter)
      {
         WObj.addStaticProperty(name, getter, setter);
      }

// Generating method code for addStaticFunction
      public virtual void AddStaticFunction(string name, java.lang.reflect.Method method)
      {
         WObj.addStaticFunction(name, method);
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

   }


}
