using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public List<GameObject> objs = new List<GameObject>();//Prefabs

    public float Duration; //间隔生成物体的时间
    private float countTime;
    private List<int> ranList;
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("Objs Count {0}", objs.Count);
        ranList = Utils.MakeRandomList(0, objs.Count);
        SpawnPlatforms();
    }

    // Update is called once per frame
    void Update()
    {

        countTime += Time.deltaTime;
        if (countTime >= Duration)
        {
            SpawnPlatforms();
            this.countTime = 0;
        }


    }

    void SpawnPlatforms()
    {
        Vector3 pos = getRandomPosition();
        // Debug.LogFormat("pos ::: {0}  {1}", pos.x, pos.y);
        GameObject obj = getRandomPlatform();
        GameObject newSpawn = Instantiate(obj, pos, Quaternion.identity);

        newSpawn.transform.SetParent(this.gameObject.transform);

    }

    Vector3 getRandomPosition()
    {
        //0.16 ~ 9.22
        float ranX = Random.Range(0.16f, 4.07f);
        return new Vector3(ranX, gameObject.transform.parent.Find("DeadLine").position.y, gameObject.transform.position.z);
    }


    private int lastIdx;
    //从当前备选物品列表中随机选一个    
    GameObject getRandomPlatform()
    {

        int ranX = Utils.GetRandomNoRepeat(ranList, lastIdx);
        lastIdx = ranX;
        return objs[ranX];
    }

}
