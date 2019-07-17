using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRotate : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    public int rotateSpeed = 2;

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(0, rotateSpeed, 0, Space.World); // Rotate in the y axis and make sure it is relative to the world around you by referencing the world 
    }
}
