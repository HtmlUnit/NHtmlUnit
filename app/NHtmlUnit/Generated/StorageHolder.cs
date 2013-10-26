// Generated class v2.13, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit
{
   public partial class StorageHolder : ObjectWrapper
   {
      static StorageHolder()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.StorageHolder o) =>
            new StorageHolder(o));
      }

      public StorageHolder(com.gargoylesoftware.htmlunit.StorageHolder wrappedObject) : base(wrappedObject) {}

      public com.gargoylesoftware.htmlunit.StorageHolder WObj
      {
         get { return (com.gargoylesoftware.htmlunit.StorageHolder)WrappedObject; }
      }

      public StorageHolder()
         : this(new com.gargoylesoftware.htmlunit.StorageHolder()) {}

// Generating method code for getStore
      public virtual java.util.Map GetStore(com.gargoylesoftware.htmlunit.StorageHolder.Type storageType, NHtmlUnit.IPage page)
      {
         return WObj.getStore(storageType, (com.gargoylesoftware.htmlunit.Page)page.WrappedObject);
      }

   }


}
