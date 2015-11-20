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
        public static NHtmlUnit.BrowserVersion EDGE
        {
            get
            {
                return ObjectWrapper.CreateWrapper<NHtmlUnit.BrowserVersion>(
                   com.gargoylesoftware.htmlunit.BrowserVersion.EDGE);
            }
        }


        public static NHtmlUnit.BrowserVersion FIREFOX_31
        {
            get
            {
                return ObjectWrapper.CreateWrapper<NHtmlUnit.BrowserVersion>(
                   com.gargoylesoftware.htmlunit.BrowserVersion.FIREFOX_31);
            }
        }


        public static NHtmlUnit.BrowserVersion FIREFOX_38
        {
            get
            {
                return ObjectWrapper.CreateWrapper<NHtmlUnit.BrowserVersion>(
                   com.gargoylesoftware.htmlunit.BrowserVersion.FIREFOX_38);
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