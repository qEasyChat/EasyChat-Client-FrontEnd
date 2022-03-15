using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace EasyChat_Client_FrontEnd
{
    class Updater
    {
        const int CURRENT_MAJOR_VERSION = 1;
        const int CURRENT_MINOR_VERSION = 1;
        const int CURRENT_HOTFIX_VERSION = 0;

        private string lastVersionURL;
        private List<int> versionList;


        private const string appInfoURL =
            @"https://raw.githubusercontent.com/qEasyChat/EasyChat-Client-FrontEnd/master/app-info.xml";

        public Updater()
        {
            lastVersionURL = "";
            versionList = new List<int>();
            checkServer();
        }

        private void checkServer()
        {
            using (var reader = new XmlTextReader(appInfoURL))
            {
                while (reader.Read())
                {

                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Version")
                    {
                        string fullVersionString = reader.ReadElementContentAsString();
                        string[] versionValues = fullVersionString.Split('.');
                        int serverMajorVersion = Convert.ToInt32(versionValues[0]);
                        int serverMinorVersion = Convert.ToInt32(versionValues[1]);
                        int serverHotFixVersion = Convert.ToInt32(versionValues[2]);
                        versionList.Add(serverMajorVersion);
                        versionList.Add(serverMinorVersion);
                        versionList.Add(serverHotFixVersion);
                    } else if (reader.NodeType == XmlNodeType.Element && reader.Name == "NewVersionURL")
                    {
                        lastVersionURL = reader.ReadElementContentAsString();
                    }

                }
            }
        }

        public bool isUpdateRequired()
        {
            if (versionList.Count < 3)
            {
                return false;
            }
            int serverMajorVersion = versionList[0];
            int serverMinorVersion = versionList[1];
            int serverHotFixVersion = versionList[2];

            if (serverMajorVersion > CURRENT_MAJOR_VERSION)
            {
                return true;
            }

            if (serverMinorVersion > CURRENT_MINOR_VERSION)
            {
                return true;
            }

            if (serverHotFixVersion > CURRENT_HOTFIX_VERSION)
            {
                return true;
            }

            return false;

        }

        public void update()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(lastVersionURL, "EasyChat-Client-FrontEnd-update.exe");
            }

            string currentPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            File.Move("EasyChat-Client-FrontEnd.exe", "EasyChat-Client-FrontEnd.bak");
            File.Copy("EasyChat-Client-FrontEnd-update.exe", "EasyChat-Client-FrontEnd.exe");

        }
    }

}
