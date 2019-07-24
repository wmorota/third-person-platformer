using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{

  public GameObject youFallen;
  public GameObject levelAudio;
  public GameObject fadeOutAnimation;

    void OnTriggerEnter()
    {
      StartCoroutine(YouFellOff());
    }

    IEnumerator YouFellOff ()
    {
      youFallen.SetActive(true);
      levelAudio.SetActive(false);
      yield return new WaitForSeconds(2);
      fadeOutAnimation.SetActive(true);
      yield return new WaitForSeconds(1);
      SceneManager.LoadScene(0) ;
    }

}
