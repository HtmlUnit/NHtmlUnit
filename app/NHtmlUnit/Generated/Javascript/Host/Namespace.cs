// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Namespace : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Namespace()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Namespace o) =>
            new Namespace(o));
      }

      public Namespace(com.gargoylesoftware.htmlunit.javascript.host.Namespace wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Namespace WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Namespace)WrappedObject; }
      }

      public Namespace(net.sourceforge.htmlunit.corejs.javascript.ScriptableObject parentScope, string name, string urn)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Namespace(parentScope, name, urn)) {}

// Generating method code for jsxGet_name
      public virtual string JsxGet_name()
      {
         return WObj.jsxGet_name();
      }

// Generating method code for jsxGet_urn
      public virtual string JsxGet_urn()
      {
         return WObj.jsxGet_urn();
      }

// Generating method code for jsxSet_urn
      public virtual void JsxSet_urn(string urn)
      {
         WObj.jsxSet_urn(urn);
      }

   }


}
