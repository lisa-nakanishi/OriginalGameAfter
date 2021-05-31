using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickUpObjects : MonoBehaviour
{
    public GameObject poster;
    public GameObject photo;
    public GameObject flower;


    public GameObject PosterExpansion;
    public GameObject FlowerTextPanel;
    public GameObject photoExpansion;
    public GameObject openDoor;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseUp()
    {   //ポスターをクリックしたとき表示
        if (poster)
        {
            PosterExpansion.SetActive(true);
        }
        else
        {
            PosterExpansion.SetActive(false);
        }
        //写真をクリックしたとき表示
        if (photo)
        {
            photoExpansion.SetActive(true);
        }
        else
        {
            photoExpansion.SetActive(false);
        }

        if (poster)
        {
            PosterExpansion.SetActive(true);
        }
        else
        {
            PosterExpansion.SetActive(false);
        }



    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
