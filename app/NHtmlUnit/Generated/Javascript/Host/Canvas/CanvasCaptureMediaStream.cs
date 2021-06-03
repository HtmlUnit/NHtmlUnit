// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class CanvasCaptureMediaStream : NHtmlUnit.Javascript.Host.Media.MediaStream
   {
      static CanvasCaptureMediaStream()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasCaptureMediaStream o) =>
            new CanvasCaptureMediaStream(o));
      }

      public CanvasCaptureMediaStream(com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasCaptureMediaStream wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasCaptureMediaStream WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasCaptureMediaStream)WrappedObject; }
      }

      public CanvasCaptureMediaStream()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasCaptureMediaStream()) {}

   }


}
