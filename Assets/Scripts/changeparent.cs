using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeparent : MonoBehaviour
{
    public bool agan;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "moveplat")
        {
            transform.parent = collision.gameObject.transform;
            agan = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.parent = null;
    }
}
