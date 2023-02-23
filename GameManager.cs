using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static bool isPlayerDead=false;
    public static int DeadCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance = this;
        DontDestroyOnLoad(this.gameObject);
        Debug.Log(isPlayerDead);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
