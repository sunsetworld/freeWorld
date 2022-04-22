using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] SpriteRenderer sP;
    [SerializeField] Sprite fallingEnemy;
    [SerializeField] Sprite standingEnemy;

    bool landed;
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] float speed;
    public float spawnX;

    public PlayerMovement pM;
    private GameObject player;

    float movementX = 1;
    // Start is called before the first frame update
    void Start()
    {
        landed = false;
        sP.sprite = fallingEnemy;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (landed)
        {
            StartCoroutine(moveEnemy());
        }
    }

    IEnumerator moveEnemy()
    {
        yield return new WaitForSeconds(3);
       // transform.Translate(transform.position.x, movementX, transform.position.z);
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

}
