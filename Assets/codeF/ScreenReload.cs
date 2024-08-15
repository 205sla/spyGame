using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenReload : MonoBehaviour
{

    public Text PeopleCount;
    public GameObject N1,N2,N3,N4,N5,N6,N7,N8,N9;
    private void Start()
    {
        ScreenReloadP();
    }
    public void ScreenReloadP()
    {
        int Count = GameObject.Find("GameManager").GetComponent<ChangePeople>().PeopleCountInt;
        PeopleCount.text = Count.ToString()+"Έν";


        if (Count >= 1)
        {
            N1.gameObject.SetActive(true);
        }
        else
        {
            N1.gameObject.SetActive(false);
        }



        if (Count >= 2)
        {
            N2.gameObject.SetActive(true);
        }
        else
        {
            N2.gameObject.SetActive(false);
        }

        if (Count >= 3)
        {
            N3.gameObject.SetActive(true);
        }
        else
        {
            N3.gameObject.SetActive(false);
        }

        if (Count >= 4)
        {
            N4.gameObject.SetActive(true);
        }
        else
        {
            N4.gameObject.SetActive(false);
        }

        if (Count >= 5)
        {
            N5.gameObject.SetActive(true);
        }
        else
        {
            N5.gameObject.SetActive(false);
        }

        if (Count >= 6)
        {
            N6.gameObject.SetActive(true);
        }
        else
        {
            N6.gameObject.SetActive(false);
        }

        if (Count >= 7)
        {
            N7.gameObject.SetActive(true);
        }
        else
        {
            N7.gameObject.SetActive(false);
        }

        if (Count >= 8)
        {
            N8.gameObject.SetActive(true);
        }
        else
        {
            N8.gameObject.SetActive(false);
        }

        if (Count >= 9)
        {
            N9.gameObject.SetActive(true);
        }
        else
        {
            N9.gameObject.SetActive(false);
        }


    }
}
