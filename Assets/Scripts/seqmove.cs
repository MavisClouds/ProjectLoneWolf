using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seqmove : MonoBehaviour
{
    public GameObject platform;
    public GameObject player;
    public Transform[] points;
    public int pointselect;
    public Transform curpoints;
    public float movespeed;
    public float xpos;
    public float ypos;
    public float secondss;
    public bool onoff;



    // Start is called before the first frame update
    void Start()
    {
        curpoints = points[pointselect];
        onoff = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x >= xpos && player.transform.position.y >= ypos)
        {
            onoff = true;
        }
        StartCoroutine("movesequence");

    }

    IEnumerator movesequence()
    {
        if (onoff == true)
        {
            yield return new WaitForSeconds(secondss);
            platform.transform.position = Vector3.MoveTowards(platform.transform.position, curpoints.position, Time.deltaTime * movespeed);

            if (platform.transform.position == curpoints.position)
            {
                pointselect++;
                if (pointselect == points.Length)
                {
                    pointselect = 0;
                }

                curpoints = points[pointselect];

            }
        }
            
    }
  
}

