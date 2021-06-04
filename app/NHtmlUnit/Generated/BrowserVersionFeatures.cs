// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class BrowserVersionFeatures : ObjectWrapper
   {
      static BrowserVersionFeatures()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.BrowserVersionFeatures o) =>
            new BrowserVersionFeatures(o));
      }

      public BrowserVersionFeatures(com.gargoylesoftware.htmlunit.BrowserVersionFeatures wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.BrowserVersionFeatures WObj
      {
         get { return (com.gargoylesoftware.htmlunit.BrowserVersionFeatures)WrappedObject; }
      }

   }


}
