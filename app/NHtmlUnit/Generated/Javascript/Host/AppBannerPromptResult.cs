// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class AppBannerPromptResult : NHtmlUnit.Javascript.SimpleScriptable
   {
      static AppBannerPromptResult()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.AppBannerPromptResult o) =>
            new AppBannerPromptResult(o));
      }

      public AppBannerPromptResult(com.gargoylesoftware.htmlunit.javascript.host.AppBannerPromptResult wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.AppBannerPromptResult WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.AppBannerPromptResult)WrappedObject; }
      }

      public AppBannerPromptResult()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.AppBannerPromptResult()) {}

   }


}
