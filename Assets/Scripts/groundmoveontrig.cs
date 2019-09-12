using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundmoveontrig : MonoBehaviour
{
    public GameObject platform;
    public GameObject player;
    public GameObject particles;
    public Transform[] points;
    public int pointselect;
    public Transform curpoints;
    public float movespeed;
    public float xpos;
    public float ypos;

    public bool onoff;
    


    // Start is called before the first frame update
    void Start()
    {
        curpoints = points[pointselect];
        onoff = false;
        particles.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (player.transform.position.x <= xpos && player.transform.position.y <= ypos)
        {
            platform.transform.position = Vector3.MoveTowards(platform.transform.position, curpoints.position, Time.deltaTime * movespeed);

            if (platform.transform.position == curpoints.position)
            {
                pointselect++;
                if (pointselect == points.Length)
                {
                    pointselect = 0;
                    particles.SetActive(true);
                }
                
                curpoints = points[1];
                
            }
        }
        else
        {
            platform.transform.position = Vector3.MoveTowards(platform.transform.position, curpoints.position, Time.deltaTime * movespeed);

            if (platform.transform.position == curpoints.position)
            {
                pointselect++;
                if (pointselect == points.Length)
                {
                    pointselect = 0;
                }

                curpoints = points[0];
            }
        }

    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            onoff = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        onoff = false;
        
    }*/

}

