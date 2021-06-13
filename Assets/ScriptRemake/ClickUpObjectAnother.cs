using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickUpObjectAnother : MonoBehaviour
{
  
    public List<GameObject> Objects;
    

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

        for (int i = 0; i < Objects.Count; i++)
        {

        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
