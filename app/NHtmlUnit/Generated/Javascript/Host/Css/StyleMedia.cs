// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Css
{
   public partial class StyleMedia : NHtmlUnit.Javascript.SimpleScriptable
   {
      static StyleMedia()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.css.StyleMedia o) =>
            new StyleMedia(o));
      }

      public StyleMedia(com.gargoylesoftware.htmlunit.javascript.host.css.StyleMedia wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.css.StyleMedia WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.css.StyleMedia)WrappedObject; }
      }

      public StyleMedia()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.css.StyleMedia()) {}


      public System.String Type
      {
         get
         {
            return WObj.getType();
         }
      }
// Generating method code for matchMedium
      public virtual bool MatchMedium(string media)
      {
         return WObj.matchMedium(media);
      }

   }


}
