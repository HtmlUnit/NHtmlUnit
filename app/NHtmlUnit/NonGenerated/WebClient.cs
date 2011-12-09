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
        public bool ActiveXNative
        {
            get { return WObj.isActiveXNative(); }
            set { WObj.setActiveXNative(value); }
        }

        public bool AppletEnabled
        {
            get { return WObj.isAppletEnabled(); }
            set { WObj.setAppletEnabled(value); }
        }

        public bool CssEnabled
        {
            get { return WObj.isCssEnabled(); }
            set { WObj.setCssEnabled(value); }
        }

        public bool JavaScriptEnabled
        {
            get { return WObj.isJavaScriptEnabled(); }
            set { WObj.setJavaScriptEnabled(value); }
        }

        public bool PopupBlockerEnabled
        {
            get { return WObj.isPopupBlockerEnabled(); }
            set { WObj.setPopupBlockerEnabled(value); }
        }

        public bool RedirectEnabled
        {
            get { return WObj.isRedirectEnabled(); }

            set { WObj.setRedirectEnabled(value); }
        }

        public bool ThrowExceptionOnFailingStatusCode
        {
            get { return WObj.isThrowExceptionOnFailingStatusCode(); }
            set { WObj.setThrowExceptionOnFailingStatusCode(value); }
        }

        public bool ThrowExceptionOnScriptError
        {
            get { return WObj.isThrowExceptionOnScriptError(); }
            set { WObj.setThrowExceptionOnScriptError(value); }
        }

        public bool UseInsecureSsl
        {
            private get { return true; }
            set { WObj.setUseInsecureSSL(value); }
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