using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickUpObjectAnother : MonoBehaviour
{
    public GameObject Object;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseUp()
    {
        Object.SetActive(true);
        Debug.Log("表示");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
