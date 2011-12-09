// Generated class v4, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host
{
   public partial class MediaList : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MediaList()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.MediaList o) =>
            new MediaList(o));
      }

      public MediaList(com.gargoylesoftware.htmlunit.javascript.host.MediaList wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.MediaList WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.MediaList)WrappedObject; }
      }

      public MediaList(NHtmlUnit.Javascript.Host.Css.CSSStyleSheet parent, NHtmlUnit.W3C.Dom.Stylesheets.IMediaList wrappedList)
         : this(new com.gargoylesoftware.htmlunit.javascript.host.MediaList((com.gargoylesoftware.htmlunit.javascript.host.css.CSSStyleSheet)parent.WrappedObject, (org.w3c.dom.stylesheets.MediaList)wrappedList.WrappedObject)) {}

// Generating method code for jsxGet_length
      public virtual int JsxGet_length()
      {
         return WObj.jsxGet_length();
      }

// Generating method code for jsxFunction_item
      public virtual string JsxFunction_item(int index)
      {
         return WObj.jsxFunction_item(index);
      }

// Generating method code for jsxGet_mediaText
      public virtual string JsxGet_mediaText()
      {
         return WObj.jsxGet_mediaText();
      }

   }


}
