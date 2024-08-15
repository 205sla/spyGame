using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManagement : MonoBehaviour
{

    public Text Round, Speed, Video, Mode;
    // Start is called before the first frame update
    void Start()
    {
        RefreshWriting();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void RefreshWriting()
    {
        Round.text = PlayerPrefs.GetInt("RoundSet", 2).ToString();

        if (PlayerPrefs.GetInt("SpeedSet", 0) == 0)
        {
            Speed.text = "±‚∫ª";
        }
        else
        {
            Speed.text = "∫¸∏ß";
        }

        if (PlayerPrefs.GetInt("VideoSet", 1) == 0)
        {
            Video.text = "≤˚";
        }
        else
        {
            Video.text = "≈¥";
        }

        if (PlayerPrefs.GetInt("ModeSet", 0) == 0)
        {
            Mode.text = "≤˚";
        }
        else
        {
            Mode.text = "≤˚";
        }
    }


    public void RoundButtonClick()
    {
        int roundInt = PlayerPrefs.GetInt("RoundSet");
        roundInt += 1;
        if (roundInt > 4)
        {
            roundInt = 1;
        }
        PlayerPrefs.SetInt("RoundSet", roundInt);
        RefreshWriting();
    }

    public void SpeedButtonClick()
    {
        PlayerPrefs.SetInt("SpeedSet", 1 - PlayerPrefs.GetInt("SpeedSet"));
        RefreshWriting();

    }

    public void VideoButtonClick()
    {
        PlayerPrefs.SetInt("VideoSet", 1 - PlayerPrefs.GetInt("VideoSet"));
        RefreshWriting();


    }

    public void ModeButtonClick()
    {
        PlayerPrefs.SetInt("ModeSet", 1 - PlayerPrefs.GetInt("ModeSet"));
        RefreshWriting();


    }

    public void EraseButtonClick()
    {
        PlayerPrefs.DeleteAll();


#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); // æÓ«√∏Æƒ…¿Ãº« ¡æ∑·
#endif
    }

    public void GoingBackButtonClick()
    {
        SceneManager.LoadScene("MainScreen");
    }





}
