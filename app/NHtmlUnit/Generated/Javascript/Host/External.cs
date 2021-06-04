// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class External : NHtmlUnit.Javascript.SimpleScriptable
   {
      static External()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.External o) =>
            new External(o));
      }

      public External(com.gargoylesoftware.htmlunit.javascript.host.External wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.External WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.External)WrappedObject; }
      }

      public External()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.External()) {}

// Generating method code for autoCompleteSaveForm
      public virtual void AutoCompleteSaveForm()
      {
         WObj.autoCompleteSaveForm();
      }

// Generating method code for addSearchProvider
      public virtual void AddSearchProvider()
      {
         WObj.addSearchProvider();
      }

// Generating method code for isSearchProviderInstalled
      public virtual object IsSearchProviderInstalled()
      {
         var arg = WObj.isSearchProviderInstalled();
         return ObjectWrapper.CreateWrapper<object>(arg);
      }

   }


}
