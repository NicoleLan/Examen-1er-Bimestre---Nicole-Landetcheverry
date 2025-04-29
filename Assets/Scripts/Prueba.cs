using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public string patente;
    public int modelo;
    public int kilometraje;
    public int vencimiento;
    public int HcPpm;

    int anioActual = 2025;
    int promedioMax = 10000;

    // Start is called before the first frame update
    void Start()
    {
        int promedioAñosAuto = kilometraje / (anioActual - modelo);
        
        //Error en el ingreso de datos

        if (modelo > 2025 || modelo < 1900 || kilometraje < 0 || vencimiento > anioActual || vencimiento < modelo || HcPpm < 5)
        {
            Debug.Log("Error en el ingreso de datos");
            Debug.Log("VTV no aprobada");
            return;
        } 

        //VTV desaprobada

        if (HcPpm > 100)
        {
            Debug.Log("VTV no aprobada");
            return;
        }

        //VTV aprobada por dos años

        if (promedioAñosAuto < promedioMax)
        {
            Debug.Log("VTV aprobada por dos años.");
            return;
        }

        //VTV aprobada por un año

        if (promedioAñosAuto > promedioMax)
        {
            Debug.Log("VTV aprobada por un año.");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
