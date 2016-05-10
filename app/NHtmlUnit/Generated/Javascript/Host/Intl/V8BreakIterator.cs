// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Intl
{
   public partial class V8BreakIterator : NHtmlUnit.Javascript.SimpleScriptable
   {
      static V8BreakIterator()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.intl.V8BreakIterator o) =>
            new V8BreakIterator(o));
      }

      public V8BreakIterator(com.gargoylesoftware.htmlunit.javascript.host.intl.V8BreakIterator wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.intl.V8BreakIterator WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.intl.V8BreakIterator)WrappedObject; }
      }

      public V8BreakIterator()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.intl.V8BreakIterator()) {}

      public V8BreakIterator(object locales, object types)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.intl.V8BreakIterator(locales, types)) {}

// Generating method code for current
      public virtual int Current()
      {
         return WObj.current();
      }

// Generating method code for first
      public virtual int First()
      {
         return WObj.first();
      }

// Generating method code for next
      public virtual int Next()
      {
         return WObj.next();
      }

// Generating method code for resolvedOptions
      public virtual object ResolvedOptions()
      {
         return WObj.resolvedOptions();
      }

// Generating method code for adoptText
      public virtual void AdoptText(string text)
      {
         WObj.adoptText(text);
      }

// Generating method code for breakType
      public virtual string BreakType()
      {
         return WObj.breakType();
      }

   }


}
