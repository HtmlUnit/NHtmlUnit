// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class DataTransfer : NHtmlUnit.Javascript.SimpleScriptable
   {
      static DataTransfer()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.DataTransfer o) =>
            new DataTransfer(o));
      }

      public DataTransfer(com.gargoylesoftware.htmlunit.javascript.host.html.DataTransfer wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.DataTransfer WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.DataTransfer)WrappedObject; }
      }

      public DataTransfer()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.DataTransfer()) {}

   }


}
