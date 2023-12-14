using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class movieMenu : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public VideoClip newVideoClip; // Assign your video clip in the Unity Editor

    void Start()
    {
    }

    public void ChangeVideoClip()
    {
        // Check if a new video clip is assigned
        if (newVideoClip != null)
        {
            // Change the video clip of the VideoPlayer component
            videoPlayer.clip = newVideoClip;

            // Play the video
            videoPlayer.Play();
        }
        else
        {
            Debug.LogWarning("No VideoClip assigned. Assign a VideoClip in the Unity Editor.");
        }
    }
}
