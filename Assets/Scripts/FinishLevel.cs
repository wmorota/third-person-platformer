﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;

    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;

    public int timeCalc;
    public int scoreCalc;
    public int totalScored;

    public GameObject levelBlocker;

    public GameObject fadeOut;

    void OnTriggerEnter()
    {
      GetComponent<BoxCollider>().enabled = false ;
      levelBlocker.SetActive(true);
      levelBlocker.transform.parent = null;
      timeCalc = GlobalTimer.extendScore * 100;
      timeLeft.GetComponent<Text>().text = "Time Left: " + GlobalTimer.extendScore + " x 100";
      theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
      totalScored = GlobalScore.currentScore + timeCalc;
      totalScore.GetComponent<Text>().text = "Total Score: " + totalScored ;
      levelMusic.SetActive(false);
      levelTimer.SetActive(false);
      levelComplete.Play();
      StartCoroutine(CalculateScore());
    }

    IEnumerator CalculateScore()
    {
      timeLeft.SetActive(true);
      yield return new WaitForSeconds(0.5f);
      theScore.SetActive(true);
      yield return new WaitForSeconds(0.5f);
      totalScore.SetActive(true);
      yield return new WaitForSeconds(3.5f);
      fadeOut.SetActive(true);
    }
}
