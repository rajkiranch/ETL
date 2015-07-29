using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysproIntegration.Library.Configuration
{
    public class FileElement : ConfigurationSection
    {
        [ConfigurationProperty("key", IsRequired = true, IsKey = true)]
        public string Key
        {
            get { return (string)this["key"]; }
            set { this["key"] = value; }
        }

        [ConfigurationProperty("name", IsRequired = false)]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("value", IsRequired = false)]
        public string Value
        {
            get { return (string)this["value"]; }
            set { this["value"] = value; }
        }
        [ConfigurationProperty("maxrecords", IsRequired = false)]
        public int MaxRecords
        {
            get { return (int)this["maxrecords"]; }
            set { this["maxrecords"] = value; }
        }

        [ConfigurationProperty("path", IsRequired = true)]
        public string Path
        {
            get { return (string)this["path"]; }
            set { this["path"] = value; }
        }
        [ConfigurationProperty("flag", IsRequired = true)]
        public string Flag
        {
            get { return (string)this["flag"]; }
            set { this["flag"] = value; }
        }

    }

    public class FileElementSection : ConfigurationSection
    {
        [ConfigurationProperty("fileElements", IsDefaultCollection = true)]
        public FileElementCollection FileElements
        {
            get { return (FileElementCollection)this["fileElements"]; }
            set { this["fileElements"] = value; }
        }
    }

    [ConfigurationCollection(typeof(FileElement))]
    public class FileElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new FileElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((FileElement)element).Key;
        }
    }
}
