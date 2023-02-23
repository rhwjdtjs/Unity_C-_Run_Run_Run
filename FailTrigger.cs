using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FailTrigger : MonoBehaviour
{
    private GameManager thegamemanager;
    private void Start()
    {
        thegamemanager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.isPlayerDead = true;
        Debug.Log(GameManager.isPlayerDead);
        GameManager.DeadCount += 1;
        Destroy(collision.gameObject);

        SceneManager.LoadScene("Stage1");
    }


}
