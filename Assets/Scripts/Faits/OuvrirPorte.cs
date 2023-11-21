using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvrirPorte : MonoBehaviour
{
    [SerializeField] GameObject _porteDroite;
    [SerializeField] GameObject _porteGauche;
    [SerializeField] GameObject _joueur;

   void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            _porteGauche.GetComponent<Animator>().SetBool("Ouvre",true);
            _porteDroite.GetComponent<Animator>().SetBool("Ouvre",true);
        } 
    }

    void OnTriggerExit(Collider other)
    {
        _porteGauche.GetComponent<Animator>().SetBool("Ouvre",false);
        _porteDroite.GetComponent<Animator>().SetBool("Ouvre",false);
    }
}
