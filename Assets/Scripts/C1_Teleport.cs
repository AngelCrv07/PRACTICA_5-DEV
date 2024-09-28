using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1_Teleport : MonoBehaviour
{
    public Transform teleportDestino;  

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = teleportDestino.position;  // Cambia la posición del jugador
        }
    }
}
