using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMap : MonoBehaviour
{
    [SerializeField]
    private float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Speed * Time.deltaTime, 0, 0); //맵을 좌측으로 움직이게 하여 플레이어가 움직이는 것처럼 설정
    }
}
