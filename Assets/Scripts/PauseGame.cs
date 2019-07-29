﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{

  public bool gamePaused = false;
  public AudioSource levelMusic;
  public GameObject pauseMenu;
  public AudioSource pauseJingle;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
          if (gamePaused == false)
          {
            pauseJingle.Play(); 
            Time.timeScale = 0;
            gamePaused = true;
            Cursor.visible = true;
            levelMusic.Pause();
            pauseMenu.SetActive(true);
          }
          else
          {
            pauseMenu.SetActive(false);
            Cursor.visible = false;
            gamePaused = false;
            Time.timeScale = 1;
            levelMusic.UnPause();
          }
        }
    }

    public void ResumeGame()
    {
      pauseMenu.SetActive(false);
      Cursor.visible = false;
      gamePaused = false;
      Time.timeScale = 1;
      levelMusic.UnPause();
    }

    public void RestartLevel()
    {
      pauseMenu.SetActive(false);
      Cursor.visible = false;
      gamePaused = false;
      Time.timeScale = 1;
      levelMusic.UnPause();
      SceneManager.LoadScene(2);
    }

    public void QuitToMenu()
    {
      pauseMenu.SetActive(false);
      Cursor.visible = true;
      gamePaused = false;
      Time.timeScale = 1;
      levelMusic.UnPause();
      SceneManager.LoadScene(1);
    }
}
