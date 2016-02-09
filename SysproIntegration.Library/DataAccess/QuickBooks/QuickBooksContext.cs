using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QbSync.QbXml.Objects;
using SysproIntegration.Library.Configuration;
using SysproIntegration.Library.Interfaces;
using SysproIntegration.Library.External;
using SysproIntegration.Library.Infrastructure;
using System.Xml;
using Interop.QBXMLRP2Lib;

namespace SysproIntegration.Library.DataAccess.QuickBooks
{
    public class QuickBooksContext : IDataBaseFileContext<QuickBooksXml>,System.IDisposable
    {
        private readonly IConfig _config;
        private readonly FileElement _fileElement;
        bool _disposed;        
        RequestProcessor2 _request = null;
        string _ticket = string.Empty;
       
        public QuickBooksContext(IConfig config)
        {
            this._config = config;
            this._fileElement = _config.GetFileConfiguration();
            _request=new RequestProcessor2();
        }

        public QuickBooksContext(string key) : this(new SysproConfig(key))
        {
            
        }

        public QuickBooksContext() : this(new SysproConfig(Constants.DefaultQbFileConnectionKey))
        {
            
        }

        public QuickBooksContext(FileElement fileElement)
        {
            this._fileElement = fileElement;
            _request = new RequestProcessor2();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public QuickBooksXml Connect(XmlDocument xmlDoc)
        {
            var qbXml = new QuickBooksXml();            
            _request.OpenConnection2("", _fileElement.Name, QBXMLRPConnectionType.localQBDLaunchUI);
            _ticket = _request.BeginSession(_fileElement.Path, Interop.QBXMLRP2Lib.QBFileMode.qbFileOpenSingleUser);
            StringBuilder reqBuildXml = new StringBuilder("<?xml version=\"1.0\"?>");
            reqBuildXml.Append("<?qbxml version=\"8.0\"?>");
            reqBuildXml.Append(xmlDoc.OuterXml);
            var xml= _request.ProcessRequest(_ticket, reqBuildXml.ToString());            
            qbXml.InnerXml = xml;
            return qbXml;
                       
        }        
       
         /// <summary>
         /// 
         /// </summary>
         /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                // free other managed objects that implement
                // IDisposable only
            }
            if (_request != null)
            {
                _request.EndSession(_ticket);
                _request.CloseConnection();
                _request = null;
            }

            // release any unmanaged objects
            // set the object references to null
            _disposed = true;
        }
        /// <summary>
        /// 
        /// </summary>
        ~QuickBooksContext()
        {
            Dispose(false);
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
