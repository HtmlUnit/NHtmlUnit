// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLMeterElement : NHtmlUnit.Javascript.Host.Html.HTMLElement
   {
      static HTMLMeterElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMeterElement o) =>
            new HTMLMeterElement(o));
      }

      public HTMLMeterElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMeterElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMeterElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMeterElement)WrappedObject; }
      }

      public HTMLMeterElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLMeterElement()) {}


      public System.Double Min
      {
         get
         {
            return WObj.getMin();
         }
      }

      public System.Double Max
      {
         get
         {
            return WObj.getMax();
         }
      }

      public System.Double Low
      {
         get
         {
            return WObj.getLow();
         }
      }

      public System.Double High
      {
         get
         {
            return WObj.getHigh();
         }
      }

      public System.Double Optimum
      {
         get
         {
            return WObj.getOptimum();
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
