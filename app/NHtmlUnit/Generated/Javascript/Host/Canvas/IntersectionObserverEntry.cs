// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class IntersectionObserverEntry : NHtmlUnit.Javascript.SimpleScriptable
   {
      static IntersectionObserverEntry()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.IntersectionObserverEntry o) =>
            new IntersectionObserverEntry(o));
      }

      public IntersectionObserverEntry(com.gargoylesoftware.htmlunit.javascript.host.canvas.IntersectionObserverEntry wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.IntersectionObserverEntry WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.IntersectionObserverEntry)WrappedObject; }
      }

      public IntersectionObserverEntry()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.IntersectionObserverEntry()) {}

   }


}
