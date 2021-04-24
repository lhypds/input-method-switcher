using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputMethodQuickSwitcher
{
    class KeyBind
    {
        public static List<string> GetKeyBindList()
        {
            if (!File.Exists(Consts.KEY_BIND_LIST)) File.Create(Consts.KEY_BIND_LIST).Close();
            List<string> keyBindList = new List<string>();

            // Read key bind list
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(Consts.KEY_BIND_LIST))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        keyBindList.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                MessageBox.Show("The file could not be read: " + e.Message, "Message");
            }
            return keyBindList;
        }

        public static string GetKeyBind(string inputMethodStr, string cultureStr)
        {
            if (!File.Exists(Consts.KEY_BIND_LIST)) File.Create(Consts.KEY_BIND_LIST).Close();
            string keyCode = "None";

            // Read key bind list
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(Consts.KEY_BIND_LIST))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lineStrs = line.Split(',');
                        if (lineStrs[0].Equals(inputMethodStr) && lineStrs[1].Equals(cultureStr))
                            return lineStrs[2];
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                MessageBox.Show("The file could not be read: " + e.Message, "Message");
            }
            return keyCode;
        }

        public static bool SaveKeyBind(string inputMethodStr, string cultureStr, string keyCode)
        {
            if (!File.Exists(Consts.KEY_BIND_LIST)) File.Create(Consts.KEY_BIND_LIST).Close();
            List<string[]> configStringList = new List<string[]>();

            // Read key bind list
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(Consts.KEY_BIND_LIST))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lineStrs = line.Split(',');
                        configStringList.Add(lineStrs);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                MessageBox.Show("The file could not be read: " + e.Message, "Message");
                return false;
            }

            // Modify
            bool isFound = false;
            foreach (string[] config in configStringList)
            {
                if (config[0].Equals(inputMethodStr) && config[1].Equals(cultureStr))
                {
                    isFound = true;
                    config[2] = keyCode;
                }
            }

            // If not found config, add one
            if (!isFound)
            {
                configStringList.Add(new string[] { inputMethodStr, cultureStr, keyCode });
            }

            // Write key bind list
            using (StreamWriter sw = new StreamWriter(Consts.KEY_BIND_LIST))
            {
                foreach (string[] config in configStringList)
                {
                    sw.WriteLine(config[0] + ',' + config[1] + ',' + config[2]);
                }
            }
            return true;
        }

        public static bool RemoveKeyBind(string inputMethodStr, string cultureStr)
        {
            if (!File.Exists(Consts.KEY_BIND_LIST)) File.Create(Consts.KEY_BIND_LIST).Close();
            List<string[]> configStringList = new List<string[]>();

            // Read key bind list
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(Consts.KEY_BIND_LIST))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] lineStrs = line.Split(',');
                        configStringList.Add(lineStrs);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                MessageBox.Show("The file could not be read: " + e.Message, "Message");
                return false;
            }

            // Modify
            List<string[]> configStringListBuf = new List<string[]>(configStringList);
            foreach (string[] config in configStringListBuf)
            {
                if (config[0].Equals(inputMethodStr) && config[1].Equals(cultureStr))
                {
                    configStringList.Remove(config);
                }
            }

            // Write key bind list
            using (StreamWriter sw = new StreamWriter(Consts.KEY_BIND_LIST))
            {
                foreach (string[] config in configStringList)
                {
                    sw.WriteLine(config[0] + ',' + config[1] + ',' + config[2]);
                }
            }
            return true;
        }

        public static void OpenKeyBindWithNotepad()
        {
            if (!File.Exists(Consts.KEY_BIND_LIST)) File.Create(Consts.KEY_BIND_LIST).Close();
            Process.Start("Notepad.exe", Consts.KEY_BIND_LIST);
        }
    }
}
