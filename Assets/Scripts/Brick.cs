
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brick : MonoBehaviour
{
    
    public SpriteRenderer spriteRenderer { get; private set; }
    public int health { get; private set; }
    public Sprite[] states;
    public bool unbreakable;
    public int points = 100;



    private void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();

    }

    private void Start()
    {
        if (!this.unbreakable)
        {
            this.health = this.states.Length;
            this.spriteRenderer.sprite = this.states[this.health - 1];

        }
        }

        private void Hit()
        {

            if(this.unbreakable)
            {
                return;
            }


            this.health--;

            if (this.health <= 0)
            {
                this.gameObject.SetActive(false);

            }
            else
            {
                this.spriteRenderer.sprite = this.states[this.health - 1];
            }

        FindObjectOfType<GameManager>().Hit(this);



        }

        private void OnCollisionEnter2D(Collision2D collision)
        {

        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (collision.gameObject.name == "Ball")
            {
                Hit();
            }
        }


    }




