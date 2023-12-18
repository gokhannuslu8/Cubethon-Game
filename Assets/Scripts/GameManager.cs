using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ 
   bool gameHasEnded = false;

   public float restartDelay = 1f;
   public float showContinueButtonDelay = 2f;

   public GameObject completelevelUI;
   public ContinueButton continueButtonScript;

   private void Start()
   {
      continueButtonScript = GetComponent<ContinueButton>();
   }

   public void CompleteLevel()
   {
      {
         completelevelUI.SetActive(true);
      }
   }

   public void EndGame()
   {
      if (gameHasEnded == false)
      {
         gameHasEnded = true; 
         Debug.Log("Game Over!");
         Invoke(nameof(Restart), restartDelay);
      }
   }
   
   private void Restart()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

}
