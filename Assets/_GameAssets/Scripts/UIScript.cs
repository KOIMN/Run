using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{ public AudioSource audioSource;
  public AudioClip loopIntro;
  public AudioClip click;
  public void Jugar(){
    SceneManager.LoadScene(1);
 } 
  public void Exit(){
        Application.Quit();

    }
    public void PlayClick(){
      audioSource.PlayOneShot(click);
    }
 
}