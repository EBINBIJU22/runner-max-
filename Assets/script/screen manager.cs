using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenmanager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void starscreen()
    {
        SceneManager.LoadScene(1);
        audioSource.PlayOneShot(soundClip);
    }

    public void optionsscreen()
    {
        SceneManager.LoadScene(2);
        audioSource.PlayOneShot(soundClip);
    }
    public void backmenu()
    {
     SceneManager.LoadScene(0);
        audioSource.PlayOneShot(soundClip);
    }
    public void exitgame()
    {
        SceneManager.LoadScene(2);
        Application.Quit(2);
        Debug.Log("Game is exiting");

    }
    public void playgame()
    {
        SceneManager.LoadScene(3);
        audioSource.PlayOneShot(soundClip);
    }
    public void exit()
    {
        SceneManager.LoadScene(0);
        audioSource.PlayOneShot(soundClip);

    }
    public void backtomainmeny()
    {
        SceneManager.LoadScene(1);
        audioSource.PlayOneShot(soundClip);
    }
    public void QUIT()
    {
        Application.Quit();
    }







}
