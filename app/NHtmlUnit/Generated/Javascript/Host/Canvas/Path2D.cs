// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class Path2D : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Path2D()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.Path2D o) =>
            new Path2D(o));
      }

      public Path2D(com.gargoylesoftware.htmlunit.javascript.host.canvas.Path2D wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.Path2D WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.Path2D)WrappedObject; }
      }

      public Path2D()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.Path2D()) {}

   }


}
