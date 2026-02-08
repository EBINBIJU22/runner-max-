using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
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
       /* if(Input.GetKey(KeyCode.W))
        {
            transform.position=Vector3.MoveTowards(transform.position, transform.position + Vector3.forward, 0.1f);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.back, 0.1f);

        }*/
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.left, 0.1f);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.right, 0.1f);
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            GameManager.instance.AddScore(1);
            audioSource.PlayOneShot(soundClip);


            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            GameManager.instance.GameOver();
        }
    }
}
