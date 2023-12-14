using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PlayPause : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    bool isPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleMode()
    {
        if(isPlaying == false)
        {
            PlayVideo();
            isPlaying = true;

        }
        else if (isPlaying == true)
        {
            PauseVideo();
            isPlaying = false;
        }

    }

    public void PlayVideo()
    {
        if(!videoPlayer.isPlaying)
        {
            videoPlayer.Play();
        }
    }
    public void PauseVideo()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
        }
    }
}
