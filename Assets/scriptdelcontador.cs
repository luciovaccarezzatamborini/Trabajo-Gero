using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptdelcontador : MonoBehaviour
{
    float tiempoActual;
    public float tiempoparaelcontador;
   public Text cuentaregresiva;
    public GameObject panel;
    void Start()
    {
        tiempoActual = tiempoparaelcontador;

    }

    // Update is called once per frame
    void Update()
    {
        if (tiempoActual == 0)
        {
            panel.SetActive(true);
        }
        else
        {
            tiempoActual -= 1 * Time.deltaTime;
            cuentaregresiva.text = Mathf.Floor(tiempoActual).ToString();
        }

       
    }
}
