using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class GameController : MonoBehaviour {
    AudioSource ding;
	// Use this for initialization
	void Start () {
        //WWW audioLoader = new WWW("file:///C:/Users/David/Documents/GravityBase/Assets/Sounds");

        ding = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                ding.Play();
                Handheld.Vibrate();
                // Construct a ray from the current touch coordinates
                //Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                // Create a particle if hit
                //if (Physics.Raycast(ray))
                //    Instantiate(particle, transform.position, transform.rotation);
            }
        }
    }
}
