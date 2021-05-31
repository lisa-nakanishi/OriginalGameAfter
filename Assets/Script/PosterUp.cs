using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosterUp : MonoBehaviour
{
    public GameObject posterExpasion;
    public GameObject openDoor;

     private void OnMouseUp()
    {
        
        bool dooropen = (openDoor.activeSelf == true);
        //ゲームクリアになったとき、Door2は非アクティブからアクティブにする
        //Door2がアクティブになったときは表示されない
        if (dooropen)
        {
            //拡大下画像を非表示から表示
            posterExpasion.SetActive(false);
            Debug.Log("ポスター拡大非表示");
        }
        else if (!dooropen)
        {

            //拡大下画像を非表示から表示
            posterExpasion.SetActive(true);
            Debug.Log("ポスター拡大表示");
        }
        
    }
}
