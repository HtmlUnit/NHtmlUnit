// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.File
{
   public partial class DataTransferItem : NHtmlUnit.Javascript.SimpleScriptable
   {
      static DataTransferItem()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.file.DataTransferItem o) =>
            new DataTransferItem(o));
      }

      public DataTransferItem(com.gargoylesoftware.htmlunit.javascript.host.file.DataTransferItem wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.file.DataTransferItem WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.file.DataTransferItem)WrappedObject; }
      }

      public DataTransferItem()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.DataTransferItem()) {}

   }


}
