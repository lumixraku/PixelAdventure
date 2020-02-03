using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI countTime;
    public GameObject gameOverPanel;
    // public Text countTime2;

    public static GameManager instance;
    // 这是 C# 中的做法 继承了 MonoBehaviour 的类有特别的生命周期
    // 且建议在 Awake 和 Start 中做初始化
    // public static GameManager Instance
    // {
    //     get
    //     {
    //         if (instance == null)
    //         {
    //             instance = new GameManager();
    //         }
    //         return instance;
    //     }
    // }

    void Awake()
    {
        // if (instance == null)
        // {
        //     instance = new GameManager();
        // }
        instance = this; //当其他的类访问gameObject 的时候实际上是用的instance //而变量的初始化都在this里面
    
    }

    void Start()
    {

        // GameObject.Find("/Canvas/GameOverPanel").gameObject.SetActive(false);        
        gameOverPanel.SetActive(false);
    }

    public void ReStartHandler()
    {
        //countTime.text = Time.time.ToString("00");
        Debug.LogFormat("reloadHandler {0}", gameOverPanel.activeSelf);

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    private void FixedUpdate()
    {
        countTime.text = Time.timeSinceLevelLoad.ToString("00");
    }

    public void GameOver()
    {
        showGameOverPanel();
        Time.timeScale = 0f;
    }

    private void showGameOverPanel()
    {
        gameOverPanel.SetActive(true);

    }
}
