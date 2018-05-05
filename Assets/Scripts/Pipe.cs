using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    Rigidbody2D pipe;
    Rigidbody2D pipe2;
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
    bool CheckDistance(Rigidbody2D pipe)
    {
        if (13 - pipe.position.x == 8)
        {
            return true;
        }
        else
            return false;
        /*
        if (pipe2.position.x - pipe1.position.x == 8)
        {
            return true;
        }
        else
            return false; */
    }
    void PipeGeneration(Rigidbody2D pipe)
    {
        if (13 - pipe.position.x == 8)
        {
            if (count < 4)
            {
                float range = Random.Range(-3, 0);
                Instantiate(pipe, new Vector3(11, -2), transform.rotation);
                count++;
            }

            if (pipe.position.x < -10)
            {
                Destroy(gameObject);
                count--;
            }
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
