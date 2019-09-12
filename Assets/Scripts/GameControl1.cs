using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class GameControl1 : MonoBehaviour {

    public static GameControl1 control;

    public GameObject[] Player;
    public Vector3[] vctply;
    public int a;
   
    void Awake()
    {
        a = 0;
        if (control == null)
        {

            DontDestroyOnLoad(gameObject);
            control = this;

        }
        else if (control != this)
        {

            Destroy(gameObject);

        }

    }

    // Use this for initialization
    void Start() { }


    // Update is called once per frame
    void Update() {

        vctply[a] = Player[a].transform.position;

    }

    public void save()
    {

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/playerinfo.dat", FileMode.Open);

        playerdata data = new playerdata();
        data.Player[a] = Player[a];
        data.vctply[a] = vctply[a];

        bf.Serialize(file, data);
        file.Close();


    }

    [Serializable]
    class playerdata
    {

        public GameObject[] Player;
        public Vector3[] vctply;
        public int a;

    }
}
