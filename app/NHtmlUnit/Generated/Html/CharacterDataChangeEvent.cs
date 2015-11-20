// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Html
{
   public partial class CharacterDataChangeEvent : ObjectWrapper
   {
      static CharacterDataChangeEvent()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.html.CharacterDataChangeEvent o) =>
            new CharacterDataChangeEvent(o));
      }

      public CharacterDataChangeEvent(com.gargoylesoftware.htmlunit.html.CharacterDataChangeEvent wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.html.CharacterDataChangeEvent WObj
      {
         get { return (com.gargoylesoftware.htmlunit.html.CharacterDataChangeEvent)WrappedObject; }
      }

      public CharacterDataChangeEvent(NHtmlUnit.Html.DomCharacterData characterData, string oldValue)
         : this(new com.gargoylesoftware.htmlunit.html.CharacterDataChangeEvent((com.gargoylesoftware.htmlunit.html.DomCharacterData)characterData.WrappedObject, oldValue)) {}


      public NHtmlUnit.Html.DomCharacterData CharacterData
      {
         get
         {
            return ObjectWrapper.CreateWrapper<NHtmlUnit.Html.DomCharacterData>(
               WObj.getCharacterData());
         }
      }


      public System.String OldValue
      {
         get
         {
            return WObj.getOldValue();
         }
      }
   }


}
