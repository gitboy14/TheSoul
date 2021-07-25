using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance { get; private set; }

    //��������
    public GameObject music;
    public Text musicStatus;
    private bool musicFlag = true;

    //��������
    public AudioSource volume;
    public Scrollbar volumebar;

    //������ť
    public GameObject help;
    private bool helpflag;

    //��ʾBar:Ѫ�����ӵ���ʱ�䡢����
    public Image healthBar;
    public Text bulletCountText;
    public Text TimeBar;
    public Text EnemyLeftBar;

    private void Awake()
    {
        instance = this;
    }

    //����Ѫ��
    public void UpdateHealthBar(int curAmount, int maxAmount)
    {
        healthBar.fillAmount = (float)curAmount / (float)maxAmount;
    }
    //�����ӵ�
    public void UpdateBulletCount(int curAmount, int maxAmount)
    {
        bulletCountText.text = curAmount.ToString() + "/" + maxAmount.ToString();
    }

    //ˢ��ʱ��
    public void UpdateTimeBar(int curtime)
    {
        int min = curtime / 60;
        int sec = curtime % 60;
        if (sec < 10 && min < 10)
        {
            TimeBar.text = "0" + min.ToString() + ":0" + sec.ToString();
        }
        if (sec > 10 && min < 10)
        {
            TimeBar.text = "0" + min.ToString() + ":" + sec.ToString();
        }
    }

    //���µ�����
    public void UpdateEnemyLeft(int enemyleft)
    {
        EnemyLeftBar.text = enemyleft.ToString();
    }

    //�˳���Ϸ
    public void ExitGame()
    {
        Application.Quit();
    }

    //����
    public void MusicButton()
    {
        if (musicFlag == false)
        {
            volume.volume = 1;
            //music.SetActive(true);
            musicFlag = true;
            musicStatus.text = "���֣���";
            return;
        }

        if (musicFlag == true)
        {
            volume.volume = 0;
            //music.SetActive(false);
            musicFlag = false;
            musicStatus.text = "���֣���";
            return;
        }
    }

    //���¿�ʼ��Ϸ
    public void ReStart()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }

    //���ز˵�
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    //��������
    public void AdjustVolume(Scrollbar volumebar)
    {
        volume.volume = volumebar.value;
    }

    //��������
    public void helpButton()
    {
        if (helpflag == false)
        {
            help.SetActive(true);
            helpflag = true;
            return;
        }

        if (helpflag == true)
        {
            help.SetActive(false);
            helpflag = false;
            return;
        }
    }
}