using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeExplain : MonoBehaviour
{
    public GameObject ExplExplainIMG;




    public void ExplExplainButtonClick()
    {
        ExplExplainIMG.gameObject.SetActive(true);
    }
    public void CheckButtonClick()
    {
        ExplExplainIMG.gameObject.SetActive(false);
    }
}
