using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EasyChat_Client_FrontEnd
{
    class Updater
    {
        const int currentMajorVersion = 1;
        const int currentMinorVersion = 0;
        const int currentHotFixVersion = 1;

        private const string appInfoURL =
            "https://raw.githubusercontent.com/qEasyChat/EasyChat-Client-FrontEnd/master/app-info.xml";

        public string checkNewVersion()
        {
            List<int> versionList = getServerVersion();
            int ServerMajorVersion = versionList[0];

        }

        private List<int> getServerVersion()
        {
            List<int> versionList = new List<int>();
            using (var reader = new XmlTextReader(appInfoURL))
            {
                while (reader.Read())
                {

                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "version")
                    {
                        string fullVersionString = reader.Value;
                        string[] versionValues = fullVersionString.Split('.');
                        int serverMajorVersion = Convert.ToInt32(versionValues[0]);
                        int serverMinorVersion = Convert.ToInt32(versionValues[1]);
                        int serverHotFixVersion = Convert.ToInt32(versionValues[2]);
                        versionList.Add(serverMajorVersion);
                        versionList.Add(serverMinorVersion);
                        versionList.Add(serverHotFixVersion);
                    }

                }
            }

            return versionList;
        }

    }

}
