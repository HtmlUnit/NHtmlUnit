// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Canvas
{
   public partial class CanvasCaptureMediaStreamTrack : NHtmlUnit.Javascript.Host.Media.MediaStreamTrack
   {
      static CanvasCaptureMediaStreamTrack()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasCaptureMediaStreamTrack o) =>
            new CanvasCaptureMediaStreamTrack(o));
      }

      public CanvasCaptureMediaStreamTrack(com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasCaptureMediaStreamTrack wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasCaptureMediaStreamTrack WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasCaptureMediaStreamTrack)WrappedObject; }
      }

      public CanvasCaptureMediaStreamTrack()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.canvas.CanvasCaptureMediaStreamTrack()) {}

   }


}
