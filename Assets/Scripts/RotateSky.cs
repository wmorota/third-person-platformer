using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    public float rotateSpeed = 2.5f;

    // Update is called once per frame
    void Update()
    {
      RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
    }
}
