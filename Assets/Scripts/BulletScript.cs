using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private static int numOfBullets = 0;
    private int bulletNumber;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.rotation = PlayerMovement.rb.rotation;
        rb.position = PlayerMovement.rb.position;
        bulletNumber = numOfBullets;
        numOfBullets += 1;
        gameObject.tag = "Bullet";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (numOfBullets >= 20)
        {
            bulletNumber--;
            
            if (bulletNumber <= 0)
            {
                numOfBullets--;
                DestroyObject(gameObject);

                
            }
        }
        if (gameObject.transform.rotation.eulerAngles.z == 45)
        {
            rb.velocity = new Vector2(-7.17f, 7.17f);
        }
        if (gameObject.transform.rotation.eulerAngles.z == 90)
        {
            rb.velocity = new Vector2(-10, 0);
        }
        if (gameObject.transform.rotation.eulerAngles.z == 135)
        {
            rb.velocity = new Vector2(-7.17f, -7.17f);
        }
        if (gameObject.transform.rotation.eulerAngles.z == 180)
        {
            rb.velocity = new Vector2(0, -10);
        }
        if (gameObject.transform.rotation.eulerAngles.z == 225)
        {
            rb.velocity = new Vector2(7.17f, -7.17f);
        }
        if (gameObject.transform.rotation.eulerAngles.z == 270)
        {
            rb.velocity = new Vector2(10, 0);
        }
        if (gameObject.transform.rotation.eulerAngles.z == 315)
        {
            rb.velocity = new Vector2(7.17f, 7.17f);
        }
        if (gameObject.transform.rotation.eulerAngles.z == 0)
        {
            rb.velocity = new Vector2(0, 10);
        }
    }
}
