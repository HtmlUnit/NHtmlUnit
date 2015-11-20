// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript
{
   public partial class PostponedAction : ObjectWrapper
   {
      static PostponedAction()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.PostponedAction o) =>
            new PostponedAction(o));
      }

      public PostponedAction(com.gargoylesoftware.htmlunit.javascript.PostponedAction wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.javascript.PostponedAction WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.PostponedAction)WrappedObject; }
      }

// Generating method code for execute
      public virtual void Execute()
      {
         WObj.execute();
      }

// Generating method code for isStillAlive
      public virtual bool IsStillAlive()
      {
         return WObj.isStillAlive();
      }

   }


}
