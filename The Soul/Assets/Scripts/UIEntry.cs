using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIEntry : MonoBehaviour
{
    public GameObject about;
    private bool flag;
    public static int ctrlflag = 1;
    public Text ctrltext;
    public Text Button1;
    public Text Button2;

    private int ResoType = 1;
    public Text ResoText;

    public Text AboutText;

    // Start is called before the first frame update
    void Start()
    {
        flag = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ResolutionSet();
        }
    }

    public void StartGame()
    {
        if (flag == false)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            Application.OpenURL("https://blog.csdn.net/weixin_43673589");
        }

    }

    public void About()
    {
        //��ʾ��Ϸ����
        if (flag == false)
        {
            //�����ı���ʾ
            about.SetActive(true);
            flag = true;

            //��ť1�ӿ�ʼ��Ϸ���Ϊ����
            Button1.text = "���߲���";
            Button1.fontSize = 32;

            //��ť2�ӿ�ʼ��Ϸ��Ϊ�γ̻ع�
            Button2.text = "����ع�";
            Button2.fontSize = 32;

            //���ڰ�ť��Ϊ�رհ�ť
            AboutText.text = "��";
            AboutText.fontSize = 140;

            return;
        }

        //������Ϸ����
        if (flag == true)
        {
            about.SetActive(false);
            flag = false;

            //��ť1�ӿ�ʼ��Ϸ���Ϊ����
            Button1.text = "��ʼ";
            Button1.fontSize = 49;

            //��ť1�ӿ�ʼ��Ϸ���Ϊ����
            Button2.text = "���+����";
            Button2.fontSize = 28;

            //�رհ�ť��Ϊ���ڰ�ť
            AboutText.text = "����";
            AboutText.fontSize = 49;

            return;
        }
    }

    public void Blog()
    {
        Application.OpenURL("https://blog.csdn.net/weixin_43673589");
    }

    public void ctrl()
    {
        if (flag == false)
        {
            Debug.Log(ctrlflag);
            if (ctrlflag == 1)
            {
                ctrlflag = 2;
                ctrltext.text = "���";
                ctrltext.fontSize = 49;
            }
            else if (ctrlflag == 2)
            {
                ctrlflag = 3;
                ctrltext.text = "����";
                ctrltext.fontSize = 49;
            }
            else if (ctrlflag == 3)
            {
                ctrlflag = 1;
                ctrltext.text = "���+����";
                ctrltext.fontSize = 28;
            }
        }
        else
        {
            Application.OpenURL("https://blog.csdn.net/weixin_43673589/article/details/106577768");
        }
    }

    public void ResolutionSet()
    {
        if (ResoType % 2 == 0)
        {
            Screen.SetResolution(1155, 763, false, 60);
            ResoType++;
            ResoText.text = "����";
            return;
        }
        if (ResoType % 2 == 1)
        {
            Screen.SetResolution(2160, 1440, true, 60);
            ResoType++;
            ResoText.text = "ȫ��";
            return;
        }
    }
}