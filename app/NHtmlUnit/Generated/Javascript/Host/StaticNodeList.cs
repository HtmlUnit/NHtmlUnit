// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class StaticNodeList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static StaticNodeList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.StaticNodeList o) =>
            new StaticNodeList(o));
      }

      public StaticNodeList(com.gargoylesoftware.htmlunit.javascript.host.StaticNodeList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.StaticNodeList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.StaticNodeList)WrappedObject; }
      }

      public StaticNodeList(java.util.List elements, net.sourceforge.htmlunit.corejs.javascript.ScriptableObject parentScope)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.StaticNodeList(elements, parentScope)) {}

      public StaticNodeList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.StaticNodeList()) {}


      public System.Int32 Length
      {
         get
         {
            return WObj.getLength();
         }
      }
// Generating method code for item
      public virtual NHtmlUnit.Javascript.Host.Node Item(int index)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Node>(WObj.item(index));
      }

   }


}
