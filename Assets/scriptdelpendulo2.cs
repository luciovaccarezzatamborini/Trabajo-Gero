using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptdelpendulo2 : MonoBehaviour
{
    
    private bool angulolimite;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.x > 88 && transform.eulerAngles.x < 90)
        {
            angulolimite = true;
        }
        if (transform.eulerAngles.x > 270 && transform.eulerAngles.x < 280)
        {
            angulolimite = false;
        }

        if (angulolimite)
        {
            transform.eulerAngles -= new Vector3(2f, 0, 0);

        }

        else
        {
            transform.eulerAngles += new Vector3(1f, 0, 0);
        }




    }
}
