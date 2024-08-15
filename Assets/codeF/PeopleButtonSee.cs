using UnityEngine;
using UnityEngine.UI;


public class PeopleButtonSee : MonoBehaviour
{
    GameObject GM;
    int V_MaxP;
    public int NameNum;
    public Text SetMyName;


    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager");
        V_MaxP = GM.GetComponent<GameProgress>().PeopleMax;
        if (NameNum < V_MaxP)
        {
            SetMyName.text = GM.GetComponent<GameProgress>().NameList[NameNum];
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
