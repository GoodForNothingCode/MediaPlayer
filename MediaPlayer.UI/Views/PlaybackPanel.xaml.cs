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
using MediaPlayer.Common;
using MediaPlayer.Common.Events;

namespace MediaPlayer.UI.Views
{
    /// <summary>
    /// Interaction logic for PlaybackPanel.xaml
    /// </summary>
    public partial class PlaybackPanel : UserControl
    {
        public PlaybackPanel()
        {
            InitializeComponent();
            MediaController.MediaEvent.MediaPlay += MediaEvent_MediaPlay;
            MediaController.MediaEvent.MediaStop += MediaEvent_MediaStop;
            MediaController.MediaEvent.MediaPause += MediaEvent_MediaPause;
            MediaController.MediaEvent.MediaPositionChanged += MediaEvent_MediaPositionChanged;
        }

        void MediaEvent_MediaPositionChanged(object sender, EventArgs e)
        {
            UpdateSeekBarValue();
        }

        void MediaEvent_MediaPause(object sender, EventArgs e)
        {
            PlayPause_Button.Content = Constants.PLAYPAUSE_BUTTON_PLAY_LABEL;
        }

        void MediaEvent_MediaStop(object sender, EventArgs e)
        {
            PlayPause_Button.Content = Constants.PLAYPAUSE_BUTTON_PLAY_LABEL;
            MediaController.Position = new TimeSpan(0, 0, 0, 0, 0);
            UpdateSeekBarValue();
        }

        void MediaEvent_MediaPlay(object sender, EventArgs e)
        {
            PlayPause_Button.Content = Constants.PLAYPAUSE_BUTTON_PAUSE_LABEL;
        }

        #region Private Methods
        
        private void UpdateSeekBarValue()
        {
            SeekBar_Slider.Maximum = MediaController.Duration;
            SeekBar_Slider.ValueChanged -= SeekBar_Slider_ValueChanged;
            SeekBar_Slider.Value = MediaController.Position.TotalMilliseconds;
            SeekBar_Slider.ValueChanged += SeekBar_Slider_ValueChanged;
        }

        #endregion

        #region Event Handlers

        private void Play_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MediaController.IsPlaying)
            {
                MediaController.Pause();   
            }
            else
            {
                MediaController.Play();
            }
        }

        private void Stop_Button_Click(object sender, RoutedEventArgs e)
        {
            MediaController.Stop();   
        }

        private void Prev_Button_Click(object sender, RoutedEventArgs e)
        {
            MediaController.Prev();
        }

        private void Next_Button_Click(object sender, RoutedEventArgs e)
        {
            MediaController.Next();
        }

        private void SeekBar_Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaController.Position = new TimeSpan(0, 0, 0, 0, (int)SeekBar_Slider.Value);
        }

        #endregion

    }
}
