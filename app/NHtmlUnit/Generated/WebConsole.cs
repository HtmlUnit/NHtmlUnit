// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class WebConsole : ObjectWrapper
   {
      static WebConsole()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.WebConsole o) =>
            new WebConsole(o));
      }

      public WebConsole(com.gargoylesoftware.htmlunit.WebConsole wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.WebConsole WObj
      {
         get { return (com.gargoylesoftware.htmlunit.WebConsole)WrappedObject; }
      }

      public WebConsole()
         : this(new com.gargoylesoftware.htmlunit.WebConsole()) {}

// Generating method code for info
      public virtual void Info(System.Object[] args)
      {
         WObj.info(args);
      }

// Generating method code for warn
      public virtual void Warn(System.Object[] args)
      {
         WObj.warn(args);
      }

// Generating method code for error
      public virtual void Error(System.Object[] args)
      {
         WObj.error(args);
      }

// Generating method code for debug
      public virtual void Debug(System.Object[] args)
      {
         WObj.debug(args);
      }

// Generating method code for trace
      public virtual void Trace(System.Object[] args)
      {
         WObj.trace(args);
      }

   }


}
