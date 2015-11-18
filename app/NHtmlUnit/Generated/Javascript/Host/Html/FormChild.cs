// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class FormChild : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static FormChild()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.FormChild o) =>
            new FormChild(o));
      }

      public FormChild(com.gargoylesoftware.htmlunit.javascript.host.html.FormChild wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.FormChild WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.FormChild)WrappedObject; }
      }

      public FormChild()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.FormChild()) {}


      public NHtmlUnit.Javascript.Host.Html.HTMLFormElement Form
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Html.HTMLFormElement>(
               WObj.getForm());
         }
      }

   }


}
