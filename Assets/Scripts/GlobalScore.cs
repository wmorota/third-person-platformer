using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    public GameObject scoreBox;
    public static int currentScore;  // MASTER SCORE
    public int internalScore;       // viewing purposes

    // Update is called once per frame
    void Update()
    {
        internalScore = currentScore;
        scoreBox.GetComponent<Text>().text = "" + internalScore;

    }
}
