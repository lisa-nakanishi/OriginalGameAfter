using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickUpObjects : MonoBehaviour
{
    public GameObject poster;
    public GameObject photo;

    public GameObject photoExpansion;
    public GameObject PosterExpansion;
    public GameObject FlowerTextPanel;
    public GameObject openDoor;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseUp()
    {
        if (poster.GetComponent<BoxCollider2D>())
        {
            PosterExpansion.SetActive(true);
        }
        if (photo.GetComponent<BoxCollider2D>())
        {
            photoExpansion.SetActive(true);
        }


        bool dooropen = (openDoor.activeSelf == true);
        //ゲームクリアになったとき、Door2は非アクティブからアクティブにする
        //Door2がアクティブになったときは表示されない
        if (dooropen)
        {
            //拡大下画像を非表示から表示
            photoExpansion.SetActive(false);
            PosterExpansion.SetActive(false);
            Debug.Log("写真拡大非表示");
        }
        else if (!dooropen)
        {

            //拡大下画像を非表示から表示
            photoExpansion.SetActive(true);
            PosterExpansion.SetActive(true);
            Debug.Log("写真拡大表示");
        }



    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
