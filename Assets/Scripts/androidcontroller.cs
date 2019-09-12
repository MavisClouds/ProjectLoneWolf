using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class androidcontroller : MonoBehaviour
{

    public float directx;
    public float movemnt;
    public float jmp;
    public CHECKGROUND cg;
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        directx = CrossPlatformInputManager.GetAxis("Horizontal");

        if (directx > 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movemnt, GetComponent<Rigidbody2D>().velocity.y);
        }
        else if (directx < 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movemnt, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (CrossPlatformInputManager.GetButtonDown("jump") && cg.ground == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jmp);
        }


    }

    public void Startgame()
    {
        SceneManager.LoadScene("level1");
    }
}
