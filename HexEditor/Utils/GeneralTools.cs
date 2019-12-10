using System;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;

namespace HexEditor
{
  /// <summary>
  /// Some general utility functions, frequently duplicating handy
  /// VB6 functions that MS left out of C#. Some of these stem from
  /// the .NET 1.0 days when the libraries weren't mature
  /// </summary>
  internal sealed class GeneralTools
  {
    


    internal static bool IsWindows8OrNewer()
    {
      OperatingSystem os = Environment.OSVersion;
      return os.Platform == PlatformID.Win32NT &&
             (os.Version.Major > 6 || (os.Version.Major == 6 && os.Version.Minor >= 2));
    }
    
    internal static void DeleteFiles(string path)
    {
      string[] dirs = null;
      try
      {
        dirs = Directory.GetFiles(path);
      }
      catch
      {
        try
        {
          Directory.CreateDirectory(path);
        }
        catch
        {
          return;
        }
      }

      try
      {
        foreach (string dir in dirs)
        {
          File.Delete(dir);
        }
      }
      catch
      {
        return;
      }
    }

    internal static void DeleteFiles(string path, string ext)
    {
      string[] dirs = null;
      try
      {
        dirs = Directory.GetFiles(path,ext);
      }
      catch
      {
        try
        {
          Directory.CreateDirectory(path);
        }
        catch
        {
          return;
        }
      }

      try
      {
        foreach (string dir in dirs)
        {
          File.Delete(dir);
        }
      }
      catch
      {
        return;
      }
    }

    internal static void DeleteFile(string filename)
    {
      try
      {
        if (File.Exists(filename))
          File.Delete(filename);
      }
      catch { }
    }

   
  
    internal static void ShowTime(Stopwatch s, ToolStripStatusLabel t)
    {
      TimeSpan ts = s.Elapsed;
      t.Text = "Elapsed: " + String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
          ts.Hours, ts.Minutes, ts.Seconds,
          ts.Milliseconds / 10);
    }

    internal static void intRedim(ref int[] myArray)
    {
      // not a good idea but if you ever need to redimension an array here ya go
      int[] Temp1 = new int[myArray.Length + 1];
      if (myArray != null)
        System.Array.Copy(myArray, Temp1, myArray.Length);
      myArray = Temp1;
    }

    internal static void WriteAnythingToFile(string path, string filename, string[] obj)
    {
      // these next two come in very handy for writing settings and crap out
      // to files without having to deal with .net's settings file garbage
      try
      {
        StreamWriter stream_writer = new StreamWriter(path + filename);

        for (int i = 0; i < obj.Length; i++)
          stream_writer.WriteLine(obj[i]);

        stream_writer.Flush();
        stream_writer.Close();
      }
      catch
      {
      }
    }

    internal static void WriteAnythingToFile(string path, string filename, ArrayList obj)
    {
      try
      {
        StreamWriter stream_writer = new StreamWriter(path + filename);

        for (int i = 0; i < obj.Count; i++)
          stream_writer.WriteLine(obj[i]);

        stream_writer.Flush();
        stream_writer.Close();
      }
      catch
      {
      }
    }

    internal static void ReadAnythingFromFile(string filename, ref string[] obj)
    {
      int i;

      if (!File.Exists(filename)) return;

      FileStream file_stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
      StreamReader s = new StreamReader(file_stream);
      string input = null;

      i = 0;

      while ((input = s.ReadLine()) != null)
      {
        obj[i] = input;
        i++;
      }

      file_stream.Close();
    }

    internal static void ReadAnythingFromFile(string filename, ref ArrayList obj)
    {
      // overload. If you need an array and have no clue how many elements
      // are in the text file

      if (!File.Exists(filename)) return;

      FileStream file_stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
      StreamReader s = new StreamReader(file_stream);
      string input = null;

      while ((input = s.ReadLine()) != null)
        obj.Add(input);

      file_stream.Close();
    }

