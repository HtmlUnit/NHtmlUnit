// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class FormChild : NHtmlUnit.Javascript.Host.Html.HTMLElement, NHtmlUnit.Javascript.IScriptableWithFallbackGetter
   {
      static FormChild()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.FormChild o) =>
            new FormChild(o));
      }

      public FormChild(com.gargoylesoftware.htmlunit.javascript.host.FormChild wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.FormChild WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.FormChild)WrappedObject; }
      }

      public FormChild()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.FormChild()) {}


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
