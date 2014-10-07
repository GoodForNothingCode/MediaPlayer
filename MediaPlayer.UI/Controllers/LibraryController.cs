using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaPlayer.Common.Utilities;

namespace MediaPlayer.UI.Controllers
{
    public static class LibraryController
    {
        public static Boolean IsSongLoaded
        {
            get
            {
                if (!String.IsNullOrEmpty(FileLoader.GetFilePath()))
                    return true;
                return false;
            }
        }

        public static void AddSong()
        {
            FileLoader.LoadFile();
        }

        public static Uri GetSong()
        {
            return new Uri(FileLoader.GetFilePath());
        }

    }
}
