// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Text : NHtmlUnit.Javascript.Host.CharacterDataImpl
   {
      static Text()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Text o) =>
            new Text(o));
      }

      public Text(com.gargoylesoftware.htmlunit.javascript.host.Text wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Text WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Text)WrappedObject; }
      }

      public Text()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Text()) {}


      public System.String WholeText
      {
         get
         {
            return WObj.getWholeText();
         }
      }
// Generating method code for initialize
      public virtual void Initialize()
      {
         WObj.initialize();
      }

// Generating method code for splitText
      public virtual object SplitText(int offset)
      {
         return WObj.splitText(offset);
      }

   }


}
