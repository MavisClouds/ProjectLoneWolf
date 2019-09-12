using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{

    public GameObject UIP;
    private bool paused;

    // Start is called before the first frame update
    void Start()
    {
        UIP.SetActive(false);
        paused = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Pause") && paused == false)
        {
            UIP.SetActive(true);
            paused = true;
            Time.timeScale = 0f;
        }
        else if (Input.GetButtonDown("Cancel") && paused == true)
        {
            UIP.SetActive(false);
            paused = false;
            Time.timeScale = 1;
        }
    }

    public void pause()
    {
        UIP.SetActive(true);
        paused = true;
        Time.timeScale = 0f;
    }

    public void resume()
    {
        UIP.SetActive(false);
        paused = false;
        Time.timeScale = 1;
    }

    public void restart()
    {
        SceneManager.LoadScene("level1");
    }

    public void mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}

