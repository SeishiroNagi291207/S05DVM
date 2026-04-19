using UnityEngine;

public class GoalZone : MonoBehaviour
{
    public string nombreArco;
    public Transform puntoCentral; // centro del campo

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("Gol en: " + nombreArco);

            Rigidbody rb = other.GetComponent<Rigidbody>();

            // Mover la pelota al centro
            other.transform.position = puntoCentral.position;

            // Resetear movimiento
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}