// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class Plugin : NHtmlUnit.Javascript.Host.SimpleArray, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static Plugin()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.Plugin o) =>
            new Plugin(o));
      }

      public Plugin(com.gargoylesoftware.htmlunit.javascript.host.Plugin wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.Plugin WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.Plugin)WrappedObject; }
      }

      public Plugin()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Plugin()) {}

      public Plugin(string name, string description, string filename)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.Plugin(name, description, filename)) {}


      public System.String Description
      {
         get
         {
            return WObj.getDescription();
         }
      }

      public System.String Filename
      {
         get
         {
            return WObj.getFilename();
         }
      }

      public System.String Name
      {
         get
         {
            return WObj.getName();
         }
      }
   }


}
