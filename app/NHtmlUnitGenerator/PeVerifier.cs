#region License

// --------------------------------------------------
// Copyright © 2003-2011 OKB. All Rights Reserved.
// 
// This software is proprietary information of OKB.
// USE IS SUBJECT TO LICENSE TERMS.
// --------------------------------------------------

#endregion

using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace NHtmlUnit.Generator
{
    public class PeVerifier
    {
        // TODO: Implement detection of PEVerify path
        private readonly string commandPath;
        private readonly bool doNotRun;


        public PeVerifier()
        {
            this.commandPath =
                Type.GetType("Mono.Runtime") != null
                    ? @"/usr/bin/peverify"
                    : @"C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Bin\NETFX 4.0 Tools\peverify.exe";

            this.commandPath = Environment.GetEnvironmentVariable("PE_VERIFY_PATH") ?? this.commandPath;

            if (!File.Exists(this.commandPath))
            {
                this.doNotRun = true;
                Console.WriteLine("Warning: Could not locate PEVerify.exe, we will assume that assemblies are OK.");
            }
        }


        public bool Verify(string imagePath, out string peVerifyOutput)
        {
            if (this.doNotRun)
            {
                peVerifyOutput = "Not running PEVerify, don't know where it's at!";
                return true;
            }

            ProcessStartInfo processStartInfo = new ProcessStartInfo(this.commandPath, imagePath)
            {
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };

            bool result;

            using (Process proc = new Process { StartInfo = processStartInfo })
            {
                proc.Start();
                StringBuilder output = new StringBuilder();

                do
                {
                    Thread.Sleep(100);

                    output.Append(proc.StandardOutput.ReadToEnd());
                    output.Append(proc.StandardError.ReadToEnd());
                } while (!proc.HasExited);

                peVerifyOutput = output.ToString();

                result = proc.ExitCode == 0;
            }

            return result;
        }
    }
}