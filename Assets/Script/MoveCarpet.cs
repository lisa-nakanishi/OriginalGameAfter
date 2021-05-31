using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCarpet : MonoBehaviour
{
    public GameObject carpet;
    public GameObject openCarpet;
    public GameObject photo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //カーペットを押したとき、カーペットがめくれた画像に入れ替える
    private void OnMouseUp()
    {
        Debug.Log("CarpetClick");
        carpet.SetActive(false);
        openCarpet.SetActive(true);
        photo.SetActive(true);
        
    }
   
}
