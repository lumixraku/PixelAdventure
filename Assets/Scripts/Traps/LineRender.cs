using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRender : MonoBehaviour
{

    LineRenderer lr;
    public GameObject fixedPoint;
    public GameObject spikeBall;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fixedPoint && spikeBall)
        {

            lr.SetPosition(0, fixedPoint.transform.position);
            lr.SetPosition(1, spikeBall.transform.position);
        }else {
            Destroy(lr);
        }

    }
}
