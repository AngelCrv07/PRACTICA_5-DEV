using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C2_Velocidad : MonoBehaviour
{
    public float multiplicadorVel = 2f; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Codigo del jugador para moverse
            S4_MovCompuesto movimiento = other.GetComponent<S4_MovCompuesto>();
            if (movimiento != null)
            {
                movimiento.velocidad_movimiento *= multiplicadorVel;  // Aumenta la velocidad
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            S4_MovCompuesto movimiento = other.GetComponent<S4_MovCompuesto>();
            if (movimiento != null)
            {
                movimiento.velocidad_movimiento /= multiplicadorVel;  // Restaura la velocidad
            }
        }
    }
}


