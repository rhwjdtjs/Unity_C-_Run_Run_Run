using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //싱글턴
    public static bool isPlayerDead=false; //플레이어는 초기에 살아있는상태
    public static int DeadCount = 0; //데스 카운트 0부터시작
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance = this; //싱글턴화
        DontDestroyOnLoad(this.gameObject);
        Debug.Log(isPlayerDead);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
