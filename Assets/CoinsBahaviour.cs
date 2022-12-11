using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsBahaviour : MonoBehaviour
{
  public int value = 1;
	private GameObject UI;
	public Animator animator;
	// Use this for initialization
	void Start () {
		UI = GameObject.FindGameObjectWithTag("CoinAmount");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.CompareTag("Player")){
			int coinUI = int.Parse(UI.GetComponent<TextMeshProUGUI >().text) + value;
			UI.GetComponent<TextMeshProUGUI >().text = coinUI + "";
			animator.SetBool("IsCollect", true);
		
		}
	}
}
