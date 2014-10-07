using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MediaPlayer.UI.Controllers;
using MediaPlayer.Common.Events;

namespace MediaPlayer.UI.Views
{
    /// <summary>
    /// Interaction logic for MediaPanel.xaml
    /// </summary>
    public partial class MediaPanel : UserControl
    {
        public double Duration
        {
            get
            {
                if(this.PlaybackElement.NaturalDuration.HasTimeSpan)
                    return this.PlaybackElement.NaturalDuration.TimeSpan.TotalMilliseconds;
                return 0;
            }
        }

        public TimeSpan Position
        {
            get
            {
                return this.PlaybackElement.Position;
            }
            set
            {
                this.PlaybackElement.Position = value;
            }
        }

        public MediaPanel()
        {
            InitializeComponent();
            this.PlaybackElement.LoadedBehavior = MediaState.Manual;
            this.PlaybackElement.UnloadedBehavior = MediaState.Stop;

            MediaController.MediaEvent.MediaPlay += MediaEvent_MediaPlay;
            MediaController.MediaEvent.MediaStop += MediaEvent_MediaStop;
            MediaController.MediaEvent.MediaPause += MediaEvent_MediaPause;
            MediaController.MediaEvent.MediaFileLoaded += MediaEvent_MediaFileLoaded;
        }

        void MediaEvent_MediaFileLoaded(object sender, MediaFileLoadedEventArgs e)
        {
            this.PlaybackElement.Source = e.FilePath;
        }

        void MediaEvent_MediaPause(object sender, EventArgs e)
        {
            this.PlaybackElement.Pause();
        }

        void MediaEvent_MediaStop(object sender, EventArgs e)
        {
            this.PlaybackElement.Stop();
        }

        void MediaEvent_MediaPlay(object sender, EventArgs e)
        {
            this.PlaybackElement.Play();
        }
    }

    
}
