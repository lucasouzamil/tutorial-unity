using UnityEngine;

public class PlayerMovemente : MonoBehaviour
{
    private Rigidbody2D rb;
    AudioSource audioSource;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Coletavel") {
            audioSource.Play();
            GameController.Collect();
            Destroy(other.gameObject);
        }
    }
}
