using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickUpObjects : MonoBehaviour
{
    public GameObject poster;
    public GameObject photo;
    public GameObject flower;


    public GameObject PosterExpansion;
    public GameObject flowerTextPanel;
    public GameObject photoExpansion;
    public GameObject openDoor;

    //ポスターのクリック判定追加
    private bool isClickPoster = true;

    // Start is called before the first frame update
    void Start()
    {
      
    }
    private void OnMouseUp()
    {  
        
        //ポスターをクリックしたとき表示
        if (poster.GetComponent<BoxCollider2D>()==isClickPoster)//これだとコリダーがアクティブな時に表示されてしまう。
        {
            PosterExpansion.SetActive(true);
        }
        else if(poster.GetComponent<BoxCollider2D>() == !isClickPoster)
        {
            PosterExpansion.SetActive(false);
        }
        //写真をクリックしたとき表示
        if (photo.GetComponent<BoxCollider2D>())
        {
            photoExpansion.SetActive(true);
        }
        else
        {
            photoExpansion.SetActive(false);
        }
        //
        if (flower.GetComponent<BoxCollider2D>())
        {
            flowerTextPanel.SetActive(true);
        }
        else
        {
            flowerTextPanel.SetActive(false);
        }



    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
