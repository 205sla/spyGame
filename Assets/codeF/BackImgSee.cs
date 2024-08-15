using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackImgSee : MonoBehaviour
{
    public GameObject Back;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("VideoSet", 1) == 0)
        {
            Back.gameObject.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
