using UnityEngine;

public class Nuke : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5f;
    public GameObject explosion;
    public float TimeToExplode;
    public bool haveActiveCooldown;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Moves the rigid body forward along the z-axis
        rb.velocity = transform.forward * speed; 
        if (haveActiveCooldown)
        {
            TimeToExplode -= Time.deltaTime;
            if (TimeToExplode <= 0)
            {
                Instantiate(explosion, transform);
                Destroy(gameObject.GetComponent<Nuke>());
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BoomTrigger")
        {
            haveActiveCooldown = true;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}