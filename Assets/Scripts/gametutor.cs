using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gametutor : MonoBehaviour
{
    public GameObject ply;
    public int tutor;
    public GameObject tutorpanel;
    public GameObject[] tutorobject;
    public GameObject[] tutortext;

    // Use this for initialization
    void Start()
    {
        tutor = 0;
        tutorpanel.SetActive(false);

        foreach (GameObject ttobj in tutorobject)
        {
            ttobj.SetActive(false);
        }
        foreach (GameObject tttxt in tutortext)
        {
            tttxt.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (ply.transform.position.y < -2 && tutor == 0)
        {
            satutor();
            tutorobject[0].SetActive(true);
            tutortext[0].SetActive(true);
        }

        if (ply.transform.position.x > 0 && tutor == 1)
        {
            satutor();
            tutorobject[1].SetActive(true);
            tutortext[1].SetActive(true);
        }

        if (ply.transform.position.x < -42 && ply.transform.position.y < -16 && tutor == 2)
        {
            satutor();
            tutorobject[2].SetActive(true);
            tutortext[2].SetActive(true);
        }

    }

    public void nextbutton()
    {
        tutorobject[tutor].SetActive(false);
        tutortext[tutor].SetActive(false);
        tutor++;
        Time.timeScale = 1f;
        tutorpanel.SetActive(false);

    }
    void satutor()
    {
        Time.timeScale = 0f;
        tutorpanel.SetActive(true);
    }
}
