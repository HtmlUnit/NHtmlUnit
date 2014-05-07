// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class FormEncodingType : ObjectWrapper
   {
      static FormEncodingType()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.FormEncodingType o) =>
            new FormEncodingType(o));
      }

      public FormEncodingType(com.gargoylesoftware.htmlunit.FormEncodingType wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.FormEncodingType WObj
      {
         get { return (com.gargoylesoftware.htmlunit.FormEncodingType)WrappedObject; }
      }


      public System.String Name
      {
         get
         {
            return WObj.getName();
         }
      }
   }


}
