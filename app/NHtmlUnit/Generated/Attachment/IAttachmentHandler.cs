// Wrapper for com.gargoylesoftware.htmlunit.attachment.AttachmentHandler
// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;



namespace NHtmlUnit.Attachment
{
   public interface IAttachmentHandler : NHtmlUnit.IObjectWrapper
   {
// Generating method code for handleAttachment
      void HandleAttachment(NHtmlUnit.IPage p);
// Generating method code for handleAttachment
      bool HandleAttachment(NHtmlUnit.WebResponse response);
// Generating method code for isAttachment
      bool IsAttachment(NHtmlUnit.WebResponse response);

   }
}
