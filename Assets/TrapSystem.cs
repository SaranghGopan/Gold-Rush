using UnityEngine;

public class TrapSystem : MonoBehaviour
{
    public GameObject gameOverPanel;
    public AudioSource gameOverAudioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverPanel.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Trap")
        {
            Debug.Log(collision.gameObject.tag);
            gameOverAudioSource.Play();
            gameOverPanel.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pit")
        {
            Debug.Log(collision.gameObject.tag);
            gameOverAudioSource.Play();
            gameOverPanel.SetActive(true);
        }
    }
}


