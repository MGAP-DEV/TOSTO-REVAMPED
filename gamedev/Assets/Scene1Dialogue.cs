using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_1_Dialogue : MonoBehaviour {
        // These are the script variables.
        // For more character images or buttons, duplicate the ArtChar ones listed here and renumber.
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice1c;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

// Initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
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
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // audioSource1.Play();
        }
        else if (primeInt == 2){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "HDDD";
                Char1speech.text = "I have been around these parts for a long time, want me to show you the ropes?";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
                Choice1c.SetActive(true);
        }

       // after choice 1a
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "HDDD";
                Char2speech.text = "Laugh it up chuckles, there are a lot worse out there.";
                nextButton.SetActive(false);
                allowSpace = false;
        }

       // after choice 1b
       else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "HDDD";
                Char2speech.text = "No can do, stock sold out";
        }

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                if (primeInt == 2) {
                        Char1name.text = "YOU";
                        Char1speech.text = "Yes, my grubby legs can’t stand wandering around";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Choice1a.SetActive(false);
                        Choice1b.SetActive(false);
                        Choice1c.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                }
        }
        public void Choice1bFunct(){
                if (primeInt == 2) {
                        Char1name.text = "YOU";
                        Char1speech.text = "Why? Are there more creepy guys like you?";
                        Char2name.text = "";
                        Char2speech.text = "";
                        primeInt = 19;
                        Choice1a.SetActive(false);
                        Choice1b.SetActive(false);
                        Choice1c.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;    
                }
                
        }
        public void Choice1cFunct(){
                if (primeInt == 2) {
                        Char1name.text = "YOU";
                        Char1speech.text = "Got something else for me?";
                        Char2name.text = "";
                        Char2speech.text = "";
                        primeInt = 29;
                        Choice1a.SetActive(false);
                        Choice1b.SetActive(false);
                        Choice1c.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                }
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}