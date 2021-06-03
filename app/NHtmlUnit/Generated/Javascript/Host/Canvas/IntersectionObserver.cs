// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class IntersectionObserver : NHtmlUnit.Javascript.SimpleScriptable
   {
      static IntersectionObserver()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.IntersectionObserver o) =>
            new IntersectionObserver(o));
      }

      public IntersectionObserver(com.gargoylesoftware.htmlunit.javascript.host.canvas.IntersectionObserver wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.IntersectionObserver WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.IntersectionObserver)WrappedObject; }
      }

      public IntersectionObserver()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.IntersectionObserver()) {}

// Generating method code for observe
      public virtual void Observe(NHtmlUnit.Javascript.Host.Element target)
      {
         WObj.observe((com.gargoylesoftware.htmlunit.javascript.host.Element)target.WrappedObject);
      }

// Generating method code for unobserve
      public virtual void Unobserve(NHtmlUnit.Javascript.Host.Element target)
      {
         WObj.unobserve((com.gargoylesoftware.htmlunit.javascript.host.Element)target.WrappedObject);
      }

// Generating method code for disconnect
      public virtual void Disconnect()
      {
         WObj.disconnect();
      }

// Generating method code for takeRecords
      public virtual object TakeRecords()
      {
         var arg = WObj.takeRecords();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

   }


}
