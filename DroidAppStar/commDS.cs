using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DroidAppStar
{
    class commDS
    {
        public static string consoleOutputText = "";
        Form1 frm1 = (Form1)Application.OpenForms["Form1"];

        public string execCommand(string args) {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c " + args;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.Start();
            do
            {
                Application.DoEvents();
            } while (!p.HasExited);
            //p.WaitForExit();
            consoleOutputText = p.StandardOutput.ReadToEnd();
            if (consoleOutputText == "")
            {
                consoleOutputText = p.StandardError.ReadToEnd();
            }
            RichTextBox rt = Application.OpenForms["Form1"].Controls["gradientPanel1"].Controls["groupBox3"].Controls["rtxConsole"] as RichTextBox;
            if (consoleOutputText != "")
            {
                rt.AppendText("\n" + RemoveEmptyLines(consoleOutputText) + "\n");
            }
            return consoleOutputText;
        }

        public string RemoveEmptyLines(string lines)
        {
            return Regex.Replace(lines, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).TrimEnd();
        }

    }
}
