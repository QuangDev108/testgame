using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Bird : MonoBehaviour
{
    [SerializeField]protected Rigidbody2D rb;
    public float jumpForce = 8f;
    protected bool levelStart = false;
    public GameObject gameController;
    public int score = 0;
    public TextMeshProUGUI scoreText;
    void Awake()
    {
        gameController = GameObject.Find("GameController");
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.ControlBird();
    }

    protected virtual void ControlBird()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.UpArrow))
        {
          SoundController.instance.PlayThisSound("wing", 0.5f);
            Time.timeScale = 1f;

            this.levelStart = true;
            this.rb.gravityScale = 4;
            this.gameController.GetComponent<SpawnPipe>().enableGenratePipe = true;
            this.BirdMoveUp();
        }    
    }    

    protected virtual void BirdMoveUp()
    {
        rb.velocity = Vector2.up * jumpForce ;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundController.instance.PlayThisSound("hit", 0.5f);

        Invoke("ReloadScence",0.25f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SoundController.instance.PlayThisSound("point", 0.5f);

        this.score += 1;
        scoreText.text = this.score.ToString();
    }

    protected virtual void ReloadScence()
    {
        SceneManager.LoadScene(0);
    }    
}
