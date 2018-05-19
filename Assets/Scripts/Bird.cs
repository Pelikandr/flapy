using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    public Rigidbody2D bird;
    public float flapHeight;
	// Use this for initialization
	void Start () {
        bird = gameObject.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
           if (touch.phase == TouchPhase.Began)
            {
                bird.velocity = new Vector2(bird.position.x, flapHeight);
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            bird.velocity = new Vector2(bird.position.x, flapHeight); 
        }
        
        if(transform.position.y > 5 || transform.position.y < -5)
        {
            Death();
        }
        
	}

    public void Death()
    {
        bird.velocity = Vector3.zero;
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(3);
#pragma warning restore CS0618 // Type or member is obsolete
    }
}
