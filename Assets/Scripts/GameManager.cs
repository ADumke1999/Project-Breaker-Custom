
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public Ball ball { get; private set; }
    public Paddle paddle { get; private set; }
    public Brick[] bricks { get; private set; }

    const int NUM_LEVELS = 3;

    public int level = 1;
    public int score = 0;
    public int lives = 3;

    

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += OnLevelLoaded;

    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            SceneManager.LoadScene("StartScreen");
        }
        if (Input.GetKey(KeyCode.R))
        {
            ResetLevel();
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            
            PauseGame();
        }
        else if (Input.GetKey(KeyCode.C))
        {
            ResumeGame();
        }

    }

    


    //public void Start()
    //{
    //    NewGame();
    //}

    //public void NewGame()
    //{


    //    score = 0;
    //    lives = 3;


    //        LoadLevel(1);

    //}

    public void LoadLevel(int level)
    {
       this.level = level;

        SceneManager.LoadScene("Level" + level);

    }

    public void OnLevelLoaded(Scene scene, LoadSceneMode mode)
    {

        ball = FindObjectOfType<Ball>();
        paddle = FindObjectOfType<Paddle>();
        bricks = FindObjectsOfType<Brick>();


    }


    public void Hit(Brick brick)
    {
        score += brick.points;


        if (Cleared())
        {

            LoadLevel(level + 1);
        }

    }

    public bool Cleared()
    {
        for (int i = 0; i < bricks.Length; i++)
        {
            if (this.bricks[i].gameObject.activeInHierarchy && !bricks[i].unbreakable)
            {
                return false;
            }

        }

        return true;



    }


    public void ResetLevel()
    {
        
        ball.ResetBall();
        paddle.ResetPaddle();

    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //NewGame();
    }

    public void Miss()
    {
        lives--;

        if(lives > 0)
        {
            ResetLevel();
        }
        else
        {
            GameOver();
        }

    }

    public void PauseGame()
    {
        Time.timeScale = 0;

    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    

}
    
