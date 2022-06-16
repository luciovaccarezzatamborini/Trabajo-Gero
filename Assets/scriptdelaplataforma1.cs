using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptdelaplataforma1 : MonoBehaviour
{
   

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += new Vector3(0, 3, 0);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
           
            col.collider.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision col)
    {

        if (col.gameObject.tag == "Player")
        {

            col.collider.transform.SetParent(null);
       
        }
    }

    
}
