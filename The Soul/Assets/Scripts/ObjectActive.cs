using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActive : MonoBehaviour
{

    public bool start1;
    public GameObject ob1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start1)
        {
            ob1.SetActive(true);
        }
        else
        {
            ob1.SetActive(false);
        }
    }

    public void SetStart1(bool i)
    {
        start1 = i;
     }

}
