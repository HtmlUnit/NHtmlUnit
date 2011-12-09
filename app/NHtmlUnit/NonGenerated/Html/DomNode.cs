#region License

// --------------------------------------------------
// Copyright © 2003-2011 OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

namespace NHtmlUnit.Html
{
    public partial class DomNode
    {
        public int TreeDepth
        {
            get
            {
                DomNode n = this;
                int depth = 0;

                while (n != null)
                {
                    depth++;
                    n = n.ParentNode;
                }

                return depth;
            }
        }
    }
}