// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.File
{
   public partial class DataTransferItemList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static DataTransferItemList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.file.DataTransferItemList o) =>
            new DataTransferItemList(o));
      }

      public DataTransferItemList(com.gargoylesoftware.htmlunit.javascript.host.file.DataTransferItemList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.file.DataTransferItemList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.file.DataTransferItemList)WrappedObject; }
      }

      public DataTransferItemList()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.file.DataTransferItemList()) {}

   }


}
