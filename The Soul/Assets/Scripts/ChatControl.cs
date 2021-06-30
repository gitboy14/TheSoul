using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ChatControl: MonoBehaviour
{
    //@describe 想要触发的对话名称;
    public string ChatName;
    //当前是否可以对话
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
            //对话是否存在
            if (flowChart.HasBlock(ChatName))
            {//执行对话
                flowChart.ExecuteBlock(ChatName);
                GameObject.Find("Cube1").GetComponent<ObjectActive>().SetStart1(true);
            }
        }
    }

}

