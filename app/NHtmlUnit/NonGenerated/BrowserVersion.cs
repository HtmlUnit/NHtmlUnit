#region License

// --------------------------------------------------
// Copyright � 2003-2011 OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

namespace NHtmlUnit
{
    public partial class BrowserVersion
    {
        public static NHtmlUnit.BrowserVersion BEST_SUPPORTED
        {
            get
            {
                return ObjectWrapper.CreateWrapper<NHtmlUnit.BrowserVersion>(
                   com.gargoylesoftware.htmlunit.BrowserVersion.BEST_SUPPORTED);
            }
        }


        public static NHtmlUnit.BrowserVersion FIREFOX
        {
            get
            {
                return ObjectWrapper.CreateWrapper<NHtmlUnit.BrowserVersion>(
                   com.gargoylesoftware.htmlunit.BrowserVersion.FIREFOX);
            }
        }


        public static NHtmlUnit.BrowserVersion FIREFOX_78
        {
            get
            {
                return ObjectWrapper.CreateWrapper<NHtmlUnit.BrowserVersion>(
                   com.gargoylesoftware.htmlunit.BrowserVersion.FIREFOX_78);
            }
        }


        public static NHtmlUnit.BrowserVersion INTERNET_EXPLORER
        {
            get
            {
                return ObjectWrapper.CreateWrapper<NHtmlUnit.BrowserVersion>(
                   com.gargoylesoftware.htmlunit.BrowserVersion.INTERNET_EXPLORER);
            }
        }


        public static NHtmlUnit.BrowserVersion CHROME
        {
            get
            {
                return ObjectWrapper.CreateWrapper<NHtmlUnit.BrowserVersion>(
                   com.gargoylesoftware.htmlunit.BrowserVersion.CHROME);
            }
        }
    }
}