// Generated class v2.14.0.0, don't modify

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


      public System.String Target
      {
         get
         {
            return WObj.getTarget();
         }
      }

      public System.String Data
      {
         get
         {
            return WObj.getData();
         }
         set
         {
            WObj.setData(value);
         }

      }
   }


}
