using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour {

    public GameObject asteroidObj;

    public float health = 300f;

	// Use this for initialization
	void Start () {
       
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {

        AsteroidController asteroid = collision.gameObject.GetComponent<AsteroidController>();

        if (asteroid)
        {
            health -= asteroid.getDamage();

            asteroid.Hit();
            if (health <= 0)
            {
                Application.Quit();
            }

        }

        Debug.Log("Hit by Asteroid");

    }

    // Update is called once per frame
    void Update () {
		
	}
}
