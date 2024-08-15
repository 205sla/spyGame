using UnityEngine;

public class FirstSetting : MonoBehaviour
{
    readonly string[] Namelist = { "����", "�̸̹�", "�Ƹ�", "��ȭ", "��ȭ", "�ڵ���", "��ƿ�", "������", "����" };

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("FirstSet", 0) == 0)
        {
            PlayerPrefs.SetInt("FirstSet", 1);
            Debug.Log("�ʱ�ȭ");
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
