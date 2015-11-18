#region License

// --------------------------------------------------
// Copyright © 2003-2011 OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

using NHtmlUnit.Html.Impl;

namespace NHtmlUnit.Html
{
    public partial class HtmlTextArea
    {
        IPage ISelectableTextInput.Page
        {
            get { return Page; }
        }
    }
}