using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;
using MediaPlayer.Common.Utilities;
using MediaPlayer.UI;
using MediaPlayer.UI.Views;
using MediaPlayer.Common.Events;

namespace MediaPlayer.UI.Controllers
{
    /// <summary>
    /// Operations specific to media
    /// </summary>
    public static class MediaController
    {
        #region Public Variables
        
        public static MediaEvent MediaEvent = new MediaEvent();

        #endregion

        #region Private Variables

        private static MediaPanel _Media;
        private static DispatcherTimer _MediaTimer;

        #endregion

        #region Public Properties

        public static bool IsPlaying { get; set; }
        public static double Duration
        {
            get
            {
                return _Media.Duration;
            }
        }
        public static TimeSpan Position
        {
            get
            {
                return _Media.Position;
            }
            set
            {
                _Media.Position = value;
            }
        }

        #endregion

        #region Private Properties

        private static bool IsLoaded { get; set; }

        #endregion

        #region Public Methods

        public static void Initalize(MediaPanel media)
        {
            _Media = media;
        }

        public static void Play()
        {
            if (!IsLoaded)
            {
                MediaEvent.FileLoaded(LibraryController.GetSong());
                IsLoaded = true;

                _MediaTimer = new DispatcherTimer();
                _MediaTimer.Interval = TimeSpan.FromMilliseconds(500);
                _MediaTimer.Tick += new EventHandler(SeekBar_Slider_UpdateValue);
                _MediaTimer.Start();
            }
            
            MediaEvent.Play();
            IsPlaying = true;
        }

        public static void Stop()
        {
            MediaEvent.Stop();
            IsPlaying = false;
        }

        public static void Pause()
        {
            MediaEvent.Pause();
            IsPlaying = false;
        }

        public static void Prev()
        {
            //Load previous song
            //Play
        }

        public static void Next()
        {
            //Load next song
            //Play
        }

        #endregion

        #region Private Methods
        
        private static void SeekBar_Slider_UpdateValue(object sender, EventArgs e)
        {
            if (Duration > 0 && Duration == Position.TotalMilliseconds)
                Stop();

            MediaEvent.PositionChanged();
        }

        #endregion
    }
}
