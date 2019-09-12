using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    public GameObject projectiles;
    public Transform shotpnt;
    public float timestrt;
    public float timesht;
    public Animator shtanim;
    public bool shot;
    public CHECKGROUND cg;

    void Start()
    {
        shtanim = gameObject.GetComponent<Animator>();
        shot = false;
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if(timesht<=0)
        {
            if(Input.GetButtonDown("icespike") && cg.ground == true)
            {
                shot = true;
                Instantiate(projectiles, shotpnt.position, transform.rotation);
                timesht = timestrt;
                StartCoroutine(delay());
            }
            
        }
        else
            {
                
                timesht -= Time.deltaTime;
            }     
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.15f);
        shot = false;
    }
}
