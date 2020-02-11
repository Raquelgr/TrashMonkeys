using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Buttons : MonoBehaviour {

	public Button playGame; 
	public Button settings;
	public Button credits;
	public Button quit;

	void Start () {
		Button btn = playGame.GetComponent<Button>();
		btn.onClick.AddListener(ChamaJogo);	

		Button btn1 = settings.GetComponent<Button>();
		btn1.onClick.AddListener(ChamaConf);	

		Button btn2 = credits.GetComponent<Button>();
		btn2.onClick.AddListener(ChamaCred);	

		Button btn3 = quit.GetComponent<Button>();
		btn3.onClick.AddListener(ChamaSair);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ChamaJogo(){
		SceneManager.LoadScene(1);
	}

	void ChamaConf(){
		SceneManager.LoadScene(3);
	}
	
	void ChamaCred(){
		SceneManager.LoadScene(4);
	}

	void ChamaSair(){
		Application.Quit();
	}
}
