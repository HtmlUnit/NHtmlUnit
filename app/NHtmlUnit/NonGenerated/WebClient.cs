#region License

// --------------------------------------------------
// Copyright © 2003-2011 OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

using System;

using javax.management.openmbean;

using NHtmlUnit.Html;

namespace NHtmlUnit
{
    public partial class WebClient
    {
        [Obsolete("Use Options.ActiveXNative")]
        public bool ActiveXNative
        {
            get { return WObj.getOptions().isActiveXNative(); }
            set { WObj.getOptions().setActiveXNative(value); }
        }

        [Obsolete("Use Options.AppletEnabled")]
        public bool AppletEnabled
        {
            get { return WObj.getOptions().isAppletEnabled(); }
            set { WObj.getOptions().setAppletEnabled(value); }
        }

        [Obsolete("Use Options.CssEnabled")]
        public bool CssEnabled
        {
            get { return WObj.getOptions().isCssEnabled(); }
            set { WObj.getOptions().setCssEnabled(value); }
        }

        [Obsolete("Use Options.JavaScriptEnabled")]
        public bool JavaScriptEnabled
        {
            get { return WObj.getOptions().isJavaScriptEnabled(); }
            set { WObj.getOptions().setJavaScriptEnabled(value); }
        }

        [Obsolete("Use Options.PopupBlockerEnabled")]
        public bool PopupBlockerEnabled
        {
            get { return WObj.getOptions().isPopupBlockerEnabled(); }
            set { WObj.getOptions().setPopupBlockerEnabled(value); }
        }

        [Obsolete("Use Options.RedirectEnabled")]
        public bool RedirectEnabled
        {
            get { return WObj.getOptions().isRedirectEnabled(); }

            set { WObj.getOptions().setRedirectEnabled(value); }
        }

        [Obsolete("Use Options.ThrowExceptionOnFailingStatusCode")]
        public bool ThrowExceptionOnFailingStatusCode
        {
            get { return WObj.getOptions().isThrowExceptionOnFailingStatusCode(); }
            set { WObj.getOptions().setThrowExceptionOnFailingStatusCode(value); }
        }

        [Obsolete("Use Options.ThrowExceptionOnScriptError")]
        public bool ThrowExceptionOnScriptError
        {
            get { return WObj.getOptions().isThrowExceptionOnScriptError(); }
            set { WObj.getOptions().setThrowExceptionOnScriptError(value); }
        }

        [Obsolete("Use Options.UseInsecureSsl")]
        public bool UseInsecureSsl
        {
            private get { return WObj.getOptions().isUseInsecureSSL(); }
            set { WObj.getOptions().setUseInsecureSSL(value); }
        }


        public HtmlPage GetHtmlPage(string url)
        {
            IPage page = GetPage(url);

            if (page == null)
                throw new InvalidOpenTypeException(String.Format("{0} returned null.", url));

            if (!(page is HtmlPage))
            {
                throw new InvalidOperationException(String.Format("{0} retrieved from {1} is not a {2}.",
                                                                  page,
                                                                  url,
                                                                  typeof(HtmlPage)));
            }

            return (HtmlPage)page;
        }
    }
}