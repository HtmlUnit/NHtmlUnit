// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript
{
   public partial class HtmlUnitScriptable : ObjectWrapper
   {
      static HtmlUnitScriptable()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.HtmlUnitScriptable o) =>
            new HtmlUnitScriptable(o));
      }

      public HtmlUnitScriptable(com.gargoylesoftware.htmlunit.javascript.HtmlUnitScriptable wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.javascript.HtmlUnitScriptable WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.HtmlUnitScriptable)WrappedObject; }
      }

      public HtmlUnitScriptable()
         : this(new com.gargoylesoftware.htmlunit.javascript.HtmlUnitScriptable()) {}

   }


}
