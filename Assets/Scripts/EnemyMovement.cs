using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D player;
    private float playerX; private float playerY;
    private Rigidbody2D rb;
    private Vector2 movementDirection;
    public float speed;
    public static float internalSpeed;
    private int screenWidth;
    private int screenHeight;
    private int screenRatio;
    // Start is called before the first frame update
    void Start()
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
        screenRatio = Screen.width / Screen.height;
        rb = gameObject.GetComponent<Rigidbody2D>();
        player = PlayerMovement.rb;
        int randomChoice = Random.Range(1, 4);
        if (randomChoice == 1)
        {
            rb.position = new Vector2(player.position.x+screenRatio*5, player.position.y + Random.Range(-6, 6));
        }
        if (randomChoice == 2)
        {
            rb.position = new Vector2(player.position.x + screenRatio * -5, player.position.y + Random.Range(-6, 6));
        }
        if (randomChoice == 3)
        {
            rb.position = new Vector2(player.position.x + Random.Range(screenRatio*-5, screenRatio*5), player.position.y + 6);
        }
        if (randomChoice == 3)
        {
            rb.position = new Vector2(player.position.x + Random.Range(screenRatio * -5, screenRatio * 5), player.position.y + -6);
        }
        gameObject.tag = "Enemy";
        internalSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        playerX = PlayerMovement.rb.position.x;
        playerY = PlayerMovement.rb.position.y;
        movementDirection = new Vector2(playerX-rb.position.x, playerY-rb.position.y);
        movementDirection.Normalize();
        movementDirection *= (internalSpeed * Time.deltaTime);
        rb.position += movementDirection;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Bullet")
        {
            DestroyObject(collision.gameObject);
            DestroyObject(gameObject);
        }
    }
}
