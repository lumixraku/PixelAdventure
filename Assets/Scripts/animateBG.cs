using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateBG : MonoBehaviour
{
    public Vector2 moveSpeed;
    public Vector2 offset;
    private Material material;
    // Start is called before the first frame update
    void Start()
    {   
        material = GetComponent<Renderer>().material ;
        //material.SetTextureOffset("brownBG", moveSpeed);
        material.mainTextureOffset = moveSpeed;
    }   
         
    // Update is called once per frame
    void Update()
    {
        offset = material.mainTextureOffset;
        material.mainTextureOffset += moveSpeed * Time.deltaTime;
        // Debug.LogFormat("delta time {0}", Time.deltaTime); Time.deltaTime 是一帧所经历的时间
    }
}
