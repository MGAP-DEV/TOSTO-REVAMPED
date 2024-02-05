using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_Storage : MonoBehaviour {
        public int primeInt = 1;
        public Text Char1name;
        public Text Char1speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtBG1;
        public GameObject Choicea;
        public Text ChoiceTxt1;
        public GameObject Choiceb;
        public Text ChoiceTxt2;
        public GameObject Choicec;
        public Text ChoiceTxt3;
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
        nextButton.SetActive(true);
        name = "Bob";
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
                        Char1name.text = "";
                        Char1speech.text = "Row one";
                        ChoiceTxt1.text = "The row with all the canned items";
                        ChoiceTxt2.text = "Row 800";
                        ChoiceTxt3.text = "Taste Test Station";
                        Choicea.SetActive(true);
                        Choiceb.SetActive(true);
                        Choicec.SetActive(true);
                break;

        }
}

public void Choice4aFunct(){
        switch (primeInt) {
                case 2:
                        break;
        }
}
public void Choice4bFunct(){
        switch (primeInt) {
                case 2:
                        break;
        }
}
public void Choice4cFunct(){
        switch (primeInt) {
                case 2:
                        break;
        }
}
}