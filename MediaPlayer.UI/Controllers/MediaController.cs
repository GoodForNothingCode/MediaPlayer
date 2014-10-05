using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MediaPlayer.Common.Utilities;
using MediaPlayer.UI;
using MediaPlayer.UI.Views;

namespace MediaPlayer.UI.Controllers
{
    /// <summary>
    /// Operations specific to media
    /// </summary>
    public static class MediaController
    {
        public static void Play()
        {
            FileLoader.GetFilePath();
            
        }

        public static void Stop()
        {

        }

        public static void Pause()
        {

        }
    }
}
