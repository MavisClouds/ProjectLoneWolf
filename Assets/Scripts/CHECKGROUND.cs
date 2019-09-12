using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHECKGROUND : MonoBehaviour {

    public bool ground;


    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "ground" || col.gameObject.tag == "wall" || col.gameObject.tag == "moveplat" || col.gameObject.tag == "groundtrig")
        {

            ground = true;

        }

    }

    void OnTriggerStay2D(Collider2D col)
    {

        if (col.gameObject.tag == "ground" || col.gameObject.tag == "wall" || col.gameObject.tag == "moveplat" || col.gameObject.tag == "groundtrig")
        {

            ground = true;

        }

    }

    void OnTriggerExit2D(Collider2D col)
    {

        ground = false;

    }

}
