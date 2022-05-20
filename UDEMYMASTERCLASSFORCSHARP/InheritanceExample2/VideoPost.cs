using System;
using System.Threading;


namespace UDEMYMASTERCLASSFORCSHARP.InheritanceExample2
{
    public class VideoPost : Post
    {
        protected string VideoURL;
        protected float videoLength;


        protected bool isPlaying = false;
        protected bool isPaused = false;
        protected int CurrentDuration = 0;

        private static Timer timething;

        public VideoPost()
        {
            this.VideoURL = "ARANDOMURL.COM";
            this.videoLength = 33f;
        }

        public VideoPost(int _id, string _title, string _SentByUser, bool _isPublic, string _videoUrl,
            float _videoLength) : base(_id, _title, _SentByUser, _isPublic)
        {
            base.id = _id;
            base.title = _title;
            base.sentByUserName = _SentByUser;
            base.isPublic = _isPublic;
            this.VideoURL = _videoUrl;
            this.videoLength = _videoLength;
        }


        private void TimerCallBack(Object o)
        {
            if (CurrentDuration < videoLength)
            {
                CurrentDuration++;
                Console.WriteLine("Time is increasing. Video is at {0}", CurrentDuration);
                GC.Collect();
            }
            else if (CurrentDuration >= videoLength)
            {
                Console.WriteLine("The video length is now max. It is over.");
                StopVideo();
            }
        }

        public void PlayVideo()
        {
            if (!isPlaying)
            {
                timething = new Timer(TimerCallBack, null, 0, 1000);
                Console.WriteLine("The video is playing with a length of {0}", this.videoLength);
                isPlaying = true;
                isPaused = false;
            }
            else
            {
                Console.WriteLine("A video is already playing therefore no need to play again.`");
            }
        }

        public void StopVideo()
        {
            if (isPlaying || isPaused)
            {
                Console.WriteLine("The video has stopped playing at {0}", CurrentDuration);
                CurrentDuration = 0;
                timething.Dispose();
                isPlaying = false;
            }
            else
            {
                Console.WriteLine("There is no video to stop as none are playing.");
            }
        }

        public void PauseVideo()
        {
            if (isPlaying && !isPaused)
            {
                Console.WriteLine("The video is now paused at {0}", CurrentDuration);
                timething.Dispose();
                isPlaying = false;
                isPaused = true;
            }
            else
            {
                Console.WriteLine("There is no video currently playing.");
            }
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + " The video url is {0} and the length of that video is {1}",
                this.VideoURL, this.videoLength);
        }
    }
}