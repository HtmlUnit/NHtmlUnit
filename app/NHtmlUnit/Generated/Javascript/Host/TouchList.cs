// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class TouchList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static TouchList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.TouchList o) =>
            new TouchList(o));
      }

      public TouchList(com.gargoylesoftware.htmlunit.javascript.host.TouchList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.TouchList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.TouchList)WrappedObject; }
      }

      public TouchList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.TouchList()) {}

   }


}
