using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class VideoPlayControl : MonoBehaviour
{
    public VideoPlayer VP;
    // Start is called before the first frame update
    void Start()
    {
            
        if(PlayerPrefs.GetInt("VideoSet", 1) == 1)
        {
            VP.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
