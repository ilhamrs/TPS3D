using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI medkitText;
    public TextMeshProUGUI friendText;
    public Image totalHealth;
    public Image currentHealth;
    public Player player;
    public GameObject actionTalk;
    public GameObject missionSuccessPanel;
    public GameObject pausePanel;

    bool onPause;
    public bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        friendText.enabled = false;
        actionTalk.SetActive(false);
        missionSuccessPanel.SetActive(false);
        pausePanel.SetActive(false);

        Time.timeScale = 1;
        onPause = false;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.getMedkit == player.totalMedkit)
        {
            friendText.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && !isGameOver)
        {
            PauseResume();
        }
    }

    public void moveToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void PauseResume()
    {
        if (onPause)
        {
            onPause = false;
            pausePanel.SetActive(false);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            onPause = true;
            pausePanel.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }

}
