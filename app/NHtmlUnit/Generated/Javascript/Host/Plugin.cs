// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Plugin : NHtmlUnit.Javascript.Host.SimpleArray, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static Plugin()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Plugin o) =>
            new Plugin(o));
      }

      public Plugin(com.gargoylesoftware.htmlunit.javascript.host.Plugin wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Plugin WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Plugin)WrappedObject; }
      }

      public Plugin(string name, string description, string filename)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Plugin(name, description, filename)) {}

      public Plugin()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Plugin()) {}

// Generating method code for jsxGet_description
      public virtual string JsxGet_description()
      {
         return WObj.jsxGet_description();
      }

// Generating method code for jsxGet_filename
      public virtual string JsxGet_filename()
      {
         return WObj.jsxGet_filename();
      }

// Generating method code for jsxGet_name
      public virtual string JsxGet_name()
      {
         return WObj.jsxGet_name();
      }

   }


}
