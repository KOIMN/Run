using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public int capacidad = 100;
    public int municion = 0; 
    public float fuerza = 10;
    public GameObject prefabBala;
    public Transform transformSpawner;

    public AudioClip audioShoot;
    public AudioClip audioNoBullets;

    private Animator animator;

    public void Start(){
        municion = capacidad;
        animator = gameObject.GetComponentInChildren<Animator>();
    }
    public void IntentarDisparo(){
        if (municion>0){
            Disparar();
            animator.SetTrigger("Disparo");
        } else {
            GetComponent<AudioSource>().PlayOneShot(audioNoBullets);
        }
    }
    private void Disparar(){
        GetComponent<AudioSource>().PlayOneShot(audioShoot);
        municion--;
        GameObject bala = Instantiate(prefabBala,transformSpawner.position, transformSpawner.rotation);
        bala.GetComponent<Rigidbody>().AddForce(bala.transform.forward * fuerza);
    }

    public void Reload(){
        municion = capacidad;
    }
}
