using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDirection : MonoBehaviour {

    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        float changeX = Input.gyro.attitude.x;
        float changeY = Input.gyro.attitude.y;
  

        transform.Rotate(0, 0, changeX);
    }


}