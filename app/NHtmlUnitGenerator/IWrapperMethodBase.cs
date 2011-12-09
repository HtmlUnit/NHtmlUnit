#region License

// --------------------------------------------------
// Copyright © 2003-2011 OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

namespace NHtmlUnit.Generator
{
    public interface IWrapperMethodBase
    {
        WrapperClassInfo ClassInfo { get; }
        WrapperRepository Repository { get; }
    }
}