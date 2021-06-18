using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    //変数を宣言
    float posiY;
    float y;
    public GameObject boxMwssage;
    // Start is called before the first frame update
    void Start()
    {

       

    }

    // Update is called once per frame
    void Update()
    {
        
        y = Input.mousePosition.y;
        
    }

    public void OnMouseDrag()
    {   
        
        boxMwssage.SetActive(true);
        //マウスの入力座標をオブジエクトの位置に変換したもの
        float targetY = Camera.main.ScreenToWorldPoint(new Vector3(0, y, 1.0f)).y;
       
        //設定したい座標を制限
        posiY = Mathf.Clamp(targetY, -3.63f, -1.44f);

        //実際のオブジエクトの位置に設定
        transform.position = (new Vector3(-5.36f, posiY));

    }
}

