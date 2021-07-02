using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryButtonUp : MonoBehaviour
{
    [SerializeField] GameObject retryButton;

    // Start is called before the first frame update
    void Start()
    {
        //3分3秒たったら実行
        Invoke("RetryUp",181f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RetryUp()
    {
        retryButton.SetActive(true);
    }

}
