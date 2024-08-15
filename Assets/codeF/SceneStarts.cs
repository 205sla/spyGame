using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneStarts : MonoBehaviour
{
    public void SettingB()
    {
        SceneManager.LoadScene("SetPeople");
    }

    public void StartB()
    {
        SceneManager.LoadScene("GameScenes");

    }

    public void SettingGameB()
    {
        SceneManager.LoadScene("SettingScreen");

    }




}
