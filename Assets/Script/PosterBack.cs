using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosterBack: MonoBehaviour
{

   
    private void OnMouseUp()
    {
        
          
           //画像クリックすると戻る
           this.gameObject.SetActive(false);
           Debug.Log("ポスター戻る");
        
        
       
    }
}
