// Generated class v2.50.0.0, don't modify

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace NHtmlUnit.Javascript.Host.Svg
{
   public partial class SVGElement : NHtmlUnit.Javascript.Host.Element
   {
      static SVGElement()
      {
         ObjectWrapper.RegisterWrapperCreator((com.gargoylesoftware.htmlunit.javascript.host.svg.SVGElement o) =>
            new SVGElement(o));
      }

      public SVGElement(com.gargoylesoftware.htmlunit.javascript.host.svg.SVGElement wrappedObject) : base(wrappedObject) {}

      public new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGElement WObj
      {
         get { return (com.gargoylesoftware.htmlunit.javascript.host.svg.SVGElement)WrappedObject; }
      }

      public SVGElement()
         : this(new com.gargoylesoftware.htmlunit.javascript.host.svg.SVGElement()) {}

// Generating method code for getStyle
      public virtual NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration GetStyle()
      {
         var arg = WObj.getStyle();
         return ObjectWrapper.CreateWrapper<NHtmlUnit.Javascript.Host.Css.CSSStyleDeclaration>(arg);
      }

// Generating method code for setStyle
      public virtual void SetStyle(string style)
      {
         WObj.setStyle(style);
      }

// Generating method code for getOnfocus
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnfocus()
      {
         return WObj.getOnfocus();
      }

// Generating method code for setOnfocus
      public virtual void SetOnfocus(object focus)
      {
         WObj.setOnfocus(focus);
      }

// Generating method code for getOndragend
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndragend()
      {
         return WObj.getOndragend();
      }

// Generating method code for setOndragend
      public virtual void SetOndragend(object dragend)
      {
         WObj.setOndragend(dragend);
      }

// Generating method code for getOninvalid
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOninvalid()
      {
         return WObj.getOninvalid();
      }

// Generating method code for setOninvalid
      public virtual void SetOninvalid(object invalid)
      {
         WObj.setOninvalid(invalid);
      }

// Generating method code for getOnratechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnratechange()
      {
         return WObj.getOnratechange();
      }

// Generating method code for setOnratechange
      public virtual void SetOnratechange(object ratechange)
      {
         WObj.setOnratechange(ratechange);
      }

// Generating method code for getOnresize
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnresize()
      {
         return WObj.getOnresize();
      }

// Generating method code for setOnresize
      public virtual void SetOnresize(object resize)
      {
         WObj.setOnresize(resize);
      }

// Generating method code for getOncanplaythrough
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncanplaythrough()
      {
         return WObj.getOncanplaythrough();
      }

// Generating method code for setOncanplaythrough
      public virtual void SetOncanplaythrough(object canplaythrough)
      {
         WObj.setOncanplaythrough(canplaythrough);
      }

// Generating method code for getOncancel
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncancel()
      {
         return WObj.getOncancel();
      }

// Generating method code for setOncancel
      public virtual void SetOncancel(object cancel)
      {
         WObj.setOncancel(cancel);
      }

// Generating method code for getOnselect
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnselect()
      {
         return WObj.getOnselect();
      }

// Generating method code for setOnselect
      public virtual void SetOnselect(object select)
      {
         WObj.setOnselect(select);
      }

// Generating method code for getOnauxclick
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnauxclick()
      {
         return WObj.getOnauxclick();
      }

// Generating method code for setOnauxclick
      public virtual void SetOnauxclick(object auxclick)
      {
         WObj.setOnauxclick(auxclick);
      }

// Generating method code for getOnpause
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpause()
      {
         return WObj.getOnpause();
      }

// Generating method code for setOnpause
      public virtual void SetOnpause(object pause)
      {
         WObj.setOnpause(pause);
      }

// Generating method code for getOnloadstart
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnloadstart()
      {
         return WObj.getOnloadstart();
      }

// Generating method code for setOnloadstart
      public virtual void SetOnloadstart(object loadstart)
      {
         WObj.setOnloadstart(loadstart);
      }

// Generating method code for getOnprogress
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnprogress()
      {
         return WObj.getOnprogress();
      }

// Generating method code for setOnprogress
      public virtual void SetOnprogress(object progress)
      {
         WObj.setOnprogress(progress);
      }

// Generating method code for getOnscroll
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnscroll()
      {
         return WObj.getOnscroll();
      }

// Generating method code for setOnscroll
      public virtual void SetOnscroll(object scroll)
      {
         WObj.setOnscroll(scroll);
      }

// Generating method code for getOnkeydown
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnkeydown()
      {
         return WObj.getOnkeydown();
      }

// Generating method code for setOnkeydown
      public virtual void SetOnkeydown(object keydown)
      {
         WObj.setOnkeydown(keydown);
      }

// Generating method code for getOnclick
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnclick()
      {
         return WObj.getOnclick();
      }

// Generating method code for setOnclick
      public virtual void SetOnclick(object click)
      {
         WObj.setOnclick(click);
      }

// Generating method code for getOnkeyup
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnkeyup()
      {
         return WObj.getOnkeyup();
      }

// Generating method code for setOnkeyup
      public virtual void SetOnkeyup(object keyup)
      {
         WObj.setOnkeyup(keyup);
      }

// Generating method code for getOnchange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnchange()
      {
         return WObj.getOnchange();
      }

// Generating method code for setOnchange
      public virtual void SetOnchange(object change)
      {
         WObj.setOnchange(change);
      }

// Generating method code for getOnreset
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnreset()
      {
         return WObj.getOnreset();
      }

// Generating method code for setOnreset
      public virtual void SetOnreset(object reset)
      {
         WObj.setOnreset(reset);
      }

// Generating method code for getOnkeypress
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnkeypress()
      {
         return WObj.getOnkeypress();
      }

// Generating method code for setOnkeypress
      public virtual void SetOnkeypress(object keypress)
      {
         WObj.setOnkeypress(keypress);
      }

// Generating method code for getOntimeupdate
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOntimeupdate()
      {
         return WObj.getOntimeupdate();
      }

// Generating method code for setOntimeupdate
      public virtual void SetOntimeupdate(object timeupdate)
      {
         WObj.setOntimeupdate(timeupdate);
      }

// Generating method code for getOndblclick
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndblclick()
      {
         return WObj.getOndblclick();
      }

// Generating method code for setOndblclick
      public virtual void SetOndblclick(object dblclick)
      {
         WObj.setOndblclick(dblclick);
      }

// Generating method code for getOndrag
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndrag()
      {
         return WObj.getOndrag();
      }

// Generating method code for setOndrag
      public virtual void SetOndrag(object drag)
      {
         WObj.setOndrag(drag);
      }

// Generating method code for getOnseeked
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnseeked()
      {
         return WObj.getOnseeked();
      }

// Generating method code for setOnseeked
      public virtual void SetOnseeked(object seeked)
      {
         WObj.setOnseeked(seeked);
      }

// Generating method code for getOnabort
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnabort()
      {
         return WObj.getOnabort();
      }

// Generating method code for setOnabort
      public virtual void SetOnabort(object abort)
      {
         WObj.setOnabort(abort);
      }

// Generating method code for getOnloadedmetadata
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnloadedmetadata()
      {
         return WObj.getOnloadedmetadata();
      }

// Generating method code for setOnloadedmetadata
      public virtual void SetOnloadedmetadata(object loadedmetadata)
      {
         WObj.setOnloadedmetadata(loadedmetadata);
      }

// Generating method code for getOntoggle
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOntoggle()
      {
         return WObj.getOntoggle();
      }

// Generating method code for setOntoggle
      public virtual void SetOntoggle(object toggle)
      {
         WObj.setOntoggle(toggle);
      }

// Generating method code for getOnplay
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnplay()
      {
         return WObj.getOnplay();
      }

// Generating method code for setOnplay
      public virtual void SetOnplay(object play)
      {
         WObj.setOnplay(play);
      }

// Generating method code for getOncontextmenu
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncontextmenu()
      {
         return WObj.getOncontextmenu();
      }

// Generating method code for setOncontextmenu
      public virtual void SetOncontextmenu(object contextmenu)
      {
         WObj.setOncontextmenu(contextmenu);
      }

// Generating method code for getOnmousemove
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmousemove()
      {
         return WObj.getOnmousemove();
      }

// Generating method code for setOnmousemove
      public virtual void SetOnmousemove(object mousemove)
      {
         WObj.setOnmousemove(mousemove);
      }

// Generating method code for getOnerror
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnerror()
      {
         return WObj.getOnerror();
      }

// Generating method code for setOnerror
      public virtual void SetOnerror(object error)
      {
         WObj.setOnerror(error);
      }

// Generating method code for getOnmouseup
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmouseup()
      {
         return WObj.getOnmouseup();
      }

// Generating method code for setOnmouseup
      public virtual void SetOnmouseup(object mouseup)
      {
         WObj.setOnmouseup(mouseup);
      }

// Generating method code for getOndragover
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndragover()
      {
         return WObj.getOndragover();
      }

// Generating method code for setOndragover
      public virtual void SetOndragover(object dragover)
      {
         WObj.setOndragover(dragover);
      }

// Generating method code for getOncut
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncut()
      {
         return WObj.getOncut();
      }

// Generating method code for setOncut
      public virtual void SetOncut(object cut)
      {
         WObj.setOncut(cut);
      }

// Generating method code for getOnmouseover
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmouseover()
      {
         return WObj.getOnmouseover();
      }

// Generating method code for setOnmouseover
      public virtual void SetOnmouseover(object mouseover)
      {
         WObj.setOnmouseover(mouseover);
      }

// Generating method code for getOninput
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOninput()
      {
         return WObj.getOninput();
      }

// Generating method code for setOninput
      public virtual void SetOninput(object input)
      {
         WObj.setOninput(input);
      }

// Generating method code for getOnstalled
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnstalled()
      {
         return WObj.getOnstalled();
      }

// Generating method code for setOnstalled
      public virtual void SetOnstalled(object stalled)
      {
         WObj.setOnstalled(stalled);
      }

// Generating method code for getOnclose
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnclose()
      {
         return WObj.getOnclose();
      }

// Generating method code for setOnclose
      public virtual void SetOnclose(object close)
      {
         WObj.setOnclose(close);
      }

// Generating method code for getOndragenter
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndragenter()
      {
         return WObj.getOndragenter();
      }

// Generating method code for setOndragenter
      public virtual void SetOndragenter(object dragenter)
      {
         WObj.setOndragenter(dragenter);
      }

// Generating method code for getOnmozfullscreenerror
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmozfullscreenerror()
      {
         return WObj.getOnmozfullscreenerror();
      }

// Generating method code for setOnmozfullscreenerror
      public virtual void SetOnmozfullscreenerror(object mozfullscreenerror)
      {
         WObj.setOnmozfullscreenerror(mozfullscreenerror);
      }

// Generating method code for getOnsubmit
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnsubmit()
      {
         return WObj.getOnsubmit();
      }

// Generating method code for setOnsubmit
      public virtual void SetOnsubmit(object submit)
      {
         WObj.setOnsubmit(submit);
      }

// Generating method code for getOnmouseleave
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmouseleave()
      {
         return WObj.getOnmouseleave();
      }

// Generating method code for setOnmouseleave
      public virtual void SetOnmouseleave(object mouseleave)
      {
         WObj.setOnmouseleave(mouseleave);
      }

// Generating method code for getOnmouseenter
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmouseenter()
      {
         return WObj.getOnmouseenter();
      }

// Generating method code for setOnmouseenter
      public virtual void SetOnmouseenter(object mouseenter)
      {
         WObj.setOnmouseenter(mouseenter);
      }

// Generating method code for getOndragleave
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndragleave()
      {
         return WObj.getOndragleave();
      }

// Generating method code for setOndragleave
      public virtual void SetOndragleave(object dragleave)
      {
         WObj.setOndragleave(dragleave);
      }

// Generating method code for getOnmousewheel
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmousewheel()
      {
         return WObj.getOnmousewheel();
      }

// Generating method code for setOnmousewheel
      public virtual void SetOnmousewheel(object mousewheel)
      {
         WObj.setOnmousewheel(mousewheel);
      }

// Generating method code for getOnseeking
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnseeking()
      {
         return WObj.getOnseeking();
      }

// Generating method code for setOnseeking
      public virtual void SetOnseeking(object seeking)
      {
         WObj.setOnseeking(seeking);
      }

// Generating method code for getOnblur
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnblur()
      {
         return WObj.getOnblur();
      }

// Generating method code for setOnblur
      public virtual void SetOnblur(object blur)
      {
         WObj.setOnblur(blur);
      }

// Generating method code for getOncuechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncuechange()
      {
         return WObj.getOncuechange();
      }

// Generating method code for setOncuechange
      public virtual void SetOncuechange(object cuechange)
      {
         WObj.setOncuechange(cuechange);
      }

// Generating method code for getOndrop
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndrop()
      {
         return WObj.getOndrop();
      }

// Generating method code for setOndrop
      public virtual void SetOndrop(object drop)
      {
         WObj.setOndrop(drop);
      }

// Generating method code for getOndragstart
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndragstart()
      {
         return WObj.getOndragstart();
      }

// Generating method code for setOndragstart
      public virtual void SetOndragstart(object dragstart)
      {
         WObj.setOndragstart(dragstart);
      }

// Generating method code for getOnmozfullscreenchange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmozfullscreenchange()
      {
         return WObj.getOnmozfullscreenchange();
      }

// Generating method code for setOnmozfullscreenchange
      public virtual void SetOnmozfullscreenchange(object mozfullscreenchange)
      {
         WObj.setOnmozfullscreenchange(mozfullscreenchange);
      }

// Generating method code for getOndurationchange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOndurationchange()
      {
         return WObj.getOndurationchange();
      }

// Generating method code for setOndurationchange
      public virtual void SetOndurationchange(object durationchange)
      {
         WObj.setOndurationchange(durationchange);
      }

// Generating method code for getOnplaying
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnplaying()
      {
         return WObj.getOnplaying();
      }

// Generating method code for setOnplaying
      public virtual void SetOnplaying(object playing)
      {
         WObj.setOnplaying(playing);
      }

// Generating method code for getOnload
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnload()
      {
         return WObj.getOnload();
      }

// Generating method code for setOnload
      public virtual void SetOnload(object load)
      {
         WObj.setOnload(load);
      }

// Generating method code for getOnended
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnended()
      {
         return WObj.getOnended();
      }

// Generating method code for setOnended
      public virtual void SetOnended(object ended)
      {
         WObj.setOnended(ended);
      }

// Generating method code for getOnloadeddata
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnloadeddata()
      {
         return WObj.getOnloadeddata();
      }

// Generating method code for setOnloadeddata
      public virtual void SetOnloadeddata(object loadeddata)
      {
         WObj.setOnloadeddata(loadeddata);
      }

// Generating method code for getOnshow
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnshow()
      {
         return WObj.getOnshow();
      }

// Generating method code for setOnshow
      public virtual void SetOnshow(object show)
      {
         WObj.setOnshow(show);
      }

// Generating method code for getOncopy
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncopy()
      {
         return WObj.getOncopy();
      }

// Generating method code for setOncopy
      public virtual void SetOncopy(object copy)
      {
         WObj.setOncopy(copy);
      }

// Generating method code for getOnpaste
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnpaste()
      {
         return WObj.getOnpaste();
      }

// Generating method code for setOnpaste
      public virtual void SetOnpaste(object paste)
      {
         WObj.setOnpaste(paste);
      }

// Generating method code for getOnmouseout
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmouseout()
      {
         return WObj.getOnmouseout();
      }

// Generating method code for setOnmouseout
      public virtual void SetOnmouseout(object mouseout)
      {
         WObj.setOnmouseout(mouseout);
      }

// Generating method code for getOnsuspend
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnsuspend()
      {
         return WObj.getOnsuspend();
      }

// Generating method code for setOnsuspend
      public virtual void SetOnsuspend(object suspend)
      {
         WObj.setOnsuspend(suspend);
      }

// Generating method code for getOnvolumechange
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnvolumechange()
      {
         return WObj.getOnvolumechange();
      }

// Generating method code for setOnvolumechange
      public virtual void SetOnvolumechange(object volumechange)
      {
         WObj.setOnvolumechange(volumechange);
      }

// Generating method code for getOnwaiting
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnwaiting()
      {
         return WObj.getOnwaiting();
      }

// Generating method code for setOnwaiting
      public virtual void SetOnwaiting(object waiting)
      {
         WObj.setOnwaiting(waiting);
      }

// Generating method code for getOncanplay
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOncanplay()
      {
         return WObj.getOncanplay();
      }

// Generating method code for setOncanplay
      public virtual void SetOncanplay(object canplay)
      {
         WObj.setOncanplay(canplay);
      }

// Generating method code for getOnmousedown
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnmousedown()
      {
         return WObj.getOnmousedown();
      }

// Generating method code for setOnmousedown
      public virtual void SetOnmousedown(object mousedown)
      {
         WObj.setOnmousedown(mousedown);
      }

// Generating method code for getOnemptied
      public virtual net.sourceforge.htmlunit.corejs.javascript.Function GetOnemptied()
      {
         return WObj.getOnemptied();
      }

// Generating method code for setOnemptied
      public virtual void SetOnemptied(object emptied)
      {
         WObj.setOnemptied(emptied);
      }

   }


}
