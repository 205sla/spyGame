using UnityEngine;

public class ChangePeople : MonoBehaviour
{
    public int PeopleCountInt;
    // Start is called before the first frame update
  
    private void Awake()
    {
        PeopleCountInt = PlayerPrefs.GetInt("TheNumberOfPeople", 6);

    }
 

    public void ClickUpButton()
    {
        if (PeopleCountInt < 9)
        {
            PeopleCountInt += 1;
            GameObject.Find("GameManager").GetComponent<ScreenReload>().ScreenReloadP();
        }
    }
    public void ClickDownButton()
    {
        if (PeopleCountInt > 3)
        {
            PeopleCountInt -= 1;
            GameObject.Find("GameManager").GetComponent<ScreenReload>().ScreenReloadP();
        }
    }


}


