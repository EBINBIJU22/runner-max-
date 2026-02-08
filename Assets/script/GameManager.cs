using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    private int score = 0;
    //private AudioSource COLLECTSOUND;
    public AudioSource audioSource;
    public AudioClip soundClip;



    void Awake()
    {
        if (instance == null) instance = this;
    }

    void Start()
    {
        scoreText.text = " 0";
        gameOverPanel.SetActive(false);
        //COLLECTSOUND = GetComponent<AudioSource>();
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = " " + score;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f; // freeze game
        audioSource.PlayOneShot(soundClip);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnCollisionEnter(Collision collision)
    {
    if (collision.gameObject.CompareTag("Coin"))
        {
            //COLLECTSOUND.Play();
            AddScore(10); // Assuming each coin gives 10 points
            Destroy(collision.gameObject);
        }


    }


}