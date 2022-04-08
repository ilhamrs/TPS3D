using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject aboutPanel;
    bool isAboutPanelActive;
    // Start is called before the first frame update
    void Start()
    {
        aboutPanel.SetActive(false);
        isAboutPanelActive = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void moveToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void setAboutPanel()
    {
        if (isAboutPanelActive)
        {
            isAboutPanelActive = false;
            aboutPanel.SetActive(false);
        }
        else
        {
            isAboutPanelActive = true;
            aboutPanel.SetActive(true);
        }

    }
}
