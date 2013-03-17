// Generated class v5, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Util
{
   public partial class NameValuePair : ObjectWrapper
   {
      static NameValuePair()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.util.NameValuePair o) =>
            new NameValuePair(o));
      }

      public NameValuePair(com.gargoylesoftware.htmlunit.util.NameValuePair wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.util.NameValuePair WObj
      {
         get { return (com.gargoylesoftware.htmlunit.util.NameValuePair)WrappedObject; }
      }

      public NameValuePair(string name, string value)
         : this(new com.gargoylesoftware.htmlunit.util.NameValuePair(name, value)) {}


      public System.String Value
      {
         get
         {
            return WObj.getValue();
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
