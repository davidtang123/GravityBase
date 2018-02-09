using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(AudioSource))]
public class GameController : MonoBehaviour {
    AudioSource ding;
	// Use this for initialization
	void Start () {

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
                //Vector3 touchpos = new Vector3(Input.GetTouch(i).position.x, Input.GetTouch(i).position.y, 0);

                //Gizmos.color = Color.red;
                //Gizmos.DrawRay(transform.position, (touchpos - transform.position)*10);
                //Debug.Log(Input.GetTouch(i).position.x + ", " + Input.GetTouch(i).position.y);


                /*
                GameObject ray = new GameObject();
                ray.transform.position = this.transform.position;
                ray.AddComponent<LineRenderer>();
                LineRenderer lr = ray.GetComponent<LineRenderer>();
                lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
                lr.startColor = Color.red;
                lr.endColor = Color.red;
                lr.startWidth = 0.5f;
                lr.endWidth = 0.5f;
                lr.SetPosition(0, transform.position);
                lr.SetPosition(1, new Vector3(5,5,0));
                //GameObject.Destroy(ray, 2);
                */
            }
        }
    }
}
