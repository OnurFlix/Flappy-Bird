using UnityEngine; 
using UnityEngine.InputSystem;

public class Bird : MonoBehaviour
{
    [SerializeField] private float jumpforce = 3f;
    private Rigidbody2D rb2D;
    public bool isGameOver;
    public GameManager gameManager;
    public GameObject DeathScreen;

    




    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rb2D.linearVelocityY = jumpforce;
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            gameManager.Updatescore();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
   {
        if (collision.gameObject.tag == "DeathArea")
        {
            isGameOver = true;
            Time.timeScale = 0; 
            
            DeathScreen.SetActive(true);
        }
    }
}