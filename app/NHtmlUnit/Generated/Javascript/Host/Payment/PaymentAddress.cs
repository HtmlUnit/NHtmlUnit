// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Payment
{
   public partial class PaymentAddress : NHtmlUnit.Javascript.SimpleScriptable
   {
      static PaymentAddress()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.payment.PaymentAddress o) =>
            new PaymentAddress(o));
      }

      public PaymentAddress(com.gargoylesoftware.htmlunit.javascript.host.payment.PaymentAddress wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.payment.PaymentAddress WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.payment.PaymentAddress)WrappedObject; }
      }

      public PaymentAddress()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.payment.PaymentAddress()) {}

   }


}
