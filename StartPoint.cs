using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartPoint : MonoBehaviour
{
    public string startpoint;
    private Player theplayer;
    [SerializeField]
    private Text deadcount;
    // Start is called before the first frame update
    void Start()
    {
        theplayer = FindObjectOfType<Player>();
        if (startpoint == theplayer.currentMapName)
        {
            theplayer.transform.position = this.transform.position;
        }
        deadcount.text = "STAGE1 Number of Failed: " + GameManager.DeadCount;
    }

    // Update is called once per frame
    void Update()
    {
        theplayer.isRun = false;
        theplayer.anim.SetBool("isrun", theplayer.isRun);
        theplayer.Speed = 0f;
        theplayer.GameEnd = true;
    }
}
