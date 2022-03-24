using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Himmelsrichtungen
{
    Nord,
    Sued,
    West,
    Ost
}


public class Variabeln : MonoBehaviour
{


    Color farbe;
    int anzTueren;
    bool fahren;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Himmelsrichtungen.Nord + " " + Himmelsrichtungen.Sued + " " + Himmelsrichtungen.Ost + " " +Himmelsrichtungen.West );
        anzTueren = 1;
        fahren = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(fahren)
        {
            anzTueren = anzTueren + 1;
        }

        if(anzTueren <= 10)
        {
            fahren = true;
            Debug.Log("driving");
        }

        else
        {
            fahren = false;
        }
    }
}
