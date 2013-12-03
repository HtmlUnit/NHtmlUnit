// Generated class v2.13.0.0, don't modify

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


      public static NHtmlUnit.FormEncodingType URL_ENCODED
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.FormEncodingType>(
               com.gargoylesoftware.htmlunit.FormEncodingType.URL_ENCODED);
         }
      }


      public static NHtmlUnit.FormEncodingType MULTIPART
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.FormEncodingType>(
               com.gargoylesoftware.htmlunit.FormEncodingType.MULTIPART);
         }
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
