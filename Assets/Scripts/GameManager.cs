using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour{


    public static GameManager Instance;

    [SerializeField]
    private Cena[] cenas;

    public GameObject anya;
    public GameObject BG;
    public TextMeshProUGUI text;


    private int scenePos = 0;


    void Awake() {
        DontDestroyOnLoad(gameObject);

        if(Instance == null) {
            Instance = this;
        } else {
            Destroy(gameObject);
        }

    }

    void Start() {
        nextScene(); 
       

    }

    public void nextScene() {
        try {

            Cena cena = cenas[scenePos];
            
            anya.SetActive(cena.anya);

            if(cena.anya) {
                anya.GetComponent<Image>().sprite = cena.anyaSprite;
            }

            if(cena.BGsprite != null) {
                BG.GetComponent<Image>().sprite = cena.BGsprite;
            }


            //text.GetComponent<TextMesh>().text = cena.texto;
            text.text = cena.texto;

            scenePos++;
        } catch {

        }


    }
}



[System.Serializable]
public class Cena{
    public bool anya;
    public Sprite anyaSprite;
    public string texto;
    public Sprite BGsprite = null;
}




