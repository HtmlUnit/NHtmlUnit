#region License

// --------------------------------------------------
// Copyright © 2003-2011 OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

using System;

using NHtmlUnit.Html;

namespace NHtmlUnit.ConsoleTest
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var skj = new HtmlPage(null);

            Console.WriteLine("DONE RUNNING, PRESS ENTER TO QUIT");
            Console.ReadLine();
        }
    }
}