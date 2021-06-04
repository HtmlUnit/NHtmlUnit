// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class ValidityState : NHtmlUnit.Javascript.SimpleScriptable
   {
      static ValidityState()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.ValidityState o) =>
            new ValidityState(o));
      }

      public ValidityState(com.gargoylesoftware.htmlunit.javascript.host.html.ValidityState wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.ValidityState WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.ValidityState)WrappedObject; }
      }

      public ValidityState()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.ValidityState()) {}

// Generating method code for isCustomError
      public virtual bool IsCustomError()
      {
         return WObj.isCustomError();
      }

// Generating method code for isPatternMismatch
      public virtual bool IsPatternMismatch()
      {
         return WObj.isPatternMismatch();
      }

// Generating method code for isRangeOverlow
      public virtual bool IsRangeOverlow()
      {
         return WObj.isRangeOverlow();
      }

// Generating method code for isRangeUnderflow
      public virtual bool IsRangeUnderflow()
      {
         return WObj.isRangeUnderflow();
      }

// Generating method code for isStepMismatch
      public virtual bool IsStepMismatch()
      {
         return WObj.isStepMismatch();
      }

// Generating method code for isTooLong
      public virtual bool IsTooLong()
      {
         return WObj.isTooLong();
      }

// Generating method code for isTypeMismatch
      public virtual bool IsTypeMismatch()
      {
         return WObj.isTypeMismatch();
      }

// Generating method code for isValueMissing
      public virtual bool IsValueMissing()
      {
         return WObj.isValueMissing();
      }

// Generating method code for isValid
      public virtual bool IsValid()
      {
         return WObj.isValid();
      }

   }


}
