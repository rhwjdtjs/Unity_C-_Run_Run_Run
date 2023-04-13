using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float speed = 1.0f;
    public float startPosition;
    public float endPosition;

    void Update()
    {
        transform.Translate(-1 * speed * Time.deltaTime, 0, 0); //맵 스크롤 코드

        if (transform.position.x <= endPosition) //맵의 끝이라면
        {
            ScrollEnd(); 
        }
    }

    void ScrollEnd()
    {
        transform.Translate(-1 * (endPosition - startPosition), 0, 0);
    }

}
