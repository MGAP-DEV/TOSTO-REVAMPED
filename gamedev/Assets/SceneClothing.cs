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
        if (primeInt == 1){
                // audioSource1.Play();
                primeInt++;
        }
        else if (primeInt == 2){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = $"{name}";
                Char1speech.text = $"Hi, welcome to Tosto, I'm {name}";
                nextButton.SetActive(false);
                allowSpace = false;
                ChoiceTxt1.text = "Hi!";
                ChoiceTxt2.text = "Skip (Must beat game first or pay ₫360000)";
                ChoiceTxt3.text = "Screw you";
                ChoiceTxt4.text = "Screw you";
                Choicea.SetActive(true); // function ChoiceaFunct()
                Choiceb.SetActive(true); // function ChoicebFunct()
                Choicec.SetActive(true);
                Choiced.SetActive(true);
        }

        else if (primeInt == 3){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = $"{name}";
                Char1speech.text = "You aren't bourgeoisie enough for that yet";
                primeInt++;
        }

        else if (primeInt == 4){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = $"{name}";
                Char1speech.text = "You get an introduction anyways";
                primeInt = 5;
        }

       // after choice 1a
       else if (primeInt == 5){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "(Name)";
                Char1speech.text = "This is the magical land of Tosto where you can find any type of groceries you need.";
                nextButton.SetActive(false);
                allowSpace = false;
                ChoiceTxt1.text = "Shut the hell up";
                ChoiceTxt2.text = "Please leave me alone";
                ChoiceTxt3.text = "Wow";
                Choicea.SetActive(true); // function ChoiceaFunct()
                Choiceb.SetActive(true); // function ChoicebFunct()
                Choicec.SetActive(true);
        }

        else if (primeInt == 6){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "(Name)";
                Char1speech.text = "You will encounter many magical creatures and humans in each section and even find secrets. Get ready for the time of your life.";
                nextButton.SetActive(false);
                allowSpace = false;
                ChoiceTxt1.text = "Interesting";
                ChoiceTxt2.text = "I'm leaving";
                ChoiceTxt3.text = "Here we go";
                Choicea.SetActive(true); // function ChoiceaFunct()
                Choiceb.SetActive(true); // function ChoicebFunct()
                Choicec.SetActive(true);
        }
      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choicea2Funct(){
                if (primeInt == 2) {
                        Char1name.text = "YOU";
                        Char1speech.text = "Hi!";
                        primeInt = 5;
                        Choicea.SetActive(false);
                        Choiceb.SetActive(false);
                        Choicec.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                }
                else if (primeInt == 5) {
                        Char1name.text = "YOU";
                        Char1speech.text = "Shut the hell up";
                        primeInt = 6;
                        Choicea.SetActive(false);
                        Choiceb.SetActive(false);
                        Choicec.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                }
                else if (primeInt == 6) {
                        Char1name.text = "YOU";
                        Char1speech.text = "Interesting";
                        Choicea.SetActive(false);
                        Choiceb.SetActive(false);
                        Choicec.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        SceneManager.LoadScene("SceneEntrance");
                }
        }
        public void Choiceb2Funct(){
                if (primeInt == 2) {
                        Char1name.text = "YOU";
                        Char1speech.text = "Skip";
                        primeInt = 3;
                        Choicea.SetActive(false);
                        Choiceb.SetActive(false);
                        Choicec.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;    
                }
                else if (primeInt == 5) {
                        Char1name.text = "YOU";
                        Char1speech.text = "Please leave me alone";
                        primeInt = 6;
                        Choicea.SetActive(false);
                        Choiceb.SetActive(false);
                        Choicec.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                }
                else if (primeInt == 5) {
                        Char1name.text = "YOU";
                        Char1speech.text = "I'm leaving";
                        primeInt = 6;
                        Choicea.SetActive(false);
                        Choiceb.SetActive(false);
                        Choicec.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                }
                
        }
        public void Choicec2Funct(){
                if (primeInt == 2) {
                        Char1name.text = "YOU";
                        Char1speech.text = "Screw You";
                        primeInt = 3;
                        Choicea.SetActive(false);
                        Choiceb.SetActive(false);
                        Choicec.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                }
                else if (primeInt == 5) {
                        Char1name.text = "YOU";
                        Char1speech.text = "Wow";
                        primeInt = 6;
                        Choicea.SetActive(false);
                        Choiceb.SetActive(false);
                        Choicec.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                }
                else if (primeInt == 6) {
                        Char1name.text = "YOU";
                        Char1speech.text = "Here we go";
                        Choicea.SetActive(false);
                        Choiceb.SetActive(false);
                        Choicec.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        SceneManager.LoadScene("SceneEntrance");
                }
        }

        public void Choiced2Funct(){
                if (primeInt == 2) {
                        Char1name.text = "rahhh";
                        Char1speech.text = "uahguhguhaghauhga!";
                        primeInt = 5;
                        Choicea.SetActive(false);
                        Choiceb.SetActive(false);
                        Choicec.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                }
                else if (primeInt == 5) {
                        Char1name.text = "YOU";
                        Char1speech.text = "Shut the hell up";
                        primeInt = 6;
                        Choicea.SetActive(false);
                        Choiceb.SetActive(false);
                        Choicec.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                }
                else if (primeInt == 6) {
                        Char1name.text = "YOU";
                        Char1speech.text = "Interesting";
                        Choicea.SetActive(false);
                        Choiceb.SetActive(false);
                        Choicec.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        SceneManager.LoadScene("SceneEntrance");
                }
        }
}