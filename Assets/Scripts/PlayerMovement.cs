using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D myRB;
    [SerializeField] float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRB.MovePosition(new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
                myRB.MovePosition(new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y));
        }
    }
}
