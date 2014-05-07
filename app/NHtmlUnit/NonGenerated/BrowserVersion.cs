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
        public static NHtmlUnit.BrowserVersion FIREFOX_17
        {
            get
            {
                return ObjectWrapper.CreateWrapper<NHtmlUnit.BrowserVersion>(
                   com.gargoylesoftware.htmlunit.BrowserVersion.FIREFOX_17);
            }
        }


        public static NHtmlUnit.BrowserVersion INTERNET_EXPLORER_8
        {
            get
            {
                return ObjectWrapper.CreateWrapper<NHtmlUnit.BrowserVersion>(
                   com.gargoylesoftware.htmlunit.BrowserVersion.INTERNET_EXPLORER_8);
            }
        }


        public static NHtmlUnit.BrowserVersion INTERNET_EXPLORER_9
        {
            get
            {
                return ObjectWrapper.CreateWrapper<NHtmlUnit.BrowserVersion>(
                   com.gargoylesoftware.htmlunit.BrowserVersion.INTERNET_EXPLORER_9);
            }
        }


        public static NHtmlUnit.BrowserVersion INTERNET_EXPLORER_11
        {
            get
            {
                return ObjectWrapper.CreateWrapper<NHtmlUnit.BrowserVersion>(
                   com.gargoylesoftware.htmlunit.BrowserVersion.INTERNET_EXPLORER_11);
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