using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class winpanel : MonoBehaviour
{
    public GameObject player;
    public GameObject winpaneli;
    public GameObject text;
    public bool isonstepped;

    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        winpaneli.SetActive(false);
        isonstepped = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("link") && isonstepped == true)
        {
            Time.timeScale = 0;
            winpaneli.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
     
        if (collision.CompareTag("Player"))
        {
            text.SetActive(true);
            isonstepped = true;
            
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            text.SetActive(false);
        }

    }

    public void linked()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
