using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Entrance : MonoBehaviour {
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
        public GameObject Choicea1;
        public Text ChoiceTxt1;
        public GameObject Choiceb1;
        public Text ChoiceTxt2;
        public GameObject Choicec1;
        public Text ChoiceTxt3;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

// Initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtBG1.SetActive(true);
        Choicea1.SetActive(false);
        Choiceb1.SetActive(false);
        Choicec1.SetActive(false);
        nextButton.SetActive(true);
        name = "Ach Triple D";
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
        if (primeInt == 1){
                // audioSource1.Play();
                primeInt++;
        }
        else if (primeInt == 2){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = $"{name}";
                Char1speech.text = "I’ve been around these parts for a long time, want me to show you the ropes?";
                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                ChoiceTxt1.text = "Yes, I have never been to such a place before";
                ChoiceTxt2.text = "You think I need help (I do)";
                ChoiceTxt3.text = "Got something else for me?";
                Choicea1.SetActive(true); // function Choicea1Funct()
                Choiceb1.SetActive(true); // function Choiceb1Funct()
                Choicec1.SetActive(true);
        }

        else if (primeInt == 3){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = $"{name}";
                Char1speech.text = "No can do, stock sold out";
                primeInt = 5;
        }

        else if (primeInt == 4){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = $"{name}";
                Char1speech.text = "Laugh it up chuckles, I've got your back.";
                primeInt = 5;
        }
        else if (primeInt == 5){
                Char1name.text = $"{name}";
                Char1speech.text = "Ask me anything, I’m very big brain, let me help you out...";
                nextButton.SetActive(false);
                allowSpace = false;
                ChoiceTxt1.text = "Charming";
                ChoiceTxt2.text = "Fighting";
                ChoiceTxt3.text = "Other Options";
                Choicea1.SetActive(true);
                Choiceb1.SetActive(true);
                Choicec1.SetActive(true);
        }
        else if (primeInt == 6){
                Char1name.text = $"{name}";
                Char1speech.text = "Ask me anything, I’m very big brain, let me help you out...";
                nextButton.SetActive(false);
                allowSpace = false;
                ChoiceTxt1.text = "Point of the Game";
                ChoiceTxt2.text = "How to move (aka how does the game work)";
                ChoiceTxt3.text = "Even more options";
                Choicea1.SetActive(true);
                Choiceb1.SetActive(true);
                Choicec1.SetActive(true);
        }
        else if (primeInt == 7){
                Char1name.text = $"{name}";
                Char1speech.text = "Ask me anything, I’m very big brain, let me help you out...";
                nextButton.SetActive(false);
                allowSpace = false;
                ChoiceTxt1.text = "I'm ready to get out of here";
                ChoiceTxt3.text = "First options";
                Choicea1.SetActive(true);
                Choiceb1.SetActive(false);
                Choicec1.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choicea1Funct(){
                if (primeInt == 2) {
                        Char1name.text = "YOU";
                        Char1speech.text = "Yes, I have never been to such a place before";
                        primeInt = 4;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                }
                else if (primeInt == 7) {
                        Char1name.text = "YOU";
                        Char1speech.text = "Yes";
                        primeInt = 8;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                }
        }
        public void Choiceb1Funct(){
                if (primeInt == 2) {
                        Char1name.text = "YOU";
                        Char1speech.text = "You think I need help?";
                        primeInt = 4;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;    
                }
                
        }
        public void Choicec1Funct(){
                if (primeInt == 2) {
                        Char1name.text = "YOU";
                        Char1speech.text = "Got something else for me?";
                        primeInt = 3;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                }
                else if (primeInt == 5) {
                        primeInt = 6;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        Next();
                }
                else if (primeInt == 6) {
                        primeInt = 7;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        Next();
                }
                else if (primeInt == 7) {
                        primeInt = 5;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        Next();
                }
        }
}