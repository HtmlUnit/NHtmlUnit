// Generated class v2.19.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Dom
{
   public partial class MutationRecord : NHtmlUnit.Javascript.SimpleScriptable
   {
      static MutationRecord()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.dom.MutationRecord o) =>
            new MutationRecord(o));
      }

      public MutationRecord(com.gargoylesoftware.htmlunit.javascript.host.dom.MutationRecord wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.dom.MutationRecord WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.dom.MutationRecord)WrappedObject; }
      }

      public MutationRecord()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.dom.MutationRecord()) {}


      public System.String Type
      {
         get
         {
            return WObj.getType();
         }
      }

      public net.sourceforge.htmlunit.corejs.javascript.ScriptableObject Target
      {
         get
         {
            return WObj.getTarget();
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
