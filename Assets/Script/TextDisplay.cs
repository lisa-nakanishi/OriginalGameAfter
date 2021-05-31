using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public GameObject hidePanel;
    public GameObject inputField;
    public GameObject button;
    public GameObject photoExpansion;




    // クリックしたとき、テキスト入力画面とボタンが表示される
    void OnMouseUp()
    {
       
        hidePanel.SetActive(true);
        inputField.SetActive(true);
        button.SetActive(true);
        Debug.Log("Click");
    //Photo2がアクティブになったとき、ドアはクリック検知されない

       bool isdoor = (photoExpansion.activeSelf==true);
        if (isdoor)
        {
            hidePanel.SetActive(false);
            inputField.SetActive(false);
            button.SetActive(false);
            Debug.Log("クリック無効");
        }

    }
   


}
