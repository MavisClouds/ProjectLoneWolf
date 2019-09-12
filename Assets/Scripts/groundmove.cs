using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundmove : MonoBehaviour
{

    public GameObject platform;
    public Transform[] points;
    public int pointselect;
    public Transform curpoints;
    public float movespeed;
    public float times;


    // Start is called before the first frame update
    void Start()
    {
        curpoints = points[pointselect];
       
    }

    // Update is called once per frame
    void Update()
    {
            platform.transform.position = Vector3.MoveTowards(platform.transform.position, curpoints.position, Time.deltaTime * movespeed);

            if (platform.transform.position == curpoints.position)
            {
                pointselect++;
                if (pointselect == points.Length)
                {
                    pointselect = 0;
                }

                StartCoroutine(fall());
            }
    }
     
    

    IEnumerator fall()
    {
        yield return new WaitForSeconds(times);
        curpoints = points[pointselect];
        yield return 0;
    }

  
}
