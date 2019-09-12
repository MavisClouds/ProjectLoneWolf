using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ontriggermovingground : MonoBehaviour
{

    public GameObject platform;
    public Transform[] points;
    public int pointselect;
    public Transform curpoints;
    public float movespeed;
    public float times;
    public bool ups;


    // Start is called before the first frame update
    void Start()
    {
        curpoints = points[pointselect];
        ups = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(ups == true)
        {
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ups = true;
        }
    }

}
