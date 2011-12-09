// Generated class v4, don't modify

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

// Generating method code for initialize
      public virtual void Initialize()
      {
         WObj.initialize();
      }

// Generating method code for jsxFunction_splitText
      public virtual object JsxFunction_splitText(int offset)
      {
         return WObj.jsxFunction_splitText(offset);
      }

   }


}
