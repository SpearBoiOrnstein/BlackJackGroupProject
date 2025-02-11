﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BlackJack
{
    public class SaveData
    {
        public SaveData()
        {

        }
        public SaveData(string fileName)
        {
            this.fileName = fileName;
            if(!fileExist(fileName))
            {
                ResourceManager resourceManager = TextFiles.ResourceManager;
                var filePath = (string)resourceManager.GetObject(fileName);

                var myFile = File.Create(filePath);
                myFile.Close();
            }
        }
        string fileName;
        public bool save(params string[] data)                  //returns true if data was sucessfully save
        {
            if (fileExist(fileName))
            {
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    for (int a = 0; a < data.Length; a++)
                        sw.Write("" + data[a] + '\u00BB');
                    sw.WriteLine();
                    return true;
                }
            }
            File.Create(fileName);
            MessageBox.Show(fileName + " created.");
            return false;
        }
        public bool remove(params string[] data)            //returns bool value if successful, removes line of code.
        {
            if (fileExist(fileName))
            {
                string[] theWholeFile = (File.ReadAllLines(fileName));
                List<string> allData = new List<string>();
                for (int a = 0; a < theWholeFile.Length; a++)
                {
                    if (!theWholeFile[a].Contains(data[0] + '\u00BB'))
                        allData.Add(theWholeFile[a]);
                }
                for (int a = 0; a < allData.Count; a++)
                {
                    for (int b = 1; b < data.Length; b++)
                    {
                        if (allData[a].Contains(data[b] + '\u00BB'))
                            allData.RemoveAt(b);
                    }
                }
                File.WriteAllLines(fileName, allData.ToArray());
                return true;
            }
            File.Create(fileName);
            MessageBox.Show(fileName + " created.");
            return false;
        }

        public bool verify(params string[] data) //returns bool value for matching username, password
        {
            if (fileExist(fileName))
            {
                string[] check = accessData(data);
                string compares = "";
                for (int a = 0; a < data.Length; a++)
                {
                    compares += data[a] + '\u00BB';
                }
                for (int a = 0; a < check.Length; a++)
                {
                    if (check.Length > 0 && check[a].Contains(compares))
                        return true;
                }
                return false;
            }
            File.Create(fileName);
            MessageBox.Show(fileName + " created.");
            return false;
        }
        public bool VerifyUser(params string[] data)
        {
            string res = "";
            if (fileExist(fileName))
            {
                string[] check = accessData(data);

                try
                {
                    for (int a = 0; a < check.Length; a++)
                    {
                        string user = check[a].Split('\u00BB')[0];
                        string pass = check[a].Split('\u00BB')[1];
                        if (user == data[0] && pass == data[1])
                            return true;
                    }
                }
                catch { return false; }
                return false;
            }
            File.Create(fileName);
            MessageBox.Show(fileName + " created.");
            return false;
        }
        public string VerifiedData(params string[] data)
        {
            string res = "";
            if (fileExist(fileName))
            {
                string[] check = accessData(data);
                string compares = "";
                for (int a = 0; a < data.Length; a++)
                {
                    compares += data[a] + '\u00BB';
                }

                for (int a = 0; a < check.Length; a++)
                    {
                        string user = check[a].Split('\u00BB')[0];
                        string pass = check[a].Split('\u00BB')[1];
                        if (check.Length > 0 && check[a].Contains(compares))
                            return check[a];
                    }
                return res;
            }
            File.Create(fileName);
            MessageBox.Show(fileName + " created.");
            return res;
        }
        public string[] accessData(params string[] data) //returns a string of matching information
        {
            if (fileExist(fileName))
            {
                List<string> dataList = new List<string>();
                string fileData = "";
                using (StreamReader sr = File.OpenText(fileName))
                {
                    while ((fileData = sr.ReadLine()) != null)//saves all file data that contains the first parameter
                    {
                        if (fileData.Contains(data[0]))
                        {
                            dataList.Add(fileData);
                        }
                    }
                }

                if (dataList.Count == 0) //insures that there will always be one item returned
                {
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        fileData = sr.ReadLine();
                        if (fileData != null)
                            dataList.Add(fileData);
                        else
                            dataList.Add("empty list");
                    }
                }
                int[] tracking = new int[dataList.Count];
                int trackingCount = 0;
                for (int a = 1; a < data.Length; a++) //the number of parameters sent in
                {
                    for (int b = 0; b < dataList.Count && dataList.Count >= 1; b++)
                    {
                        if (!dataList[b].Contains(data[a]))
                        {
                            tracking[trackingCount] = b;
                            trackingCount++;
                        }
                    }
                    if (trackingCount <= dataList.Count - 1)
                    {
                        int eliminated = 0;
                        for (int b = 0; b < trackingCount; b++)
                        {
                            dataList.RemoveAt(tracking[b] - eliminated);
                            eliminated++;
                        }
                        trackingCount = 0;
                    }
                    trackingCount = 0;
                }
                string[] array = dataList.ToArray();
                return array;
            }
            File.Create(fileName);
            MessageBox.Show(fileName + " created.");
            return null;
        }

        public static bool fileExist(string fileName) //static may be necessary in management to check data, true or false if file exists
        {
           return File.Exists(fileName);
        }
    }
}
