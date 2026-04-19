using UnityEngine;

public class BallController : MonoBehaviour
{
    public float fuerza = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 direccion = (transform.position - collision.transform.position).normalized;
            rb.AddForce(direccion * fuerza, ForceMode.Impulse);
        }
    }
}