// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLProgressElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLProgressElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLProgressElement o) =>
            new HTMLProgressElement(o));
      }

      public HTMLProgressElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLProgressElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLProgressElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLProgressElement)WrappedObject; }
      }

      public HTMLProgressElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLProgressElement()) {}


      public System.Double Max
      {
         get
         {
            return WObj.getMax();
         }
      }

      public NHtmlUnit.Javascript.Host.Dom.AbstractList Labels
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Dom.AbstractList>(
               WObj.getLabels());
         }
      }

   }


}
