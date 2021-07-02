using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCheckPass : MonoBehaviour
{
    public InputField inputField;
    private GameObject gameClearText;
    public GameObject closeDoor;
    public GameObject hidePanel;
    public GameObject button;
    public GameObject timeText;
    public GameObject openDoor;
    [SerializeField] ParticleSystem particle;

    //ゲームクリアしたとき、テキストを呼び出す
    void Start()
    {
        this.gameClearText = GameObject.Find("GameClearText");
    }

    // ボタンでの確認
    public void CheckButton() 
    {
        //仮のパスワードを入力して一致していた場合
        if (inputField.text == "freedom"||inputField.text=="Freedom"||inputField.text=="フリーダム")
        {
    
            //ゲームクリアのテキストを表示する
            this.gameClearText.GetComponent<Text>().text = "Clear!";

          
            //パーティクルを実行
            particle.Play();
           
            //ドアや、入力画面等の削除,扉が開いた画像表示
            openDoor.SetActive(true);
            Destroy(closeDoor);
            Destroy(hidePanel);
            Destroy(button);
            Destroy(inputField);
            Destroy(timeText);

            
            
        }
        else
        {
            // 空欄にしてもう一度入力
            this.inputField.text = "";
           
        }
        Debug.Log("ボタンが押された");
    } 

}
