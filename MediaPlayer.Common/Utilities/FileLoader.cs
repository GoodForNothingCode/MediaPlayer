﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Common.Utilities
{
    
    public static class FileLoader
    {
        private static string _FilePath;

        public static void LoadFile()
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.AddExtension = true;
            openFD.DefaultExt = "*.mp3";
            openFD.Filter = "Media Files (*.mp3)|*.mp3";
            openFD.ShowDialog();

            _FilePath = openFD.FileName;
        }
        
        public static string GetFilePath()
        {
            return _FilePath;
        }
    }
}
