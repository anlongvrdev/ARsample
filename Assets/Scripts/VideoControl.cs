using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoControl : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public void playVideo()
    {
        videoPlayer.Play();
    }

    public void pauseVideo()
    {
        videoPlayer.Pause();
    }

    public void stopVideo()
    {
        videoPlayer.Stop();
    }
}
