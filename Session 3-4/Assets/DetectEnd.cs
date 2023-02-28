using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class DetectEnd : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private void Start()
    {
        StartCoroutine(CheckEnd());
    }


    IEnumerator CheckEnd()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.2f);

            if (videoPlayer.isPlaying == false)
            {
                SceneManager.LoadScene(0);
            }
        }

    }
}
