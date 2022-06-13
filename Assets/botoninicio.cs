using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botoninicio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject player;
    public GameObject panel;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void BotonInicio()
    {
        panel.SetActive(false);
        player.transform.position = new Vector3(0, 1.02f, 5.15f);
        player.transform.eulerAngles = new Vector3(0, 180, 0);
    }
}
