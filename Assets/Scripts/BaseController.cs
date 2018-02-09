using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseController : MonoBehaviour {

    public GameObject asteroidObj;

    public float health;
    AudioSource boom;

    // Use this for initialization
    void Start () {

        boom = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        AsteroidController asteroid = collision.gameObject.GetComponent<AsteroidController>();

        
        health -= asteroid.getDamage();
        Debug.Log(health);
        asteroid.Hit();


        boom.Play();
        Handheld.Vibrate();

        Debug.Log("Hit by Asteroid");

    }


    // Update is called once per frame
    void Update () {

        

        if (health <= 0)
        {
            Debug.Log("GAME OVER");
            SceneManager.LoadScene("GameOver");
            
        }
    }
}
