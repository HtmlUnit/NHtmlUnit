// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class HttpMethod : ObjectWrapper
   {
      static HttpMethod()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.HttpMethod o) =>
            new HttpMethod(o));
      }

      public HttpMethod(com.gargoylesoftware.htmlunit.HttpMethod wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.HttpMethod WObj
      {
         get { return (com.gargoylesoftware.htmlunit.HttpMethod)WrappedObject; }
      }


      public static NHtmlUnit.HttpMethod OPTIONS
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.HttpMethod>(
               com.gargoylesoftware.htmlunit.HttpMethod.OPTIONS);
         }
      }


      public static NHtmlUnit.HttpMethod GET
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.HttpMethod>(
               com.gargoylesoftware.htmlunit.HttpMethod.GET);
         }
      }


      public static NHtmlUnit.HttpMethod HEAD
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.HttpMethod>(
               com.gargoylesoftware.htmlunit.HttpMethod.HEAD);
         }
      }


      public static NHtmlUnit.HttpMethod POST
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.HttpMethod>(
               com.gargoylesoftware.htmlunit.HttpMethod.POST);
         }
      }


      public static NHtmlUnit.HttpMethod PUT
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.HttpMethod>(
               com.gargoylesoftware.htmlunit.HttpMethod.PUT);
         }
      }


      public static NHtmlUnit.HttpMethod DELETE
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.HttpMethod>(
               com.gargoylesoftware.htmlunit.HttpMethod.DELETE);
         }
      }


      public static NHtmlUnit.HttpMethod TRACE
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.HttpMethod>(
               com.gargoylesoftware.htmlunit.HttpMethod.TRACE);
         }
      }

   }


}
