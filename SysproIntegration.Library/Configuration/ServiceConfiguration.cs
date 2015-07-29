using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysproIntegration.Library.Configuration
{
    public class ServiceElement : ConfigurationSection
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

        [ConfigurationProperty("username", IsRequired = false)]
        public string UserName
        {
            get { return (string)this["username"]; }
            set { this["username"] = value; }
        }

        [ConfigurationProperty("password", IsRequired = false)]
        public string Password
        {
            get { return (string)this["password"]; }
            set { this["password"] = value; }
        }

        [ConfigurationProperty("url", IsRequired = true)]
        public string Url
        {
            get { return (string)this["url"]; }
            set { this["url"] = value; }
        }

        [ConfigurationProperty("flag", IsRequired = true)]
        public string Flag
        {
            get { return (string)this["flag"]; }
            set { this["flag"] = value; }
        }
    }

    [ConfigurationCollection(typeof(ServiceElement))]
    public class ServiceElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ServiceElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ServiceElement)element).Key;
        }
    }

    public class ServiceElementSection : ConfigurationSection
    {
        [ConfigurationProperty("serviceElements", IsDefaultCollection = true)]
        public ServiceElementCollection ServiceElements
        {
            get { return (ServiceElementCollection)this["serviceElements"]; }
            set { this["serviceElements"] = value; }
        }
    }
}
