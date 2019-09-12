using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {

    public GameObject player;
    public GameObject mp;
    public float movemnt;
    public float jmp;
    public int counter;
    public int R;
    public float offsety;
    public Animation anim;
   // public Vector3 plyscale;
   // private GameObject[] newmove;


    public CHECKGROUND cg;

	// Use this for initialization
	void Start () {

        anim = gameObject.GetComponent<Animation>();
        R = 1;
        //plyscale = player.transform.localScale;
        //newmove = GameObject.FindGameObjectsWithTag("moveplat");

    }

    // Update is called once per frame
    void Update() {
        
        if (Input.GetButtonDown("Vertical") && cg.ground==true)
        {

            jump();

        }
       

        if (/*Input.GetKey(KeyCode.Mouse0) ||*/ Input.GetKey(KeyCode.LeftArrow))
        {

            GetComponent<Rigidbody2D>().velocity = new Vector2(-movemnt, GetComponent<Rigidbody2D>().velocity.y);

        if (GetComponent<Rigidbody2D>().velocity.x < 0)
            {

                transform.localScale = new Vector3(-1f, 1f, 1f);
                R = 0;
               
            }
            

        }
        else if (Input.GetKey(KeyCode.Mouse1) || Input.GetKey(KeyCode.RightArrow))
        {

            GetComponent<Rigidbody2D>().velocity = new Vector2(movemnt, GetComponent<Rigidbody2D>().velocity.y);

        if (GetComponent<Rigidbody2D>().velocity.x > 0)
            {

                transform.localScale = new Vector3(1f, 1f, 1f);
                R = 1;
             
            }
            

        }
        //anim.SetFloat("speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
    }

    void jump()
        {

            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jmp);

        }



}

