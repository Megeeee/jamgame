using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class VideoFinishExit : MonoBehaviour
{
    [SerializeField] VideoPlayer player;
    private void Start()
    {
        player.loopPointReached += quitWhenFinished;
    }
    public void quitWhenFinished(VideoPlayer vp)
    {
        Application.Quit();
    }
}
