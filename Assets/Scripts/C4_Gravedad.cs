using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C4_Gravedad : MonoBehaviour
{
    public float gravedadMultiplicador = 0.6f;  
    private Rigidbody playerRb;  
    private bool enZona = false;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            playerRb = other.GetComponent<Rigidbody>(); 
            enZona = true;  
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerRb = null;  
            enZona = false;  
        }
    }

    private void FixedUpdate()
    {
        
        if (enZona && playerRb != null)
        {
            
            playerRb.AddForce(Vector3.down * gravedadMultiplicador * Physics.gravity.magnitude, ForceMode.Acceleration);
        }
    }
}