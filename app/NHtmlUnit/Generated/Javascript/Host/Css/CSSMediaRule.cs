// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSMediaRule : NHtmlUnit.Javascript.Host.Css.CSSRule
   {
      static CSSMediaRule()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSMediaRule o) =>
            new CSSMediaRule(o));
      }

      public CSSMediaRule(com.gargoylesoftware.htmlunit.javascript.host.css.CSSMediaRule wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSMediaRule WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSMediaRule)WrappedObject; }
      }

// Generating method code for jsxGet_media
      public virtual NHtmlUnit.Javascript.Host.MediaList JsxGet_media()
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.MediaList>(WObj.jsxGet_media());
      }

   }


}
