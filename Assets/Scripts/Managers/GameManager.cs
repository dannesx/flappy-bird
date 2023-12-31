using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreTxt;
    public GameObject resetScr;
    AudioManager Audio;
    int score = 0;

    void Start(){
        Audio = GetComponent<AudioManager>();
    }

    public void AddScore(){
        score++;
        scoreTxt.text = score.ToString();
        Audio.PointSFX();
    }

    public void GameOver(){
        Audio.HitSFX();
        Invoke("ResetScreen", 0.5f);
    }

    public void ResetScreen(){
        Time.timeScale = 0f;
        resetScr.SetActive(true);
    }

    public void ResetGame(){
        resetScr.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}