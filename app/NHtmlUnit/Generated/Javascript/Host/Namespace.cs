// Generated class v2.13.0.0, don't modify

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


      public System.String Name
      {
         get
         {
            return WObj.getName();
         }
      }

      public System.String Urn
      {
         get
         {
            return WObj.getUrn();
         }
         set
         {
            WObj.setUrn(value);
         }

      }
   }


}
