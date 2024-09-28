using UnityEngine;

public class C3_ReboteColision : MonoBehaviour
{
    public float fuerzaRebote = 500f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 direccionRebote = collision.contacts[0].normal;
                rb.AddForce(-direccionRebote * fuerzaRebote);
                Debug.Log("Rebote aplicado.");
            }
        }
    }
}
