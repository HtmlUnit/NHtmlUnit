// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Payment
{
   public partial class PaymentResponse : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static PaymentResponse()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.payment.PaymentResponse o) =>
            new PaymentResponse(o));
      }

      public PaymentResponse(com.gargoylesoftware.htmlunit.javascript.host.payment.PaymentResponse wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.payment.PaymentResponse WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.payment.PaymentResponse)WrappedObject; }
      }

      public PaymentResponse()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.payment.PaymentResponse()) {}

   }


}
