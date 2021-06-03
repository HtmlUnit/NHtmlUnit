// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Media
{
   public partial class AudioParam : NHtmlUnit.Javascript.SimpleScriptable
   {
      static AudioParam()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.media.AudioParam o) =>
            new AudioParam(o));
      }

      public AudioParam(com.gargoylesoftware.htmlunit.javascript.host.media.AudioParam wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.media.AudioParam WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.media.AudioParam)WrappedObject; }
      }

      public AudioParam()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.media.AudioParam()) {}


      public System.Double DefaultValue
      {
         get
         {
            return WObj.getDefaultValue();
         }
      }

      public System.Double Value
      {
         get
         {
            return WObj.getValue();
         }
         set
         {
            WObj.setValue(value);
         }

      }

      public System.Double MaxValue
      {
         get
         {
            return WObj.getMaxValue();
         }
      }

      public System.Double MinValue
      {
         get
         {
            return WObj.getMinValue();
         }
      }
// Generating method code for jsConstructor
      public virtual void JsConstructor()
      {
         WObj.jsConstructor();
      }

   }


}