    private static string cleanTextCrap(string foo)
    {
      string s = foo.Replace("\"", "");
      string t = s.Replace(@"\", "");
      return t;
    }

    internal static void GetFiles(DirectoryInfo di, string searchPattern, ref ArrayList MyFiles)
    {
      foreach (FileInfo fi in di.GetFiles(searchPattern))
        MyFiles.Add(fi.Name);

      // Search in subdirectories 
      foreach (DirectoryInfo d in di.GetDirectories())
        GetFiles(d, searchPattern, ref MyFiles);
    }

    internal static string Left(string param, int length)
    {
      string result = param.Substring(0, length);

      return result;
    }

    internal static string Right(string param, int length)
    {
      string result = param.Substring(param.Length - length, length);

      return result;
    }

    internal static string Mid(string param, int startIndex, int length)
    {
      // the mid function is heavily used in VBA

      //start at the specified index in the string and get N number of
      //characters depending on the lenght and assign it to a variable
      string result = param.Substring(startIndex, length);
      //return the result of the operation
      return result;
    }

    internal static string Mid(string param, int startIndex)
    {
      // overload 

      //start at the specified index and return all characters after it
      //and assign it to a variable
      string result = param.Substring(startIndex);
      //return the result of the operation
      return result;
    }

        internal static bool IsNumeric(object Expression)
        {
            // IsNumeric Function. C# is great so why didn't MS include
            // a basic IsNumeric function???

            bool isNum;
            double retNum;

            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);

            return isNum;
        }

    internal static bool IsDate(string Expression)
    {
      if (!chkNull.isNull(Expression))
      {
        // somehow 7:00 is being evaluated as a valid datetime
        if (Expression.Length < 5) return false;

        try
        {
          System.DateTime dt = System.DateTime.Parse((string)Expression);
          return true;
        }
        catch
        {
          return false;
        }

      }
      return false;
    }

    internal static bool IsDate(object Expression)
    {
      if (!chkNull.isNull(Expression))
      {
        if (Expression is DateTime) return true;

        if (Expression is string)
        {
          try
          {
            System.DateTime dt = System.DateTime.Parse((string)Expression);
            return true;
          }
          catch
          {
            return false;
          }
        }
      }
      return false;
    }
   

    /// <summary>
    /// A case-insensitive replace function
    /// </summary>
    /// <param name="original"></param>
    /// <param name="pattern"></param>
    /// <param name="replacement"></param>
    /// <returns></returns>
    internal static string ReplaceEx(string original, string pattern, string replacement)
    {
      /* this could be done through regex but that's not very efficient and
       * case sensitivity isn't dealt with unless you define the RegExpOption
       * as IgnoreCase so wtf why bother? 
       */
      int count, position0, position1;

      count = position0 = position1 = 0;

      if (chkNull.isNull(original)) return "";

      string upperString = original.ToUpper();
      string upperPattern = pattern.ToUpper();

      int inc = (original.Length / pattern.Length) *
                (replacement.Length - pattern.Length);

      char[] chars = new char[original.Length + Math.Max(0, inc)];

      while ((position1 = upperString.IndexOf(upperPattern, position0)) != -1)
      {
        for (int i = position0; i < position1; ++i)
          chars[count++] = original[i];
        for (int i = 0; i < replacement.Length; ++i)
          chars[count++] = replacement[i];
        position0 = position1 + pattern.Length;
      }

      if (position0 == 0) return original;

      for (int i = position0; i < original.Length; ++i)
        chars[count++] = original[i];

      return new string(chars, 0, count);
    }

    internal static string Replace(string strText, string strFind, string strReplace)
    {
      int iPos = strText.IndexOf(strFind);
      String strReturn = "";

      while (iPos != -1)
      {
        strReturn += strText.Substring(0, iPos) + strReplace;
        strText = strText.Substring(iPos + strFind.Length);
        iPos = strText.IndexOf(strFind);
      }

      if (strText.Length > 0)
        strReturn += strText;

      return strReturn;
    }

