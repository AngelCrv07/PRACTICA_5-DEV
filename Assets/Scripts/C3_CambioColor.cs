using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C3_CambioColor : MonoBehaviour
{
    public Color colorNuevo = Color.white;  // Color al que cambiará la baldosa (igual se puede escoger)
    private Material BaldosaCambio;  

    private void Start()
    {
        
        BaldosaCambio = GetComponent<Renderer>().material;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            BaldosaCambio.color = colorNuevo;  // Cambia al nuevo color
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            BaldosaCambio.color = Color.blue;  // Restaura el color
        }
    }   
}
