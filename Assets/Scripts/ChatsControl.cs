using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatsControl : MonoBehaviour
{
    public Chats chats;

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
