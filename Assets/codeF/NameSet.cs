using UnityEngine;
using UnityEngine.UI;

public class NameSet : MonoBehaviour
{
    public int Num;
    public Text Name;
    readonly string[] Namelist = { "����", "�̸̹�", "�Ƹ�", "��ȭ", "��ȭ", "�ڵ���", "��ƿ�", "������", "����" };




    private void Awake()
    {
        Name.text = PlayerPrefs.GetString("Name" + Num.ToString() + "P", Namelist[Num - 1]);

    }


}
