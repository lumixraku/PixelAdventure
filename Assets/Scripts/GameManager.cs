using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI countTime;
    // public Text countTime2;

    public static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }
    void Start() {
        // countTime = GetComponent<TextMeshProUGUI>();
        Debug.LogFormat("countTime ::: {0}", countTime);
        // countTime.text = Time.time.ToString("00");
        Debug.LogFormat("Found??  {0}", GameObject.Find("/Canvas/GameOverPanel").GetType().ToString());
        
    }   

    private void reloadHandler()
    {
        //countTime.text = Time.time.ToString("00");
    }
    private void FixedUpdate() {
        countTime.text = Time.time.ToString("00");
    }


}
