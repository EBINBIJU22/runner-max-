using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COINSOUND : MonoBehaviour
{
    public AudioSource  coinaudiosource;
    public AudioClip coinclip;

    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
      
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            coinaudiosource.PlayOneShot(coinclip);
            Destroy(gameObject, coinclip.length); // Destroy the coin after the sound has played
        }
    }


}
