// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Xml
{
   public partial class FormData : NHtmlUnit.Javascript.SimpleScriptable
   {
      static FormData()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.xml.FormData o) =>
            new FormData(o));
      }

      public FormData(com.gargoylesoftware.htmlunit.javascript.host.xml.FormData wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.xml.FormData WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.xml.FormData)WrappedObject; }
      }

      public FormData()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.xml.FormData()) {}

// Generating method code for fillRequest
      public virtual void FillRequest(NHtmlUnit.WebRequest webRequest)
      {
         WObj.fillRequest((com.gargoylesoftware.htmlunit.WebRequest)webRequest.WrappedObject);
      }

// Generating method code for append
      public virtual void Append(string name, object value, object filename)
      {
         WObj.append(name, value, filename);
      }

   }


}
