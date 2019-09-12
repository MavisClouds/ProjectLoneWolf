using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icespikeatt : MonoBehaviour
{

    public Animator anim;
    public moving move;
    public shoot shoted;
    public bool isright;
    public int check;
    SpriteRenderer rend;
    public bool onoff;
    BoxCollider2D mcol;
    public float scalex;

    // Start is called before the first frame update
    void Start()
    {
        mcol = gameObject.GetComponent<BoxCollider2D>();
        anim = gameObject.GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        check = move.R;
        onoff = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (check == 0)
        {
            isright = false;           
        }
        else if (check == 1)
        {
            isright = true;
        }
        if (onoff == true)
        {
            changer();
            
        }
    }

    void changer ()
    {
        if (isright == false)
        {
            transform.localScale = new Vector3(-1f, 0.5022383f, 1f);
            anim.Play("shot");
            StartCoroutine("boxsize");
            StartCoroutine("fadeout");
        }
        if (isright == true)
        {
            transform.localScale = new Vector3(1f, 0.5022383f, 1f);
            anim.Play("shot");
            StartCoroutine("boxsize");
            StartCoroutine("fadeout");
        }
        if (gameObject.name == "icespike0(Clone)")
        {
            Destroy(gameObject, 2);
        }
        onoff = false;
    }
    IEnumerator fadeout()
    {
        for (float f = 1f; f>=-0.05; f -= 0.05f)
        {
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);

        }
        
    }
   IEnumerator boxsize()
    {
        for (scalex = 0; scalex <= 11; scalex++)
        {
            mcol.size = new Vector3(scalex, 2.88f, 1);
            yield return new WaitForSeconds(0.05f);
        }
    }
}
