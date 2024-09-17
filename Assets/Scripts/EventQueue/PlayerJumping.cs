using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumping : MonoBehaviour
{
    public float jumpForce = 5f;

    private Rigidbody rb;
    private EventQueue eventQueue;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        eventQueue = GetComponent<EventQueue>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            eventQueue.EnqueueEvent(GameEvent.PlayerJump);
        }
    }

    public void Jump()
    {
        Debug.Log("Saltanding");
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
