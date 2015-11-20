// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class ProcessingInstruction : NHtmlUnit.Javascript.Host.Dom.CharacterData
   {
      static ProcessingInstruction()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.ProcessingInstruction o) =>
            new ProcessingInstruction(o));
      }

      public ProcessingInstruction(com.gargoylesoftware.htmlunit.javascript.host.dom.ProcessingInstruction wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.ProcessingInstruction WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.ProcessingInstruction)WrappedObject; }
      }

      public ProcessingInstruction()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.ProcessingInstruction()) {}


      public System.String Target
      {
         get
         {
            return WObj.getTarget();
         }
      }
   }


}
