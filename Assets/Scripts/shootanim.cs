using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootanim : MonoBehaviour {

    public Animator shtanim;
    public bool shot;

    // Use this for initialization
    void Start () {
        shtanim = gameObject.GetComponent<Animator>();
        shot = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetButtonDown("shoot"))
        {
            shot = true;
            shtanim.SetBool("shot", shot);
            StartCoroutine(delay());
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.15f);
        shot = false;
        shtanim.SetBool("shot", shot);
    }
}
