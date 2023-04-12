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
        SceneManager.LoadScene(Scenename); //��ư Ŭ���� ���� �ҷ��´�. 
    }

    public void ClickExit()
    {
        Application.Quit();
    }
}
