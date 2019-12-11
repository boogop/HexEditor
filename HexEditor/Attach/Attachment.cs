using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HexEditor.Attach
{
    internal class Attachment
    {
        internal string getOutlookAttachment(System.Windows.Forms.DragEventArgs e)
        {
            try
            {
                // we need to get the filename and location from an outlook attachment
                Stream theStream = (Stream)e.Data.GetData("FileGroupDescriptor");
                byte[] fileGroupDescriptor = new byte[512];

                // read the raw bytes
                theStream.Read(fileGroupDescriptor, 0, 512);

                StringBuilder fileName = new StringBuilder("");

                // by extracting the filename from the 512-byte file header we can avoid using the 
                // pain in the butt outlook namespace
                // starts at byte 76
                for (int i = 76; i < fileGroupDescriptor.Length; i++)
                {
                    if (fileGroupDescriptor[i] == 0) break;
                    fileName.Append(Convert.ToChar(fileGroupDescriptor[i]));
                }

                theStream.Close();

                // find the temp directory
                string path = Path.GetTempPath();

                // append the filename to it
                string theFile = path + fileName.ToString();

                // copy the bytes to the file above
                MemoryStream ms = e.Data.GetData("FileContents", true) as MemoryStream;

                byte[] fileBytes = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(fileBytes, 0, (int)ms.Length);
                FileStream fs = new FileStream(theFile, FileMode.Create);
                fs.Write(fileBytes, 0, (int)fileBytes.Length);
                fs.Close();

                return theFile;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
