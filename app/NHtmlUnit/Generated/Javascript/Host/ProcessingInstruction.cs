// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class ProcessingInstruction : NHtmlUnit.Javascript.Host.Node
   {
      static ProcessingInstruction()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.ProcessingInstruction o) =>
            new ProcessingInstruction(o));
      }

      public ProcessingInstruction(com.gargoylesoftware.htmlunit.javascript.host.ProcessingInstruction wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.ProcessingInstruction WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.ProcessingInstruction)WrappedObject; }
      }

      public ProcessingInstruction()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.ProcessingInstruction()) {}

// Generating method code for jsxGet_target
      public virtual string JsxGet_target()
      {
         return WObj.jsxGet_target();
      }

// Generating method code for jsxGet_data
      public virtual string JsxGet_data()
      {
         return WObj.jsxGet_data();
      }

// Generating method code for jsxSet_data
      public virtual void JsxSet_data(string data)
      {
         WObj.jsxSet_data(data);
      }

   }


}
