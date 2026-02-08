using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Audio;


public class NewMonoBehaviourScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clicksound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private System.Collections.IEnumerator play()
    {
        audioSource.PlayOneShot(clicksound);
        yield return new WaitForSeconds(clicksound.length);
        Debug.Log("game was worked developed by ebinbiju, Continue is Currently Unavailable");
        SceneManager.LoadScene(1);

    }
    private System.Collections.IEnumerator contiune()
    {
        audioSource.PlayOneShot(clicksound);
        yield return new WaitForSeconds(clicksound.length);
        SceneManager.LoadScene(2);


    }

    
    
    public void Play()
    {
        StartCoroutine(play());

    }


}
