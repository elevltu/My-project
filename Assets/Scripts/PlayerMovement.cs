using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static Rigidbody2D rb;
    public float speed;
    public static float internalSpeed;
    public GameObject bullet;
    private bool shootCooldown;
    public static int shotDelay;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        shootCooldown = false;
        shotDelay = 1000;
        internalSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-internalSpeed, rb.velocity.y);
            rb.SetRotation(90);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(internalSpeed, rb.velocity.y);
            rb.SetRotation(270);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(rb.velocity.x, internalSpeed);
            rb.SetRotation(0);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(rb.velocity.x, -internalSpeed);
            rb.SetRotation(180);
        }
        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))&& (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)))
        {
            rb.velocity.Normalize();
            rb.SetRotation(45);
        }
        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)))
        {
            rb.velocity.Normalize();
            rb.SetRotation(315);
        }
        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)))
        {
            rb.velocity.Normalize();
            rb.SetRotation(135);
        }
        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)))
        {
            rb.velocity.Normalize();
            rb.SetRotation(225);
        }
        if (Input.GetKeyDown(KeyCode.Space) && !shootCooldown) {
            Instantiate(bullet);
            shootCooldown = true;
            DelayBetweenShots();
        }
    }
    async void DelayBetweenShots()
    {
        await Task.Delay(shotDelay);
        shootCooldown = false;
    }
}
