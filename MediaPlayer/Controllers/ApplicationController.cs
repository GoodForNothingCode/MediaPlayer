using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MediaPlayer.UI.Controllers
{
    /// <summary>
    /// Media Player application operations
    /// </summary>
    public static class ApplicationController
    {
        public static void Exit(System.Windows.Window window)
        {
            //Shutdown sequence

            window.Close();
        }
    }
}
