using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallplatform : MonoBehaviour
{

    Rigidbody2D rb2d;
    public float times;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            StartCoroutine(fall());
        }
    }

    IEnumerator fall()
    {
        yield return new WaitForSeconds(times);
        rb2d.isKinematic = false;
        yield return 0;
    }
}
