using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour {
    protected Animator animator;
    public int moveSpeed;

    private Vector3 movement;
    void Start()
    {
        movement.y = moveSpeed;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveHandler();
    }

    void moveHandler()
    {
        transform.position += movement * Time.deltaTime;

    }
}