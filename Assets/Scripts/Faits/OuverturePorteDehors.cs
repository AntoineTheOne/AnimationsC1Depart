using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuverturePorteDehors : MonoBehaviour
{
   [SerializeField] GameObject porteEntree;
   [SerializeField] GameObject maClef;

   [SerializeField] GameObject maHitBox;


private void OnTriggerEnter(Collider other)
{
    if(other.tag == "Player"){
        porteEntree.GetComponent<Animator>().SetTrigger("OuvrirLaPorte");
        maHitBox.SetActive(false);
        maClef.SetActive(false);
    }
}

}
