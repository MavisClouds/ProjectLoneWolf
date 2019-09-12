using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmyprojectiles : MonoBehaviour
{

    public float speed;
    public int check;
    public GameObject desteff;

    public enemymovin mv;


    // Use this for initialization
    void Start()
    {
        check = mv.R;
    }

    // Update is called once per frame
    void Update()
    {
        if (check == 1)
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }
        else if (check == 0)
        {
            transform.Translate(transform.right * -speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Instantiate(desteff, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
        else if (col.gameObject.tag != "enemy")
        {
            Destroy(gameObject);
        }
    }
}
