using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer.Common.Events
{
    public class MediaEvent
    {
        public MediaEvent()
        {

        }

        public void Play()
        {
            OnMediaPlay(EventArgs.Empty);
        }

        public void Stop()
        {
            OnMediaStop(EventArgs.Empty);
        }

        public void Pause()
        {
            OnMediaPause(EventArgs.Empty);
        }

        public void PositionChanged()
        {
            OnMediaPositionChanged(EventArgs.Empty);
        }

        public void FileLoaded(Uri filePath)
        {
            var args = new MediaFileLoadedEventArgs();
            args.FilePath = filePath;
            OnMediaFileLoaded(args);
        }

        protected virtual void OnMediaPlay(EventArgs e)
        {
            EventHandler handler = MediaPlay;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnMediaStop(EventArgs e)
        {
            EventHandler handler = MediaStop;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnMediaPause(EventArgs e)
        {
            EventHandler handler = MediaPause;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnMediaPositionChanged(EventArgs e)
        {
            EventHandler handler = MediaPositionChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnMediaFileLoaded(MediaFileLoadedEventArgs e)
        {
            EventHandler<MediaFileLoadedEventArgs> handler = MediaFileLoaded;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler MediaPlay;
        public event EventHandler MediaStop;
        public event EventHandler MediaPause;
        public event EventHandler MediaPositionChanged;
        public event EventHandler<MediaFileLoadedEventArgs> MediaFileLoaded;
    }

    public class MediaFileLoadedEventArgs : EventArgs
    {
        public Uri FilePath { get; set; }
    }
}
