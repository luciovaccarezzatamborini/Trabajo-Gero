using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontroller : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float subida;
    

    float a;
    public bool isAble;
    public GameObject prefab;
    Rigidbody rb;
    bool jump = true;

    public GameObject panel;
    public GameObject panelperdiste;

    void Start()
    {
       

        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) )
        {
           
            // transform.position += new Vector3(0, 0, speed);
           
           
                transform.Translate(0, 0, speed);
            


        }

        

        if (Input.GetKey(KeyCode.S)  )
        {
            // transform.position -= new Vector3(0, 0, speed);

            transform.Translate(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.D) )
        {
            transform.eulerAngles += new Vector3(0, rotationSpeed, 0);
        }


        if (Input.GetKey(KeyCode.A) )
        {
            transform.eulerAngles -= new Vector3(0, rotationSpeed, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
          
            if (  jump) {

                jump = false;
                rb.AddForce(Vector3.up * subida, ForceMode.Impulse);

            }

            // GameObject clon;
            //clon = Instantiate(prefab);
            //clon.transform.position = transform.position - new Vector3(0, 0, -1);
        }
       a = transform.position.y;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            jump = true;
        }

        if (col.gameObject.tag == "Respawn")
        {
            SceneManager.LoadScene("escenaperdiste");

        }

        if (col.gameObject.tag == "Finish")
        {
            panel.SetActive(true);
        }
    }
}

