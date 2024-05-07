using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5, bulletSpeed;
    private float horizontal;
    public Rigidbody2D body;
    public float jumpStrenth;
    public GameObject bullet;
    public Transform foot;
    public bool groundCheck;
    public int life = 1;
    int direction = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && groundCheck)
        {
            body.AddForce(new Vector2(0, jumpStrenth * 100));
        }
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject temp = Instantiate(bullet, transform.position, transform.rotation);
            temp.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed, 0);
        }
        if (horizontal != 0)
        {

            direction = (int)horizontal;

        }

        horizontal = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(horizontal * speed, body.velocity.y);
        groundCheck = Physics2D.OverlapCircle(foot.position, 0.05f);

    }
    
}
