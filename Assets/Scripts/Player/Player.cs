using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb; //父类已经有rigidBody成员变量了 //且不建议直接使用父类的rigidBody
    private Animator animator;
    public bool isOnPlatform;

    private float checkRadius = 0.489442f;
    public LayerMask platformLayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isOnPlatform = detectOnPlatform();
        float horizonInputValue = Input.GetAxis("Horizontal");
        toPlatform(isOnPlatform);
        movement(horizonInputValue);
    }

    void toPlatform(bool isOnPlatform)
    {
        animator.SetBool("isOnGround", isOnPlatform);
    }

    void movement(float horizonInputValue)
    {

        // Debug.LogFormat("horizonInputValue {0}", horizonInputValue);
        faceDirection(horizonInputValue);
        running(horizonInputValue);

    }

    //控制跑步  && 跑步的动画
    void running(float horizonInputValue)
    {

        animator.SetBool("horizonSpeed", Mathf.Abs(horizonInputValue) > Mathf.Epsilon);

        rb.velocity = new Vector2(horizonInputValue * speed * Time.fixedDeltaTime, rb.velocity.y);
    }

    void faceDirection(float horizonInputValue)
    {
        int faceDirection = 1;
        if (horizonInputValue > 0)
        {
            faceDirection = 1;
        }
        else if (horizonInputValue < 0)
        {
            faceDirection = -1;
        }
        transform.localScale = new Vector3(faceDirection, 1, 1);
    }

    Collider2D detectOnPlatform()
    {
        Collider2D coll = Physics2D.OverlapCircle(gameObject.transform.position, checkRadius, platformLayer);

        // bool? rs = Physics2D.OverlapCircle(gameObject.transform.position, checkRadius, platformLayer);
        return coll;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Spike"))
        {
            KillPlayer();
        }
        if (other.gameObject.CompareTag("DeadLine"))
        {
            KillPlayer();
            GameManager.instance.GameOver();
        }

    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.LogFormat("{0} OnCollisionEnter2D", other.gameObject.tag);
    }
    
    void KillPlayer()
    {   
        animator.Play("Hit");
    }

    void PlayerDestory()
    {
        Destroy(gameObject);

    }
}
