using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptdelcontador : MonoBehaviour
{


    public int SegundosTotales;
    private float Contador;

   public Text cuentaregresiva;

    private bool StopCounting = false;
    public GameObject panel;

    void Start()
    {
        Contador = Time.time;

    }

    // Update is called once per frame
    void Update()
    {

        if(Time.time > Contador + 1)
        {
            Contador++;
            SegundosTotales--;
        }

        if(!StopCounting) cuentaregresiva.text = SegundosTotales.ToString();

        if(SegundosTotales == 0)
        {
            panel.SetActive(true);
            StopCounting = true;

        }

        if (panel.active)
        {
            StopCounting = true;
        }
        

    }
}
