using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toca : MonoBehaviour
{


    public AudioSource quienEmite ;
    public AudioClip elSonido;
    public float volumen = 20000f;

   

   
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(elSonido, gameObject.transform.position);
        Destroy(gameObject);
        
    }   
        
 
}
