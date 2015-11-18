// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class MimeType : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MimeType()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.MimeType o) =>
            new MimeType(o));
      }

      public MimeType(com.gargoylesoftware.htmlunit.javascript.host.MimeType wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.MimeType WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.MimeType)WrappedObject; }
      }

      public MimeType()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.MimeType()) {}

      public MimeType(string type, string description, string suffixes, NHtmlUnit.Javascript.Host.Plugin plugin)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.MimeType(type, description, suffixes, (com.gargoylesoftware.htmlunit.javascript.host.Plugin)plugin.WrappedObject)) {}


      public System.String Description
      {
         get
         {
            return WObj.getDescription();
         }
      }

      public System.String Suffixes
      {
         get
         {
            return WObj.getSuffixes();
         }
      }

      public System.String Type
      {
         get
         {
            return WObj.getType();
         }
      }

      public System.Object EnabledPlugin
      {
         get
         {
            return WObj.getEnabledPlugin();
         }
      }
   }


}
