using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllor : MonoBehaviour
{
    public GameObject target; 
    public float moveSpeed; 
    private Vector3 targetPosition; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target.gameObject != null)
        {
            targetPosition.Set(target.transform.position.x+7,target.transform.position.y+1, this.transform.position.z); //카메라를 타겟포지션으로 잡음
            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime); //카메라를 부드럽게 이동시킴
        }
    }
}
