using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnaMenu : MonoBehaviour {


    public Text puanText;
    public Text puan;
	
	void Start ()
    {
        int enYuksekPuan = PlayerPrefs.GetInt("enYuksekPuanKayit");
        int puanGelen = PlayerPrefs.GetInt("puanKayit");

        puanText.text = "Highest Score = " +enYuksekPuan;
        puan.text = "Puan = " + puanGelen;
	}
	
	
	void Update ()
    {
		
	}
    public void OyunaGiris()
    {
        SceneManager.LoadScene("first");
    }
    public void Cikis()
    {
        Application.Quit();
    }
}
