using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OuvrirPorteHaut : MonoBehaviour
{

[SerializeField] GameObject _zonePorteHaut;

   void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            _zonePorteHaut.GetComponent<Animator>().SetBool("Ouvre",true);
        } 
    }

    void OnTriggerExit(Collider other)
    {
        _zonePorteHaut.GetComponent<Animator>().SetBool("Ouvre",false);
    }
}
