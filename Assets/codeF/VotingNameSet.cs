using UnityEngine;
using UnityEngine.UI;
public class VotingNameSet : MonoBehaviour
{
    public int NameNum;
    public Text SetMyName;
    int V_MaxP;
    GameObject GM;

    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager");
        V_MaxP = GM.GetComponent<GameProgress>().PeopleMax;
        if (NameNum < V_MaxP)
        {
            SetMyName.text = GM.GetComponent<GameProgress>().NameList[NameNum];
        }else if (NameNum == V_MaxP)
        {
            SetMyName.text = "µ¿·ü\n(°Ç³Ê¶Ù±â)";
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(NameNum != V_MaxP)
        {
            if (GM.GetComponent<GameProgress>().NameList[NameNum] == "¾Æ¿ôµÈ»ç¶÷ÀÓ")
            {
                gameObject.SetActive(false);
            }
        }       

    }
}
