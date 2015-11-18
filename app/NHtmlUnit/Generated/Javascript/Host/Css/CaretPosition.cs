// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class CaretPosition : NHtmlUnit.Javascript.SimpleScriptable
   {
      static CaretPosition()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.CaretPosition o) =>
            new CaretPosition(o));
      }

      public CaretPosition(com.gargoylesoftware.htmlunit.javascript.host.css.CaretPosition wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.CaretPosition WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.CaretPosition)WrappedObject; }
      }

      public CaretPosition()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.CaretPosition()) {}

   }


}
