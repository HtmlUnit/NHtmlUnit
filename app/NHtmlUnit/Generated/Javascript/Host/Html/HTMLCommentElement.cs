// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Html
{
   public partial class HTMLCommentElement : NHtmlUnit.Javascript.Host.Dom.Comment
   {
      static HTMLCommentElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCommentElement o) =>
            new HTMLCommentElement(o));
      }

      public HTMLCommentElement(com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCommentElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCommentElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCommentElement)WrappedObject; }
      }

      public HTMLCommentElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.html.HTMLCommentElement()) {}

   }


}
