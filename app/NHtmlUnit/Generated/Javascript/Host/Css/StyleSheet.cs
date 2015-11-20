// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class StyleSheet : NHtmlUnit.Javascript.SimpleScriptable
   {
      static StyleSheet()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.StyleSheet o) =>
            new StyleSheet(o));
      }

      public StyleSheet(com.gargoylesoftware.htmlunit.javascript.host.css.StyleSheet wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.StyleSheet WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.StyleSheet)WrappedObject; }
      }

      public StyleSheet()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.StyleSheet()) {}

   }


}
