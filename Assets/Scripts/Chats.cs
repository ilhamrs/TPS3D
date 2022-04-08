using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chats : MonoBehaviour
{
    int urutan = 0;
    public bool isChatOn;
    // Start is called before the first frame update
    void Start()
    {
        isChatOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.GetChild(urutan).gameObject.activeInHierarchy)
        {
            urutan++;
            control(urutan);
        }
    }

    public void control(int i)
    {
        urutan += i;
        if (urutan > transform.childCount - 1)
        {
            urutan = 0;
        }
        else if (urutan < 0)
        {
            urutan = transform.childCount - 1;
        }
        setActive();
    }

    public void setActive()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
        transform.GetChild(urutan).gameObject.SetActive(true);
    }
}
