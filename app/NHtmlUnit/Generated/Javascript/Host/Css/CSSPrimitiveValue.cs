// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CSSPrimitiveValue : NHtmlUnit.Javascript.Host.Css.CSSValue
   {
      static CSSPrimitiveValue()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CSSPrimitiveValue o) =>
            new CSSPrimitiveValue(o));
      }

      public CSSPrimitiveValue(com.gargoylesoftware.htmlunit.javascript.host.css.CSSPrimitiveValue wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CSSPrimitiveValue WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CSSPrimitiveValue)WrappedObject; }
      }

      public CSSPrimitiveValue()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CSSPrimitiveValue()) {}

// Generating method code for getFloatValue
      public virtual System.Double GetFloatValue(int unitType)
      {
         return WObj.getFloatValue(unitType);
      }

   }


}
