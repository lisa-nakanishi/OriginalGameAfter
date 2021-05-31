using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoUp : MonoBehaviour
{
    public GameObject photoExpansion;
    public GameObject openDoor;
    // Start is called before the first frame update
    private void OnMouseUp()
    {
        bool dooropen = (openDoor.activeSelf == true);
        //ゲームクリアになったとき、Door2は非アクティブからアクティブにする
        //Door2がアクティブになったときは表示されない
        if (dooropen)
        {
            //拡大下画像を非表示から表示
            photoExpansion.SetActive(false);
            Debug.Log("写真拡大非表示");
        }
        else if (!dooropen)
        {

            //拡大下画像を非表示から表示
            photoExpansion.SetActive(true);
            Debug.Log("写真拡大表示");
        }

       
       
    }
    

    
}
