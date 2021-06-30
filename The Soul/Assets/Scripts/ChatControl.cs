using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ChatControl: MonoBehaviour
{
    //@describe ��Ҫ�����ĶԻ�����;
    public string ChatName;
    //��ǰ�Ƿ���ԶԻ�
    private bool CanChat = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        CanChat = true;
    }

    private void OnTriggerExit(Collider other)
    {
        CanChat = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            say();
        }
    }

    private void OnMouseDown()
    {
        say();
    }

    void say()
    {
        if (CanChat)
        {
            Flowchart flowChart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
            //�Ի��Ƿ����
            if (flowChart.HasBlock(ChatName))
            {//ִ�жԻ�
                flowChart.ExecuteBlock(ChatName);
                GameObject.Find("Cube1").GetComponent<ObjectActive>().SetStart1(true);
            }
        }
    }

}

