// Generated class v2.14.1.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class DomChangeEvent : ObjectWrapper
   {
      static DomChangeEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.DomChangeEvent o) =>
            new DomChangeEvent(o));
      }

      public DomChangeEvent(com.gargoylesoftware.htmlunit.html.DomChangeEvent wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.html.DomChangeEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.DomChangeEvent)WrappedObject; }
      }

      public DomChangeEvent(NHtmlUnit.Html.DomNode parentNode, NHtmlUnit.Html.DomNode changedNode)
         : this(new com.gargoylesoftware.htmlunit.html.DomChangeEvent((com.gargoylesoftware.htmlunit.html.DomNode)parentNode.WrappedObject, (com.gargoylesoftware.htmlunit.html.DomNode)changedNode.WrappedObject)) {}


      public NHtmlUnit.Html.DomNode ParentNode
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(
               WObj.getParentNode());
         }
      }


      public NHtmlUnit.Html.DomNode ChangedNode
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomNode>(
               WObj.getChangedNode());
         }
      }

   }


}
