using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Save : MonoBehaviour
{
    public Text N1, N2, N3, N4, N5, N6, N7, N8, N9;
    public void SaveName()
    {
   


        if (N1.text != "")
        {
            PlayerPrefs.SetString("Name1P", N1.text);
        }
        if (N2.text != "")
        {
            PlayerPrefs.SetString("Name2P", N2.text);
        }
        if (N3.text != "")
        {
            PlayerPrefs.SetString("Name3P", N3.text);
        }
        if (N4.text != "")
        {
            PlayerPrefs.SetString("Name4P", N4.text);
        }
        if (N5.text != "")
        {
            PlayerPrefs.SetString("Name5P", N5.text);
        }
        if (N6.text != "")
        {
            PlayerPrefs.SetString("Name6P", N6.text);
        }
        if (N7.text != "")
        {
            PlayerPrefs.SetString("Name7P", N7.text);
        }
        if (N8.text != "")
        {

            PlayerPrefs.SetString("Name8P", N8.text);
        }
        if (N9.text != "")
        {
            PlayerPrefs.SetString("Name9P", N9.text);
        }
        PlayerPrefs.SetInt("TheNumberOfPeople", GameObject.Find("GameManager").GetComponent<ChangePeople>().PeopleCountInt);
        



        SceneManager.LoadScene("MainScreen");
    }
}
