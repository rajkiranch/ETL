using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysproETLApp
{
    public class CompositionRoot
    {
        /// <summary>
        /// 
        /// </summary>
        private static IKernel _ninjectKernel;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="module"></param>
        public static void Wire(INinjectModule module)
        {
            _ninjectKernel = new StandardKernel(module);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Resolve<T>()
        {
            return _ninjectKernel.Get<T>();
        }
    }
}
