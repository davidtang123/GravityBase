using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AsteroidController : MonoBehaviour {

    public float damage = 100f;
    public float asteroidSpeed;
    Transform player;
    NavMeshAgent nav;
    public Rigidbody2D rb;

    void Start()
    {
        //Initialize Position
        //MAth
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = -transform.position.normalized;
    }
    
    public float getDamage()
    {

        Debug.Log("Asteroid hit something");
        return damage;
        
    }
	
	public void Hit () {
        Destroy(gameObject);
	}

}
