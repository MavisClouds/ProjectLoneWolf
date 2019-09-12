using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newmovingground : MonoBehaviour
{
    private Vector3 posa;
    private Vector3 posb;
    private Vector3 nextpos;

    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform childtransform;

    public Transform transformb;

    // Start is called before the first frame update
    void Start()
    {
        posa = childtransform.localPosition;
        posb = transformb.localPosition;
        nextpos = posb;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        childtransform.localPosition = Vector3.MoveTowards(childtransform.localPosition, nextpos, speed * Time.deltaTime);
        if (Vector3.Distance(childtransform.localPosition,nextpos) <= 0.1)
        {
            shifters();
        }
    }

    private void shifters()
    {
        nextpos = nextpos != posa ? posa : posb;
    }

}
