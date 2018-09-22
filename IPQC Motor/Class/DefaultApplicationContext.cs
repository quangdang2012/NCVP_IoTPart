using System;
using System.Windows.Forms;

namespace IPQC_Motor
{
    public class DefaultApplicationContext : ApplicationContext
    {

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="assemblyname"></param>
        /// <param name="typename"></param>
        /// <param name="appricationname"></param>
        /// <param name="passwordCheckNeeded"></param>
        public DefaultApplicationContext(string applicationname)
        {

            //initialize the DefaultApplicationInitializer
            DefaultApplicationInitializer.GetInstance().Init();

     

        }

        /// <summary>
        /// exit application on form close event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormClosed(object sender, EventArgs e)
        {
            ExitThread();
        }
    }
}
