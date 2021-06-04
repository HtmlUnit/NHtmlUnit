// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Payment
{
   public partial class PaymentRequest : NHtmlUnit.Javascript.Host.Events.EventTarget
   {
      static PaymentRequest()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.payment.PaymentRequest o) =>
            new PaymentRequest(o));
      }

      public PaymentRequest(com.gargoylesoftware.htmlunit.javascript.host.payment.PaymentRequest wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.payment.PaymentRequest WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.payment.PaymentRequest)WrappedObject; }
      }

      public PaymentRequest()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.payment.PaymentRequest()) {}

   }


}
