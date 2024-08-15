using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class GameProgress : MonoBehaviour
{

    float IfQuickly = 1f;

    public GameObject CheckB, QuestionSizeBack, QuestionPeopleBack, VotingB, NameListB, ENDB;

    int MaxRound = 2;

    int anNUM = 0;

    public Text m_TypingText;
    public string m_Message;
    public float m_Speed = 0.1f;


    public int SpyCode;
    public string QuestionsText;
    public string QuestionsType;

    int RoundC = 1;


    int GameTurn = 0;

    int num = 0;
    public int PeopleMax;
    public List<string> NameList = new List<string>();
    List<string> AnswerList = new List<string>();

    int SelectedNameNum;
    void Start()
    {
        MaxRound = PlayerPrefs.GetInt("RoundSet", 2);
        if (PlayerPrefs.GetInt("SpeedSet", 0) == 1)
        {
            IfQuickly = 0.3f;
        }
        if (IfQuickly != 1f)
        {
            m_Speed = 0;
        }

        PeopleMax = PlayerPrefs.GetInt("TheNumberOfPeople");
        SpyCode = Random.Range(0, PeopleMax);
        Invoke("ContentPrint", 2f * IfQuickly);
        for (int i = 1; i <= PeopleMax; i++)
        {
            string addText = PlayerPrefs.GetString("Name" + i.ToString() + "P");
            NameList.Add(addText);
        }
        NameList.Add("����");
    }

    // Update is called once per frame
    void ContentPrint()
    {
        num++;
        if (num == 1)
        {
            m_Message = @"" + PeopleMax.ToString() + "������ ������ ���� �մϴ�.";
            StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
            Invoke("ContentPrint", 5f * IfQuickly);

        }
        else if (num == 2)
        {
            m_Message = @"�����̸� ���ϴ� ���Դϴ�
............!";
            StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
            Invoke("ContentPrint", 7f * IfQuickly);
        }
        else if (num == 3)
        {


            m_Message = @"������ ���ϴ� ���Դϴ�
......!";
            if (Random.Range(0, 2) == 0)///1�� 2�� �����ʿ�
            {
                QuestionsType = "Size";
            }
            else
            {
                QuestionsType = "People";
            }






            List<Dictionary<string, object>> data = CSVReader.Read("QuestionList");

            QuestionsText = (string)data[Random.Range(1, 39)]["Question" + QuestionsType];


            Debug.Log(QuestionsType);
            Debug.Log(QuestionsText);
            Debug.Log(SpyCode);
            Debug.Log(NameList[SpyCode]);




            StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
            Invoke("ContentPrint", 6f * IfQuickly);
        }
        else if (num == 4)
        {
            m_Message = @"�Ϸ�!!";
            StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
            Invoke("ContentPrint", 2f * IfQuickly);
        }
        else if (num == 5)
        {
            ContentPrint();
        }
        else if (num == 6)
        {
            m_Message = @"������ ���� �մϴ�.";
            StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
            Invoke("ContentPrint", 3f * IfQuickly);
            GameTurn = 0;
        }
        else if (num == 7)
        {
            if (NameList[GameTurn] != "�ƿ��Ȼ����")
            {
                GameObject.Find("TextMove").GetComponent<textMove>().TextMove(0, 350);
                m_Message = @"" + NameList[GameTurn] + "���� �ڵ����� �Ѱ� �ּ���.";
                StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));

                Invoke("ContentPrint", 4f * IfQuickly);
            }
            else
            {
                GameTurn += 1;

                if (GameTurn < PeopleMax)
                {
                    num = 6;
                }
                else
                {
                    num = 10;
                }
                ContentPrint();
            }
        }
        else if (num == 8)
        {
            CheckB.gameObject.SetActive(true);

        }
        else if (num == 9)
        {
            CheckB.gameObject.SetActive(false);
            if (SpyCode == GameTurn)
            {
                m_Message = @"����� ������ �Դϴ�.";
            }
            else
            {
                m_Message = @"" + QuestionsText;

            }
            StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
            Invoke("ContentPrint", 6f * IfQuickly);




        }
        else if (num == 10)
        {
            if (QuestionsType == "Size")
            {
                QuestionSizeBack.gameObject.SetActive(true);
            }
            else
            {
                QuestionPeopleBack.gameObject.SetActive(true);

            }
        }
        else if (num == 11)
        {
            if (QuestionsType == "Size")
            {
                QuestionSizeBack.gameObject.SetActive(false);
            }
            else
            {
                QuestionPeopleBack.gameObject.SetActive(false);

            }
            GameTurn += 1;
            if (GameTurn < PeopleMax)
            {
                num = 6;
            }
            ContentPrint();
        }
        else if (num == 12)
        {
            GameObject.Find("TextMove").GetComponent<textMove>().TextMove(0, 0);
            m_Message = @"��� �÷��̾ ������ ���ƽ��ϴ�.";
            StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));

            Invoke("ContentPrint", 5f * IfQuickly);
        }
        else if (num == 13)
        {
            m_Message = @"" + QuestionsText + @"

" + "����� ��ǥ �մϴ�.";
            StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));

            Invoke("ContentPrint", 10f);
        }
        else if (num == 14)
        {
            anNUM = 0;

            GameObject.Find("TextMove").GetComponent<textMove>().TextMove(0, 0);
            m_Message = @"";
            for (int i = 0; i < PeopleMax; i++)
            {
                ///*
                if (NameList[i] != "�ƿ��Ȼ����")
                {
                    m_Message = m_Message + NameList[i] + ":  " + AnswerList[anNUM] + "   ";
                    anNUM++;
                }
                //*/
            }
            StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));

            float timeW = (float)PeopleMax * 3f + 10f;

            Invoke("ContentPrint", timeW * IfQuickly);

        }
        else if (num == 15)
        {
            GameObject.Find("TextMove").GetComponent<textMove>().TextMove(0, 150);

            VotingB.gameObject.SetActive(true);
        }
        else if (num == 16)
        {
            GameObject.Find("TextMove").GetComponent<textMove>().TextMove(0, 350);

            VotingB.gameObject.SetActive(false);

            m_Message = @"���ÿ� �������ΰ� ���� ����� �����ϰ� ���� ���� ������ ���� ����� �Է��� �ּ���.";
            StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
            Invoke("ContentPrint", 5f * IfQuickly);
        }
        else if (num == 17)
        {
            GameObject.Find("TextMove").GetComponent<textMove>().TextMove(0, 150);

            NameListB.gameObject.SetActive(true);

        }
        else if (num == 18)
        {
            NameListB.gameObject.SetActive(false);

            if (PeopleMax != SelectedNameNum)
            {
                Debug.Log(SelectedNameNum);
                Debug.Log("���õ� ��ȣ ���");
                m_Message = @"" + NameList[SelectedNameNum] + "���� �����̷� ������߽��ϴ�";
                StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
                Invoke("ContentPrint", 5f * IfQuickly);
            }
            else
            {
                if (RoundC < MaxRound)
                {
                    RoundC += 1;
                    m_Message = @"��ǥ ������ �ƹ��� Ż������ �ʾҽ��ϴ�.

" + RoundC + "��° ���带 ���� �մϴ�.";
                    StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));

                    num = 2;
                    GameTurn = 0;
                    AnswerList.Clear();

                    Invoke("ContentPrint", 10f * IfQuickly);
                }
                else
                {
                    m_Message = @"��ǥ ������ �ƹ��� Ż������ �ʾҽ��ϴ�.

�������� �¸� �Դϴ�!";
                    StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
                    num = 100;


                    Invoke("ContentPrint", 10f * IfQuickly);
                }
            }
        }
        else if (num == 19)
        {
            if (SelectedNameNum == SpyCode)
            {
                m_Message = @"" + NameList[SelectedNameNum] + @"���� �����̰�......

�½��ϴ�!!!

�ù����� �¸� �Դϴ�!";
                StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));

                num = 100;

                Invoke("ContentPrint", 10f * IfQuickly);
            }
            else
            {
                if (RoundC < MaxRound)
                {
                    RoundC += 1;
                    m_Message = @"" + NameList[SelectedNameNum] + @"���� �����̰�......

�ƴմϴ�..

" + RoundC + "��° ���带 ���� �մϴ�.";
                    StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));

                    NameList[SelectedNameNum] = "�ƿ��Ȼ����";
                    num = 2;
                    GameTurn = 0;
                    AnswerList.Clear();



                    Invoke("ContentPrint", 10f * IfQuickly);
                }
                else
                {
                    m_Message = @"" + NameList[SelectedNameNum] + @"���� �����̰�......

�ƴմϴ�..

�������� �¸� �Դϴ�!";
                    StartCoroutine(Typing(m_TypingText, m_Message, m_Speed));
                    num = 100;


                    Invoke("ContentPrint", 10f * IfQuickly);
                }
            }
        }else if (num > 99)
        {
            ENDB.gameObject.SetActive(true);
        }
    }







    IEnumerator Typing(Text typingText, string message, float speed)
    {
        if (speed == 0)
        {
            typingText.text = message;
        }
        else
        {
            for (int i = 0; i < message.Length; i++)
            {
                typingText.text = message.Substring(0, i + 1);
                yield return new WaitForSeconds(speed);
            }
        }


    }

    public void CheckButtonClick()
    {
        ContentPrint();
    }


    public void AnswerButtonClick(string Answer)
    {
        if (Answer.Length == 1)
        {
            AnswerList.Add(NameList[int.Parse(Answer)]);

        }
        else
        {
            AnswerList.Add((string)Answer);

        }
        Debug.Log(GameTurn);
        ContentPrint();

        Debug.Log("22");

    }

    public void VotingButtonClick()
    {
        ContentPrint();
    }

    public void NameButtonClick(int NameNum)
    {
        SelectedNameNum = NameNum;
        Debug.Log("���ù��� ��� ��� �մϴ�.");
        Debug.Log(SelectedNameNum);
        Debug.Log(NameList[SelectedNameNum]);
        ContentPrint();

    }

    public void ENDButtonClick()
    {
        SceneManager.LoadScene("MainScreen");

    }




}
