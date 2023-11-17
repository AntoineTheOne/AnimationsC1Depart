using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torcheapparait : MonoBehaviour
{


[SerializeField] GameObject torchPlayer;
[SerializeField] GameObject torchWall;



void OnTriggerEnter(Collider other)
{
        if(other.tag == "Player"){
            torchWall.SetActive(false);
            torchPlayer.SetActive(true);


        } 
}

}
