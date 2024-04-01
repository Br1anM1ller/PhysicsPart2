using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushableObject : MonoBehaviour
{
    public float explosionForce = 10f;
    public float explosionRadius = 5f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Rigidbody ballRigidbody = other.GetComponent<Rigidbody>();
            if (ballRigidbody != null)
            {
                Vector3 explosionPosition = transform.position;
                Collider[] colliders = Physics.OverlapSphere(explosionPosition, explosionRadius);
                foreach (Collider hit in colliders)
                {
                    Rigidbody rb = hit.GetComponent<Rigidbody>();

                    if (rb != null)
                    {
                        rb.AddExplosionForce(explosionForce, explosionPosition, explosionRadius, 3.0F);
                    }
                }
            }
        }
    }
}
