using UnityEngine;
using UnityEngine.UI;

public class NameSet : MonoBehaviour
{
    public int Num;
    public Text Name;
    readonly string[] Namelist = { "수아", "미미르", "아린", "유화", "연화", "박도경", "명아연", "납작이", "명정" };




    private void Awake()
    {
        Name.text = PlayerPrefs.GetString("Name" + Num.ToString() + "P", Namelist[Num - 1]);

    }


}
