using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class LineDirection : MonoBehaviour
{

    float dirX, dirY;
    AudioSource ding;

    // Use this for initialization
    void Start()
    {
        dirX = 1f;
        dirY = 0f;

        ding = GetComponent<AudioSource>();
    }

    
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag.Equals("Enemy"))
        {
            Debug.Log("Collision");
            for (int i = 0; i < Input.touchCount; ++i)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    Debug.Log("Destroy");
                    Destroy(other.gameObject);
                }
            }
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                ding.Play();
            }
        }
        dirX = Input.acceleration.x;//May need to flip so that the ray will point up rather than down
        dirY = Input.acceleration.y;//Same here
        if (dirX >= 0)
            transform.rotation = Quaternion.Euler(0f, 0f, 180 + Mathf.Rad2Deg * Mathf.Atan(dirY / dirX));
        else
            transform.rotation = Quaternion.Euler(0f, 0f, Mathf.Rad2Deg * Mathf.Atan(dirY / dirX));
    }




}