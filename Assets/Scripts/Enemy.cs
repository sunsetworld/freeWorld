using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] SpriteRenderer sP;

    [SerializeField] Sprite fallingEnemy;

    [SerializeField] Sprite standingEnemy;

    private Transform player;
    bool landed;
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] float speed;
    float spawnX;
    // Start is called before the first frame update
    void Start()
    {
        landed = false;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        sP.sprite = fallingEnemy;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveTowardsPlayer();
    }





    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            sP.sprite = standingEnemy;
            landed = true;
        }
        if (collision.gameObject.tag == "Player")
        {
            if (landed == false)
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }

        }
        if (collision.gameObject.tag == "Enemy")
        {
            if (landed == false)
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }

        }



    }

    void MoveTowardsPlayer()
    {
        if (landed)
        {
            if (player != null)
            {
                rb2d.MovePosition(Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime));
            }
        }
    }
}
