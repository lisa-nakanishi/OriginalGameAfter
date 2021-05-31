using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUpScript : MonoBehaviour
{
    //時間制限を設定
    public float timeValue = 180;
    public Text timeText;
    public GameObject gameOverText;
    public GameObject photo;
    public GameObject poster;
    public GameObject door;
    public GameObject flower;
    void Update()
    {
        //一秒ずつ減らす
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
            
        }

        else
        {
            timeValue = 0;
        }
        DisplayTime(timeValue);
        //カウントダウン０になったとき、"GameOver"と表示させる
        void DisplayTime(float timeToDisplay)
        {
            if (timeToDisplay < 0)
            {
                timeToDisplay = 0;
                this.gameOverText.GetComponent<Text>().text = "GameOver";
                Debug.Log("TimeUp");
                //コリダーを無効化
                poster.GetComponent<BoxCollider2D>().enabled = false;
                photo.GetComponent<BoxCollider2D>().enabled = false;
                door.GetComponent<BoxCollider2D>().enabled = false;
                flower.GetComponent<BoxCollider2D>().enabled = false;
            }

            //分と秒を計算
            float minutes = Mathf.FloorToInt(timeToDisplay / 60);
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);
            timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        }
       
    }
   

}
