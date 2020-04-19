using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void GetMessage(GameObject _g)
    {
        Debug.Log(this.gameObject.name+" Get: "+_g.name);
    }
    void GetMessage(string _s)
    {
        Debug.Log(this.gameObject.name + " Get: "+_s);
    }

    void GetMessage(bool _b)
    {
        Debug.Log(this.gameObject.name + " Get: "+_b.ToString());
    }

}
