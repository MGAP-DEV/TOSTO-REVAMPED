using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_Clothing : MonoBehaviour {
        public int primeInt = 1;
        public Text Char1name;
        public Text Char1speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choicea;
        public Text ChoiceTxt1;
        public GameObject Choiceb;
        public Text ChoiceTxt2;
        public GameObject Choicec;
        public Text ChoiceTxt3;
        public GameObject Choiced;
        public Text ChoiceTxt4;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtBG1.SetActive(true);
        Choicea.SetActive(false);
        Choiceb.SetActive(false);
        Choicec.SetActive(false);
        Choiced.SetActive(false);
        nextButton.SetActive(true);
        name = "";
}

void Update(){        
        if (allowSpace == true && Input.GetKeyDown("space")){
                Next();
        }
}

public void Next(){
        switch (primeInt) {
                case 1:
                        primeInt++;
                        Next();
                        break;
                case 2:
                        ArtChar1a.SetActive(true);
                        DialogueDisplay.SetActive(true);
                        Char1name.text = $"{name}";
                        Char1speech.text = "You enter the clothing room. Where do you want to explore?";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        ChoiceTxt1.text = "Unturned paper";
                        ChoiceTxt2.text = "Clothing piles";
                        ChoiceTxt3.text = "shoe boxes";
                        ChoiceTxt4.text = "clothing rack";
                        Choicea.SetActive(true);
                        Choiceb.SetActive(true);
                        Choicec.SetActive(true);
                        Choiced.SetActive(true);
                        break;
        }
}
public void Choicea2Funct(){
        switch (primeInt) {
                case 2:
                        break;
        }
}
public void Choiceb2Funct(){
        switch (primeInt) {
                case 2:
                        break;
        }
}
public void Choicec2Funct(){
        switch (primeInt) {
                case 2:
                        break;
        }
}

public void Choiced2Funct(){
        switch (primeInt) {
                case 2:
                        break;
        }
}
}