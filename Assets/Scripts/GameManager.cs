using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    void Start()
    {
        score = 0;
        if (scoreText == null)
        {
            scoreText.text = score.ToString();
        }


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Updatescore()
    {
        score++;
        scoreText.text = score.ToString();
    }


    public void RestartGame()
    {
        Time.timeScale = 1; // Bu satırı ekleyin veya güncelleyin
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("RestartGame çağrıldı");
     }
}
