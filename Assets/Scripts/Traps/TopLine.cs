using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.LogFormat("collider enter {0}", other.gameObject.tag);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.LogFormat("collider {0}", other.gameObject.tag);
        if (other.gameObject.CompareTag("Platform") ||
            other.gameObject.CompareTag("Spike")
            )
        {
            Destroy(other.gameObject);

        }
    }
}
