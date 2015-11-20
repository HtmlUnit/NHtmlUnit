// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class Text : NHtmlUnit.Javascript.Host.Dom.CharacterData
   {
      static Text()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.Text o) =>
            new Text(o));
      }

      public Text(com.gargoylesoftware.htmlunit.javascript.host.dom.Text wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.Text WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.Text)WrappedObject; }
      }

      public Text()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.Text()) {}


      public System.String WholeText
      {
         get
         {
            return WObj.getWholeText();
         }
      }
// Generating method code for splitText
      public virtual object SplitText(int offset)
      {
         return WObj.splitText(offset);
      }

// Generating method code for getText
      public virtual object GetText()
      {
         return WObj.getText();
      }

   }


}
