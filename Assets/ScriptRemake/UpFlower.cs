using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpFlower :  ClickUpObjectAnother
{

    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseUp()
    {

      

        foreach (GameObject Object in Objects)
        {
            Object.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
