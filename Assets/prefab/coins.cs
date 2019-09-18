using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{

    public score scr;
    public int scoress;

    // Start is called before the first frame update
    void Start()
    {
        scoress = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            scoress++;
            scr.scores = scr.scores + scoress;
            Destroy(gameObject);
        }
    }
}
