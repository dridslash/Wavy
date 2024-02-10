using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{

    private float projectileSpeed = 5f;

    public Rigidbody2D ArrowRidgidBody;

    public bool ArrowCollided = false;

    public float WorldLimit = 9.43f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!ArrowCollided)
            ArrowRidgidBody.velocity += Vector2.right * projectileSpeed;
        if (transform.position.x >= WorldLimit)
            Destroy(gameObject,0.2f);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        FindAnyObjectByType<AudioManager>().PlaySound("Arrowcollision");
        // if (other.gameObject.tag.Equals("Gate")){
            ArrowCollided = true;
            Destroy(gameObject,0.5f);
        // }
    }
}
