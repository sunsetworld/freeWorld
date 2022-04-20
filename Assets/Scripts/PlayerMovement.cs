using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D myRB;
    [SerializeField] float moveSpeed;
    float movement;

    [SerializeField] Camera c;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(movement.ToString());
        movementArrows();
    }

    private void LateUpdate()
    {
        
    }

    private void movementArrows()
    {
        movement = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        if (movement == 0)
        {
            return;
        }
        else if (movement > 0)
        {
            myRB.MovePosition(new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y));
        }
        else if (movement < 0)
        {
            myRB.MovePosition(new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y));
        }
    }

    public float GetTransformX()
    {
        float transformX = transform.position.x;
        return transformX;
    }

}
