using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public KeyCode LeftKey;
    public KeyCode RightKey;
    public float speed;

    private Rigidbody2D rig;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector3 input = GetInput();
        Debug.Log("Input: " + input); // Debug input
        MoveObject(input);
    }

    private Vector3 GetInput()
    {
        Vector3 input = Vector3.zero;
        if (Input.GetKey(RightKey))
        {
            Debug.Log("Right key pressed");
            input = Vector3.right * speed; // Move right
            spriteRenderer.flipX = false; // Flip sprite to face right
        }
        else if (Input.GetKey(LeftKey))
        {
            Debug.Log("Left key pressed");
            input = Vector3.left * speed; // Move left
            spriteRenderer.flipX = true; // Flip sprite to face left
        }
        return input;
    }

    private void MoveObject(Vector3 movement)
    {
        rig.velocity = movement;
    }
}
