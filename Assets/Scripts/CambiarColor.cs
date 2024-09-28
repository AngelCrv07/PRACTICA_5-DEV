using UnityEngine;

public class   CambiarColor : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Renderer rend = GetComponent<Renderer>();
            if (rend != null)
            {
                rend.material.color = Color.red; 
                Debug.Log("Color cambiado en colisión con el jugador.");
            }
        }
    }
}
