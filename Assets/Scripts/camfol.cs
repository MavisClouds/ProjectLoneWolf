using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfol : MonoBehaviour {

    public GameObject ply;

    public float xofset;
    public float yofset;
    public float zofset;
    public float chekerx;
    public float chekery;

    // Use this for initialization
    void Start ()
    {
        //ply = FindObjectOfType<moving>();
       // transform.position = new Vector3(ply.transform.position.x - xofset, ply.transform.position.y - yofset, ply.transform.position.z - 9 - zofset);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if ( ply.transform.position.x - xofset >= 0)
        {
            transform.position = new Vector3(ply.transform.position.x - xofset,ply.transform.position.y - yofset, ply.transform.position.z - 9 - zofset);
        }
        else if (ply.transform.position.x - xofset <= 0 && ply.transform.position.y - xofset <= -5)
        {
            transform.position = new Vector3(ply.transform.position.x - xofset, ply.transform.position.y - yofset, ply.transform.position.z - 9 - zofset);
        }
        chekerx = ply.transform.position.x - xofset;

    }
}