    internal static double DateDiff(string howtocompare, System.DateTime startDate, System.DateTime endDate)
    {
      double diff = 0;
      System.TimeSpan TS = new System.TimeSpan(endDate.Ticks - startDate.Ticks);

      switch (howtocompare.ToLower())
      {
        case "year":
          diff = Convert.ToDouble(TS.TotalDays / 365);
          break;
        case "month":
          diff = Convert.ToDouble((TS.TotalDays / 365) * 12);
          break;
        case "day":
          diff = Convert.ToDouble(TS.TotalDays);
          break;
        case "hour":
          diff = Convert.ToDouble(TS.TotalHours);
          break;
        case "minute":
          diff = Convert.ToDouble(TS.TotalMinutes);
          break;
        case "second":
          diff = Convert.ToDouble(TS.TotalSeconds);
          break;
      }

      return diff;
    }

    internal static void ClearForm(Control parent)
    {
      // clears text out of a form
      foreach (Control ctrControl in parent.Controls)
      {
        //Loop through all controls 
        if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.MaskedTextBox)))
          ((System.Windows.Forms.MaskedTextBox)ctrControl).Text = string.Empty;
        if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
          ((System.Windows.Forms.TextBox)ctrControl).Text = string.Empty;
        else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
          ((System.Windows.Forms.RichTextBox)ctrControl).Text = string.Empty;
        else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
          ((System.Windows.Forms.ComboBox)ctrControl).SelectedIndex = -1;
        else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
          ((System.Windows.Forms.CheckBox)ctrControl).Checked = false;
        else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
          ((System.Windows.Forms.RadioButton)ctrControl).Checked = false;
                //else if (object.ReferenceEquals(ctrControl.GetType(), typeof(DevExpress.XtraEditors.ComboBoxEdit)))
                //    ((DevExpress.XtraEditors.ComboBoxEdit)ctrControl).Text = "";
                //else if (object.ReferenceEquals(ctrControl.GetType(), typeof(DevExpress.XtraEditors.TextEdit)))
                //    ((DevExpress.XtraEditors.TextEdit)ctrControl).Text = "";
                //else if (object.ReferenceEquals(ctrControl.GetType(), typeof(DevExpress.XtraEditors.SpinEdit)))
                //    ((DevExpress.XtraEditors.SpinEdit)ctrControl).Text = "";
                //else if (object.ReferenceEquals(ctrControl.GetType(), typeof(DevExpress.XtraEditors.CheckEdit)))
                //    ((DevExpress.XtraEditors.CheckEdit)ctrControl).Checked = false;
                //else if (object.ReferenceEquals(ctrControl.GetType(), typeof(DevExpress.XtraEditors.MemoEdit)))
                //    ((DevExpress.XtraEditors.MemoEdit)ctrControl).Text = "";

                if (ctrControl.Controls.Count > 0)
          ClearForm(ctrControl);
      }
    }

    internal static void ClearForm(Control parent, ArrayList toSkip)
    {
      // clears text out of a form
      foreach (Control ctrControl in parent.Controls)
      {
        if (toSkip.Contains(ctrControl.Name)) continue;

        //Loop through all controls 
        if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.MaskedTextBox)))
          ((System.Windows.Forms.MaskedTextBox)ctrControl).Text = string.Empty;
        if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
          ((System.Windows.Forms.TextBox)ctrControl).Text = string.Empty;
        else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
          ((System.Windows.Forms.RichTextBox)ctrControl).Text = string.Empty;
        else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
          ((System.Windows.Forms.ComboBox)ctrControl).SelectedIndex = -1;
        else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
          ((System.Windows.Forms.CheckBox)ctrControl).Checked = false;
        else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
          ((System.Windows.Forms.RadioButton)ctrControl).Checked = false;
                //else if (object.ReferenceEquals(ctrControl.GetType(), typeof(DevExpress.XtraEditors.ComboBoxEdit)))
                //    ((DevExpress.XtraEditors.ComboBoxEdit)ctrControl).Text = "";
                //else if (object.ReferenceEquals(ctrControl.GetType(), typeof(DevExpress.XtraEditors.TextEdit)))
                //    ((DevExpress.XtraEditors.TextEdit)ctrControl).Text = "";
                //else if (object.ReferenceEquals(ctrControl.GetType(), typeof(DevExpress.XtraEditors.SpinEdit)))
                //    ((DevExpress.XtraEditors.SpinEdit)ctrControl).Text = "";
                //else if (object.ReferenceEquals(ctrControl.GetType(), typeof(DevExpress.XtraEditors.CheckEdit)))
                //    ((DevExpress.XtraEditors.CheckEdit)ctrControl).Checked = false;
                //else if (object.ReferenceEquals(ctrControl.GetType(), typeof(DevExpress.XtraEditors.MemoEdit)))
                //    ((DevExpress.XtraEditors.MemoEdit)ctrControl).Text = "";

                if (ctrControl.Controls.Count > 0)
          ClearForm(ctrControl);
      }
    }

    internal static bool IsPhoneNumber(string number)
    {   
      // ugh
      return Regex.Match(number, @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$").Success;
    }   

    internal static double TruncateSignificant(double num, int digits)
    {
      // rounding is a serious problem around here and I find it happening
      // a lot
      if (digits < 1) return num;

      if (num == 0) return num;

      int p;
      double f;

      p = (int)Math.Ceiling(Math.Log10(num));
      f = Math.Pow(10, digits - p);

      return ((int)(num * f)) / f;
    }

    internal static string RemoveTrailingZeroes(string input)
    {
      // regular expressions have their utility but I try to avoid
      // them because they're unreadable
      Regex reg1 = new Regex("\\.\\d*(?<1>0+)[^\\d]*$", RegexOptions.IgnoreCase);

      Match m = reg1.Match(input);
      if (m.Success)
      {
        input = input.Replace(m.Groups["1"].Value, "");
        Regex reg2 = new Regex("(?<1>\\.)[^\\d]*$", RegexOptions.IgnoreCase);
        m = reg2.Match(input);

        if (m.Success)
          input = input.Replace(".", "");

        Regex reg3 = new Regex("\\d", RegexOptions.IgnoreCase);
        m = reg3.Match(input);

        if (!m.Success)
          input = "0" + input;
      }

      if (input.StartsWith("."))
        input = "0" + input;

      return input;
    }

    internal static string formatMoney(object s)
    {
      // keeps me from having to do a format with args each
      // time I need a money val        
      return String.Format("{0:C}", s);
    }

    internal static string formatMoney(object s, bool na, bool includeZeroVals)
    {
      if (na && chkNull.numNull(s) < 0) return "N/A";
      if (na && includeZeroVals && chkNull.numNull(s) <= 0) return "N/A";
      // keeps me from having to do a format with args each
      // time I need a money val        
      return String.Format("{0:C}", s);
    }

    internal static string formatShortDate(object o)
    {
      // the f is this
      try
      {
        if (IsDate(o))
        {
          DateTime d = Convert.ToDateTime(o);
          return String.Format("{0:MM/dd/yy}", d);
        }
        else
          return String.Format("{0:MM/dd/yy}", o);
      }
      catch
      {
        return o.ToString();
      }
    }
   
    internal static double Truncate(double value, int precision)
    {
      return Math.Truncate(value * Math.Pow(10, precision)) / Math.Pow(10, precision);
    }

    internal static bool isValidEmail(string email)
    {
      Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
      Match match = regex.Match(email);
      if (match.Success)
        return true;
      else
        return false;
    }
  
  }
}
