using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float totalHealth;
    public float currentHealth;
    public GameManager gameManager;
    public SoundManager soundManager;
    public float totalMedkit { get; private set; }
    public float getMedkit { get; private set; }

    public ChatsControl chatsControl;
    public Chats chats;
// Start is called before the first frame update
void Start()
    {
        gameManager.totalHealth.fillAmount = totalHealth / 10;
        totalMedkit = GameObject.FindGameObjectsWithTag("medkit").Length;
        getMedkit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gameManager.currentHealth.fillAmount = currentHealth / 10;
        gameManager.medkitText.text = "- Find Medkit " + getMedkit + "/" + totalMedkit;

        if(Input.GetKeyDown(KeyCode.E) && gameManager.actionTalk.activeInHierarchy)
        {
            chatsControl.openChat();
            Invoke("MissionSuccessful", 4);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "medkit")
        {
            Debug.Log("medkit!");
            other.gameObject.SetActive(false);
            currentHealth++;
            getMedkit++;
            soundManager.getItemSound();
        }else if(other.tag == "friend" && getMedkit==totalMedkit)
        {
            Debug.Log("friend!");
            gameManager.actionTalk.SetActive(true);
            chats.isChatOn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "friend")
        {
            gameManager.actionTalk.SetActive(false);
        }
    }

    public void MissionSuccessful()
    {
        gameManager.missionSuccessPanel.SetActive(true);
        gameManager.isGameOver = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}
