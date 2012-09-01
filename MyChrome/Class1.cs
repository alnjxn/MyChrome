using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MyChrome
{
  class Class1
  {
    public static void Main()
    {
      string s = @"c:\sites.txt";
      if (File.Exists(s))
      {
        try
        {
          int i = 0;
          string line;

          System.IO.StreamReader file =
             new System.IO.StreamReader("c:\\sites.txt");
          while ((line = file.ReadLine()) != null)
          {
            System.Diagnostics.Process.Start(line);
            System.Threading.Thread.Sleep(1500);
            i++;
          }

          file.Close();
        }
        catch (Exception e)
        {
          MessageBox.Show(e.Message);
          //Console.WriteLine(e.Message);
        }
      }
      else
      {
        MessageBox.Show("Sites file does not exist on this machine.\nPlease create c:\\sites.txt file to complete this action.", "Error");
      }
    }
  }
}
