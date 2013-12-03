// Generated class v2.13.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class Cache : ObjectWrapper
   {
      static Cache()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.Cache o) =>
            new Cache(o));
      }

      public Cache(com.gargoylesoftware.htmlunit.Cache wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.Cache WObj
      {
         get { return (com.gargoylesoftware.htmlunit.Cache)WrappedObject; }
      }

      public Cache()
         : this(new com.gargoylesoftware.htmlunit.Cache()) {}


      public System.Int32 MaxSize
      {
         get
         {
            return WObj.getMaxSize();
         }
         set
         {
            WObj.setMaxSize(value);
         }

      }

      public System.Int32 Size
      {
         get
         {
            return WObj.getSize();
         }
      }
// Generating method code for cacheIfPossible
      public virtual void CacheIfPossible(NHtmlUnit.WebRequest request, NHtmlUnit.WebResponse response, object toCache)
      {
         WObj.cacheIfPossible((com.gargoylesoftware.htmlunit.WebRequest)request.WrappedObject, (com.gargoylesoftware.htmlunit.WebResponse)response.WrappedObject, toCache);
      }

// Generating method code for cache
      public virtual void AddToCache(string css, NHtmlUnit.W3C.Dom.Css.ICSSStyleSheet styleSheet)
      {
         WObj.cache(css, (org.w3c.dom.css.CSSStyleSheet)styleSheet.WrappedObject);
      }

// Generating method code for getCachedObject
      public virtual object GetCachedObject(NHtmlUnit.WebRequest request)
      {
         return WObj.getCachedObject((com.gargoylesoftware.htmlunit.WebRequest)request.WrappedObject);
      }

// Generating method code for getCachedStyleSheet
      public virtual NHtmlUnit.W3C.Dom.Css.ICSSStyleSheet GetCachedStyleSheet(string css)
      {
         return ObjectWrapper.CreateWrapper<NHtmlUnit.W3C.Dom.Css.ICSSStyleSheet>(WObj.getCachedStyleSheet(css));
      }

// Generating method code for clear
      public virtual void Clear()
      {
         WObj.clear();
      }

   }


}
