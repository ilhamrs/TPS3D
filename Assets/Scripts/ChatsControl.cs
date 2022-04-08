using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatsControl : MonoBehaviour
{
    public Chats chats;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextChat()
    {
        chats.control(1);
    }

    public void openChat()
    {
        chats.setActive();
        Invoke("nextChat", 2);
    }
}
