using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObject : ClickUpObjectAnother
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseUp()
    {


        foreach (GameObject Object in Objects)
        {
            Object.SetActive(false);
        }

        for (int i = 0; i < Objects.Count; i++)
        {

        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
