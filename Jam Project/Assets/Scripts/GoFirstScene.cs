using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class GoFirstScene : MonoBehaviour
{
    [SerializeField] VideoPlayer player;
    public string name;
    private void Start()
    {
        player.loopPointReached += quitWhenFinished;
    }
    public void quitWhenFinished(VideoPlayer vp)
    {
        Application.LoadLevel(name);
    }
}
