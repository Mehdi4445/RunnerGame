using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CanvasManager : MonoBehaviour
{
    public GameObject pauseBtn;
	public GameObject pausePanel;
	public GameObject gameOverPanel;
	public GameObject coinPanelTxt;
	public GameObject gameOverCoinTxt;
	private bool isPause = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void GameOver(){
		gameOverPanel.SetActive(true);
		pauseBtn.SetActive(false);
		Time.timeScale = 0;
		coinPanelTxt.GetComponent<CoinAmount>().SaveCoins();
		gameOverCoinTxt.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt("CoinsAmount") + "";
	}

    public void PausePlay(){
		if(isPause){
			isPause = false;
			Time.timeScale = 1;
			pauseBtn.SetActive(true);
			pausePanel.SetActive(false);
		}
		else{
			isPause = true;
			Time.timeScale = 0;
			pauseBtn.SetActive(false);
			pausePanel.SetActive(true);
		}
	}

	public void Restart(){
		Time.timeScale = 1;
		SceneManager.LoadScene("level1");
	}
}
