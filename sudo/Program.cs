//Copyright 2020 Joseph Still
//thetechconspiracy@outlook.com


using System;
using System.Diagnostics;


namespace sudo
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0) { //No args, so can't do anything.  Don't bother running.
                Environment.Exit(1);
            }

            //Create arguments string
            string cmdArgs = "/c \"";
            foreach (string arg in args){
                cmdArgs += arg;
            }
            cmdArgs += "\"";

            //Create process
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = "cmd.exe";
            ExternalProcess.StartInfo.Arguments = cmdArgs;

            //Start
            ExternalProcess.Start();
            ExternalProcess.WaitForExit();

            //Allow user to read output
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            
        }
    }
}
