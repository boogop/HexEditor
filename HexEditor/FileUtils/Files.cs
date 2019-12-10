using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HexEditor.FileUtils
{
    internal class Files
    {
        private string _hex;

        internal string theHex
        {
            get { return _hex; }
            set { _hex = value; }
        }

        private string _text;

        internal string theText
        {
            get { return _text; }
            set { _text = value; }
        }


        internal void processFile(string filename)
        {
            byte[] bytes = File.ReadAllBytes(filename);

            string hex = BitConverter.ToString(bytes);

            _hex = GeneralTools.ReplaceEx(hex, "-", " ");

            string foo = "";

            Task t = Task.Run(() =>
            {
                foo = Encoding.ASCII.GetString(bytes).Replace((char)0, '.');
            });

            t.Wait();

            _text = GeneralTools.ReplaceEx(foo, "?", ".");
        }

        internal bool copyRename(string srcPath, string srcFileName, string destFileName)
        {
            string dest = GeneralTools.Replace(srcPath, srcFileName, destFileName);
            FileInfo fs = new FileInfo(srcPath);
            fs.CopyTo(dest);

            if (File.Exists(dest)) return true;

            return false;
        }

        internal string ConvertStringToHex(string asciiString)
        {
            string hex = "";
            foreach (char c in asciiString)
            {
                int tmp = c;
                hex += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
            }
            return hex;
        }

        internal string ConvertHexToString(string HexValue)
        {
            string StrValue = "";
            while (HexValue.Length > 0)
            {
                StrValue += System.Convert.ToChar(System.Convert.ToUInt32(HexValue.Substring(0, 2), 16)).ToString();
                HexValue = HexValue.Substring(2, HexValue.Length - 2);
            }
            return StrValue;
        }

        internal void ReplaceTextInBinaryFile(string originalFile, string outputFile, string searchTerm, string replaceTerm)
        {
            byte b;
            //UpperCase bytes to search
            byte[] searchBytes = Encoding.UTF8.GetBytes(searchTerm.ToUpper());
            //LowerCase bytes to search
            byte[] searchBytesLower = Encoding.UTF8.GetBytes(searchTerm.ToLower());
            //Temporary bytes during found loop
            byte[] bytesToAdd = new byte[searchBytes.Length];
            //Search length
            int searchBytesLength = searchBytes.Length;
            //First Upper char
            byte searchByte0 = searchBytes[0];
            //First Lower char
            byte searchByte0Lower = searchBytesLower[0];
            //Replace with bytes
            byte[] replaceBytes = Encoding.UTF8.GetBytes(replaceTerm);
            int counter = 0;
            using (FileStream inputStream = File.OpenRead(originalFile))
            {
                //input length
                long srcLength = inputStream.Length;
                using (BinaryReader inputReader = new BinaryReader(inputStream))
                {
                    using (FileStream outputStream = File.OpenWrite(outputFile))
                    {
                        using (BinaryWriter outputWriter = new BinaryWriter(outputStream))
                        {
                            for (int nSrc = 0; nSrc < srcLength; ++nSrc)
                                //first byte
                                if ((b = inputReader.ReadByte()) == searchByte0 || b == searchByte0Lower)
                                {
                                    bytesToAdd[0] = b;
                                    int nSearch = 1;
                                    //next bytes
                                    for (; nSearch < searchBytesLength; ++nSearch)
                                        //get byte, save it and test
                                        if ((b = bytesToAdd[nSearch] = inputReader.ReadByte()) != searchBytes[nSearch]
                                            && b != searchBytesLower[nSearch])
                                        {
                                            break;//fail
                                        }
                                    //Avoid overflow. No need, in my case, because no chance to see searchTerm at the end.
                                    //else if (nSrc + nSearch >= srcLength)
                                    //    break;

                                    if (nSearch == searchBytesLength)
                                    {
                                        //success
                                        ++counter;
                                        outputWriter.Write(replaceBytes);
                                        nSrc += nSearch - 1;
                                    }
                                    else
                                    {
                                        //failed, add saved bytes
                                        outputWriter.Write(bytesToAdd, 0, nSearch + 1);
                                        nSrc += nSearch;
                                    }
                                }
                                else
                                    outputWriter.Write(b);
                        }
                    }
                }
            }
        }

        internal static UInt16 GetWord(byte[] buffer, UInt32 offset)
        {
            UInt16 val = (UInt16)(buffer[offset + 1] << 8);
            val += (UInt16)(buffer[offset + 0]);
            return val;
        }

        internal static UInt32 GetDword(byte[] buffer, UInt32 offset)
        {
            return ((UInt32)(buffer[offset + 3]) << 24) +
                   ((UInt32)(buffer[offset + 2]) << 16) +
                   ((UInt32)(buffer[offset + 1]) << 8) +
                   ((UInt32)(buffer[offset + 0]));
        }

        internal double GetDouble(byte[] buffer, UInt32 offset)
        {
            double d = 0;

            // ReadDouble() can read a IEEE 8-byte double
            // straight from a buffer
            using (MemoryStream mem = new MemoryStream())
            {
                BinaryWriter bw = new BinaryWriter(mem);

                for (UInt32 i = 0; i < 8; i++)
                    bw.Write(buffer[offset + i]);

                mem.Seek(0, SeekOrigin.Begin);

                BinaryReader br = new BinaryReader(mem);
                d = br.ReadDouble();
                br.Close();
                bw.Close();
            }

            return d;
        }

        internal static String GetString(byte[] buffer, UInt32 offset, UInt32 len)
        {
            StringBuilder sb = new StringBuilder((int)len);
            for (UInt32 i = offset; i < offset + 2 * len; i += 2)
                sb.Append((Char)GetWord(buffer, i));
            return sb.ToString();
        }

        internal static bool GetRecordID(byte[] buffer, ref UInt32 offset, ref UInt32 recid)
        {
            recid = 0;

            if (offset >= buffer.Length)
                return false;
            byte b1 = buffer[offset++];
            recid = (UInt32)(b1 & 0x7F);

            if ((b1 & 0x80) == 0)
                return true;

            if (offset >= buffer.Length)
                return false;
            byte b2 = buffer[offset++];
            recid = ((UInt32)(b2 & 0x7F) << 7) | recid;

            if ((b2 & 0x80) == 0)
                return true;

            if (offset >= buffer.Length)
                return false;
            byte b3 = buffer[offset++];
            recid = ((UInt32)(b3 & 0x7F) << 14) | recid;

            if ((b3 & 0x80) == 0)
                return true;

            if (offset >= buffer.Length)
                return false;
            byte b4 = buffer[offset++];
            recid = ((UInt32)(b4 & 0x7F) << 21) | recid;

            return true;
        }

    }
}
