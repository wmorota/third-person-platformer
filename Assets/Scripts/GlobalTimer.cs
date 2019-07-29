using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalTimer : MonoBehaviour
{

  public GameObject timeDisplay01;
  public GameObject timeDisplay02;
  public bool decrementTime = false;
  public int seconds = 101;
  public static int extendScore;

    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
      extendScore = seconds; 

      if(decrementTime  == false)
      {
        StartCoroutine(SubtractSecond());
      }
    }

    IEnumerator SubtractSecond()
    {
      decrementTime = true;
      seconds -= 1;
      timeDisplay01.GetComponent<Text>().text = "" + seconds;
      timeDisplay02.GetComponent<Text>().text = "" + seconds;
      yield return new WaitForSeconds(1) ;
      decrementTime = false;
    }



}
