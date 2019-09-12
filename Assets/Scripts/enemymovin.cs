using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovin : MonoBehaviour
{

    public bool movin;
    public bool wall;
    public float movemnt;
    public Animator anim;
    public bool exst;
    public checkatt ca;
    public float timestrt;
    public float timesht;
    public GameObject projectiles;
    public Transform shotpnt;
    public int R;

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        movin = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (movin == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movemnt, GetComponent<Rigidbody2D>().velocity.y);

            if (GetComponent<Rigidbody2D>().velocity.x > 0)
            {
                transform.localScale = new Vector3(1f, 1f, 1f);
                R = 1;
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movemnt, GetComponent<Rigidbody2D>().velocity.y);

            if (GetComponent<Rigidbody2D>().velocity.x < 0)
            {

                transform.localScale = new Vector3(-1f, 1f, 1f);
                R = 0;
            }
        }
        if (ca.exst == true && timesht <= 0)
        {
            StartCoroutine(delay());
            Instantiate(projectiles, shotpnt.position, transform.rotation);
            timesht = timestrt;
        }
        else if (ca.exst == true && timesht > 0)
        {
            exst = false;
            anim.SetBool("exst", exst);
            timesht -= Time.deltaTime;
        }
        else if (ca.exst == false)
        {
            exst = false;
            anim.SetBool("exst", exst);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "wall")
        {
            movin = !movin;
        }
    }

    IEnumerator delay()
    {
        exst = true;
        anim.SetBool("exst", exst);
        yield return new WaitForSeconds(0.5f);
    }
}