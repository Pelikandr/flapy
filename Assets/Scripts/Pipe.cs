using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    Rigidbody2D pipe;
    private Bird bird;
    public float moveSpeed;
    private int count = 1;
    Transform p;


    // Use this for initialization
    void Start()
    {
        bird = (Bird)FindObjectOfType(typeof(Bird));
        pipe = gameObject.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
        p = gameObject.GetComponent(typeof(Transform)) as Transform;
    }

    // Update is called once per frame
    void Update()
    {
        
        pipe.velocity = new Vector2(pipe.velocity.y, moveSpeed);

        if (pipe.position.x < -1)
        {
            if (count < 2)
            {
                float range = Random.Range(-1, 2);
                Instantiate(pipe, new Vector2(11, range), transform.rotation);
                count++;
            }
        }
        if (pipe.position.x < -12)
        {
            Destroy(gameObject);
            count--;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            bird.Death();
        }

    }
}
