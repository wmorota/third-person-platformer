// These top lines are called namespace
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemGreen : MonoBehaviour
{
    // Start is called before the first frame update
    //oid Start()
    //{

    //}



    // Update is called once per frame
    //void Update()
    //{

    //}

    // When you add these variables they appear in the Unity script little area where you can assign it to which i guess file or asset or object you have
    public GameObject scoreBox;            // GameObject is a variable type
    public AudioSource collectSound;       // AudioSource is also a variable type

    void OnTriggerEnter()
    {
      scoreBox.GetComponent<Text>().text = "1000"; 
      collectSound.Play();
      Destroy(gameObject);                 // Makes gameObject dissapear (which is the Green Gem objects that we drag it to I assume)

    }


}
