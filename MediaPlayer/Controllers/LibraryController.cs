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
        public static void AddSong()
        {
            FileLoader.LoadFile();
        }
    }
}
