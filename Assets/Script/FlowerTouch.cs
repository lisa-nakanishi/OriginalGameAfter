using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FlowerTouch : MonoBehaviour
{
    public GameObject FlowerTextPanel;
    public GameObject openDoor;
    private void OnMouseUp()
    {

        bool dooropen = (openDoor.activeSelf == true);
        //ゲームクリアになったとき、Door2は非アクティブからアクティブにする
        //Door2がアクティブになったときは表示されない
        if (dooropen)
        {
            //テキストを非表示から表示
            FlowerTextPanel.SetActive(false);
            Debug.Log("テキスト非表示");
        }
        else if (!dooropen)
        {

            //テキストを非表示から表示
            FlowerTextPanel.SetActive(true);
            Debug.Log("テキスト表示");
        }
        

    }
}
