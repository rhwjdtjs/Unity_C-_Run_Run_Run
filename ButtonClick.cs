using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonClick : MonoBehaviour
{
    [SerializeField]
    private string Scenename;

    public void ClickStart()
    {
        SceneManager.LoadScene(Scenename); //버튼 클릭시 씬을 불러온다. 
    }

    public void ClickExit()
    {
        Application.Quit();
    }
}
