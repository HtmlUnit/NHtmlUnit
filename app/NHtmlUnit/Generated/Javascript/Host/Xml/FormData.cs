// Generated class v2.50.0.0, don't modify

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

      public FormData(object formObj)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.xml.FormData(formObj)) {}

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

// Generating method code for delete_js
      public virtual void Delete_js(string name)
      {
         WObj.delete_js(name);
      }

// Generating method code for getAll
      public virtual net.sourceforge.htmlunit.corejs.javascript.Scriptable GetAll(string name)
      {
         return WObj.getAll(name);
      }

// Generating method code for has
      public virtual bool Has(string name)
      {
         return WObj.has(name);
      }

// Generating method code for set
      public virtual void Set(string name, object value, object filename)
      {
         WObj.set(name, value, filename);
      }

// Generating method code for entries
      public virtual net.sourceforge.htmlunit.corejs.javascript.Scriptable Entries()
      {
         return WObj.entries();
      }

   }


}
