using UnityEngine;

public class FirstSetting : MonoBehaviour
{
    readonly string[] Namelist = { "수아", "미미르", "아린", "유화", "연화", "박도경", "명아연", "납작이", "명정" };

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("FirstSet", 0) == 0)
        {
            PlayerPrefs.SetInt("FirstSet", 1);
            Debug.Log("초기화");
            PlayerPrefs.SetInt("TheNumberOfPeople", 6);

            for (int i = 1; i < 10; i++)
            {

                PlayerPrefs.SetString("Name" + i.ToString() + "P", Namelist[i - 1]);
            }
            PlayerPrefs.SetInt("RoundSet", 2);
            PlayerPrefs.SetInt("SpeedSet", 0);
            PlayerPrefs.SetInt("VideoSet", 1);
            PlayerPrefs.SetInt("ModeSet", 0);
        }


        



    }



    // Update is called once per frame
    void Update()
    {

    }
}
