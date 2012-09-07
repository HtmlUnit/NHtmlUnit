// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class CookieManager : ObjectWrapper
   {
      static CookieManager()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.CookieManager o) =>
            new CookieManager(o));
      }

      public CookieManager(com.gargoylesoftware.htmlunit.CookieManager wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.CookieManager WObj
      {
         get { return (com.gargoylesoftware.htmlunit.CookieManager)WrappedObject; }
      }

      public CookieManager()
         : this(new com.gargoylesoftware.htmlunit.CookieManager()) {}


      public ICollection<NHtmlUnit.Util.Cookie> Cookies
      {
         get
         {
            return new CollectionWrapper<NHtmlUnit.Util.Cookie>(
               WObj.getCookies());
         }
       }
// Generating method code for clearExpired
      public virtual bool ClearExpired(java.util.Date date)
      {
         return WObj.clearExpired(date);
      }

// Generating method code for isCookiesEnabled
      public virtual bool IsCookiesEnabled()
      {
         return WObj.isCookiesEnabled();
      }

// Generating method code for getCookies
      public virtual ICollection<NHtmlUnit.Util.Cookie> GetCookies(java.net.URL url)
      {

         return new CollectionWrapper<NHtmlUnit.Util.Cookie>(WObj.getCookies(url));
      }

// Generating method code for getCookie
      public virtual NHtmlUnit.Util.Cookie GetCookie(string name)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Util.Cookie>(WObj.getCookie(name));
      }

// Generating method code for addCookie
      public virtual void AddCookie(NHtmlUnit.Util.Cookie cookie)
      {
         WObj.addCookie((com.gargoylesoftware.htmlunit.util.Cookie)cookie.WrappedObject);
      }

// Generating method code for removeCookie
      public virtual void RemoveCookie(NHtmlUnit.Util.Cookie cookie)
      {
         WObj.removeCookie((com.gargoylesoftware.htmlunit.util.Cookie)cookie.WrappedObject);
      }

// Generating method code for clearCookies
      public virtual void ClearCookies()
      {
         WObj.clearCookies();
      }

   }


}
