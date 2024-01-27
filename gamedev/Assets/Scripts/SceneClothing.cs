using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_Clothing : MonoBehaviour {
        // These are the script variables.
        // For more character images or buttons, duplicate the ArtChar ones listed here and renumber.
        public int primeInt = 1;
        public Text Char1name;
        public Text Char1speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        //public GameObject ArtBG2;
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

// Initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtBG1.SetActive(true);
        //ArtBG2.SetActive(false);
        Choicea.SetActive(false);
        Choiceb.SetActive(false);
        Choicec.SetActive(false);
        Choiced.SetActive(false);
        nextButton.SetActive(true);
        name = "Bob";
   }

// Use the spacebar as a faster "Next" button:
void Update(){        
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       Next();
                }
        }
   }

//Story Units! The main story function. Players hit [NEXT] to progress to the next primeInt:
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
                        Char1speech.text = "";
                        break;
        }
}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
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