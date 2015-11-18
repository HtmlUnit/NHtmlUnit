// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Console : NHtmlUnit.Javascript.SimpleScriptable
   {
      static Console()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Console o) =>
            new Console(o));
      }

      public Console(com.gargoylesoftware.htmlunit.javascript.host.Console wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Console WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Console)WrappedObject; }
      }

      public Console()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Console()) {}

// Generating method code for dir
      public virtual void Dir(object o)
      {
         WObj.dir(o);
      }

// Generating method code for group
      public virtual void Group()
      {
         WObj.group();
      }

// Generating method code for groupEnd
      public virtual void GroupEnd()
      {
         WObj.groupEnd();
      }

// Generating method code for groupCollapsed
      public virtual void GroupCollapsed()
      {
         WObj.groupCollapsed();
      }

// Generating method code for time
      public virtual void Time(string timerName)
      {
         WObj.time(timerName);
      }

// Generating method code for timeEnd
      public virtual void TimeEnd(string timerName)
      {
         WObj.timeEnd(timerName);
      }

   }


}
