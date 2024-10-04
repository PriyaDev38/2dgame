using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float movementSpeed = 10f;
    Rigidbody2D rbBody;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        rbBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }
    void Update()
    {

        Vector3 movementInput = new Vector3(Input.GetAxis("Horizontal"), transform.position.y, transform.position.z);
        if (movementInput.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
        rbBody.MovePosition(transform.position + movementInput * movementSpeed * Time.deltaTime);
    }
}
