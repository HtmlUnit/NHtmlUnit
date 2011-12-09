// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Background
{
   public partial class JavaScriptJob : ObjectWrapper
   {
      static JavaScriptJob()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.background.JavaScriptJob o) =>
            new JavaScriptJob(o));
      }

      public JavaScriptJob(com.gargoylesoftware.htmlunit.javascript.background.JavaScriptJob wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.javascript.background.JavaScriptJob WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.background.JavaScriptJob)WrappedObject; }
      }


      public System.Int64 TargetExecutionTime
      {
         get
         {
            return WObj.getTargetExecutionTime();
         }
         set
         {
            WObj.setTargetExecutionTime(value);
         }

      }

      public java.lang.Integer Id
      {
         get
         {
            return WObj.getId();
         }
         set
         {
            WObj.setId(value);
         }

      }

      public System.Int32 InitialDelay
      {
         get
         {
            return WObj.getInitialDelay();
         }
      }

      public java.lang.Integer Period
      {
         get
         {
            return WObj.getPeriod();
         }
      }
// Generating method code for compareTo
      public virtual int CompareTo(NHtmlUnit.Javascript.Background.JavaScriptJob other)
      {
         return WObj.compareTo((com.gargoylesoftware.htmlunit.javascript.background.JavaScriptJob)other.WrappedObject);
      }

// Generating method code for isPeriodic
      public virtual bool IsPeriodic()
      {
         return WObj.isPeriodic();
      }

// Generating method code for compareTo
      public virtual int CompareTo(object x0)
      {
         return WObj.compareTo(x0);
      }

// Generating method code for run
      public virtual void Run()
      {
         WObj.run();
      }

   }


}
