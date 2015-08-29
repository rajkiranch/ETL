using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using SysproIntegration.Library.Infrastructure;

namespace SysproIntegration.Library.Configuration
{
    public class DatabaseConfiguration
    {
        private static readonly FileElementSection FileElementSection = 
                                ConfigurationManager.GetSection("fileElementSection") as FileElementSection;
        private static readonly ServiceElementSection ServiceElementSection = 
                                ConfigurationManager.GetSection("serviceElementSection") as ServiceElementSection;

        private readonly static Dictionary<string, FileElement> ElementsFile = 
                                                                    new Dictionary<string, FileElement>();
        private readonly static Dictionary<string, ServiceElement> ElementsService = 
                                                                    new Dictionary<string, ServiceElement>();
       
        static DatabaseConfiguration()
        {            
            foreach (FileElement element in FileElementSection.FileElements)
            {
                ElementsFile.Add(element.Key, element);
            }

            foreach (ServiceElement element in ServiceElementSection.ServiceElements)
            {
                ElementsService.Add(element.Key, element);
            }
        }
        public static Dictionary<string, FileElement> DatabaseFileSettings
        {
            get { return ElementsFile; }
        }
        public static Dictionary<string,ServiceElement> DatabaseServiceSettings 
        {
            get { return ElementsService; }
        }

        public static void SaveDatabaseFileSettings(FileElement fileElement)
        {
            string keyFormat = string.Format(Constants.FileElement, fileElement.Key);
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            if (!string.IsNullOrEmpty(fileElement.Flag))
            {
                xmlDoc.SelectSingleNode(keyFormat).Attributes["flag"].Value = fileElement.Flag;
            }
            if (!string.IsNullOrEmpty(fileElement.Name))
            {
                xmlDoc.SelectSingleNode(keyFormat).Attributes["name"].Value = fileElement.Name;
            }
            if (!string.IsNullOrEmpty(fileElement.Path))
            {
                xmlDoc.SelectSingleNode(keyFormat).Attributes["path"].Value = fileElement.Path;
            }
            if (fileElement.MaxRecords > 0)
            {
                xmlDoc.SelectSingleNode(keyFormat).Attributes["maxrecords"].Value = fileElement.MaxRecords.ToString();
            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("fileElementSection/fileElements");

        }

        public static void SaveDatabaseServiceSettings(ServiceElement serviceElement)
        {
            string keyFormat = string.Format(Constants.ServiceElement, serviceElement.Key);
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            if (!string.IsNullOrEmpty(serviceElement.Flag))
            {
                xmlDoc.SelectSingleNode(keyFormat).Attributes["flag"].Value = serviceElement.Flag;
            }
            if (!string.IsNullOrEmpty(serviceElement.Name))
            {
                xmlDoc.SelectSingleNode(keyFormat).Attributes["name"].Value = serviceElement.Name;
            }
            if (!string.IsNullOrEmpty(serviceElement.Url))
            {
                xmlDoc.SelectSingleNode(keyFormat).Attributes["url"].Value = serviceElement.Url;
            }
            if (serviceElement.MaxRecords > 0)
            {
                xmlDoc.SelectSingleNode(keyFormat).Attributes["maxrecords"].Value = serviceElement.MaxRecords.ToString();
            }
            if (!string.IsNullOrEmpty(serviceElement.UserName))
            {
                xmlDoc.SelectSingleNode(keyFormat).Attributes["username"].Value = 
                    serviceElement.UserName.ToString();
            }
            if (!string.IsNullOrEmpty(serviceElement.Password))
            {
                xmlDoc.SelectSingleNode(keyFormat).Attributes["password"].Value =
                    serviceElement.UserName.ToString();
            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("serviceElementSection/serviceElements");

        }
    }
}
