using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deadpanel : MonoBehaviour
{
    public bool panelon;
    public GameObject deadpanels;

    // Start is called before the first frame update
    void Start()
    {
        deadpanels.SetActive(false);
        panelon = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (panelon == true)
        {
            deadpanels.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("deadly"))
        {
            panelon = true;
        }
    }

    public void restart()
    {
        SceneManager.LoadScene("level1");
    }
}
