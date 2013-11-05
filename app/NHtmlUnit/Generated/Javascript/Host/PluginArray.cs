// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class PluginArray : NHtmlUnit.Javascript.Host.SimpleArray, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static PluginArray()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.PluginArray o) =>
            new PluginArray(o));
      }

      public PluginArray(com.gargoylesoftware.htmlunit.javascript.host.PluginArray wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.PluginArray WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.PluginArray)WrappedObject; }
      }

      public PluginArray()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.PluginArray()) {}

// Generating method code for refresh
      public virtual void Refresh(bool reloadDocuments)
      {
         WObj.refresh(reloadDocuments);
      }

   }


}
