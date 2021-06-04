// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSMediaRule : NHtmlUnit.Javascript.Host.Css.CSSConditionRule
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

      public CSSMediaRule()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSMediaRule()) {}


      public NHtmlUnit.Javascript.Host.Dom.MediaList Media
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.MediaList>(
               WObj.getMedia());
         }
      }

   }


}
