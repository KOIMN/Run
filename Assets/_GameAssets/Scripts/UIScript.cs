using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{ 
  public AudioSource LoopIntro;
  public void Jugar(){
    SceneManager.LoadScene(1);
 } 
  public void Exit(){
        Application.Quit();

    }
 
}