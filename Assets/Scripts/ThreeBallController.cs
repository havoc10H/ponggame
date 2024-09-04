using UnityEngine;

public class ThreeBallController : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ServeBall();
    }

    public void ServeBall()
    {
        float randomX = Random.Range(-1f, 1f);
        float randomZ = Random.Range(-1f, 1f);
        Vector3 serveDirection = new Vector3(randomX, 0, randomZ).normalized;

        rb.velocity = Vector3.zero;  // Reset velocity before applying force
        rb.AddForce(serveDirection * force, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            Vector3 reflectDirection = Vector3.Reflect(rb.velocity, collision.contacts[0].normal);
            rb.velocity = reflectDirection;
        }
    }
}
