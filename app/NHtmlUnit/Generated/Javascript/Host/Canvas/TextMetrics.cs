// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class TextMetrics : NHtmlUnit.Javascript.SimpleScriptable
   {
      static TextMetrics()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.TextMetrics o) =>
            new TextMetrics(o));
      }

      public TextMetrics(com.gargoylesoftware.htmlunit.javascript.host.canvas.TextMetrics wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.TextMetrics WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.TextMetrics)WrappedObject; }
      }

      public TextMetrics()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.TextMetrics()) {}

   }


}
