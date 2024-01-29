using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Entrance : MonoBehaviour {
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
        public GameObject Choicea2;
        public Text ChoiceTxt01;
        public GameObject Choiceb2;
        public Text ChoiceTxt02;
        public GameObject Choicec2;
        public Text ChoiceTxt03;
        public GameObject Choiced2;
        public Text ChoiceTxt04;
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
        Choicea2.SetActive(false);
        Choiceb2.SetActive(false);
        Choicec2.SetActive(false);
        Choiced2.SetActive(false);
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
        switch (primeInt) {
                case 1:
                        // audioSource1.Play();
                        primeInt++;
                        Next();
                        break;
                case 2:
                        ArtChar1a.SetActive(true);
                        DialogueDisplay.SetActive(true);
                        Char1name.text = $"{name}";
                        Char1speech.text = "I've been around these parts for a long time, want me to show you the ropes?";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        ChoiceTxt1.text = "Yes, I have never been to such a place before";
                        ChoiceTxt2.text = "You think I need help (I do)";
                        ChoiceTxt3.text = "Got something else for me?";
                        Choicea1.SetActive(true);
                        Choiceb1.SetActive(true);
                        Choicec1.SetActive(true);
                        break;
                case 3:
                        Char1name.text = $"{name}";
                        Char1speech.text = "No can do, stock sold out";
                        primeInt = 5;
                        break;
                case 4:
                        Char1name.text = $"{name}";
                        Char1speech.text = "Laugh it up chuckles, I've got your back.";
                        primeInt = 5;
                        break;
                case 5:
                        //bbs
                        Char1name.text = $"{name}";
                        Char1speech.text = "Ask me anything, I'm very big brain, let me help you out...";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        ChoiceTxt1.text = "Point of the Game";
                        ChoiceTxt2.text = "How to move (aka how does the game work)";
                        ChoiceTxt3.text = "Other options";
                        Choicea1.SetActive(true);
                        Choiceb1.SetActive(true);
                        Choicec1.SetActive(true);
                        break;
                case 6:
                        Char1name.text = $"{name}";
                        Char1speech.text = "Ask me anything, I'm very big brain, let me help you out...";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        ChoiceTxt1.text = "Charming";
                        ChoiceTxt2.text = "Fighting";
                        ChoiceTxt3.text = "Even more Options";
                        Choicea1.SetActive(true);
                        Choiceb1.SetActive(true);
                        Choicec1.SetActive(true);
                        break;
                case 7:
                        Char1name.text = $"{name}";
                        Char1speech.text = "Ask me anything, I'm very big brain, let me help you out...";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        ChoiceTxt1.text = "I'm ready to get out of here";
                        ChoiceTxt3.text = "First options";
                        Choiceb1.SetActive(false);
                        break;
                case 8:
                        Char1name.text = $"{name}";
                        Char1speech.text = "Well I hope you're finally smart enough to fend for  yourself out there";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        ChoiceTxt1.text = "This place is pretty weird";
                        ChoiceTxt2.text = "WAIT WAIT WAIT, I want to ask more questions please, I didn't mean to leave so soon :(";
                        ChoiceTxt3.text = "Thanks for all the help, I will get all the groceries I came for";
                        Choicea1.SetActive(true);
                        Choiceb1.SetActive(true);
                        Choicec1.SetActive(true);
                        break;
                case 9:
                        Char1name.text = $"{name}";
                        Char1speech.text = "Good luck!";
                        primeInt++;
                        break;
                case 10:
                        Char1name.text = "";
                        Char1speech.text = "*He Disappears*";
                        primeInt++;
                        break;
                case 11:
                        Char1name.text = $"{name}";
                        Char1speech.text = "You are left with a choice as to where you want to go...";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        ChoiceTxt2.text = "Storage (North)";
                        Choiceb1.SetActive(true);
                        break;
                case 20:
                        //point of the game
                        Char1name.text = $"{name}";
                        Char1speech.text = "What a silly question! You're obviously here to buy groceries";
                        primeInt++;
                        break;
                case 21:
                        Char1name.text = $"{name}";
                        Char1speech.text = "Any better questions?";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        ChoiceTxt01.text = "How do I do that?";
                        ChoiceTxt02.text = "What kind of groceries do they have here?";
                        ChoiceTxt03.text = "Can I leave without any groceries?";
                        ChoiceTxt04.text = "What if I don't want groceries…";
                        Choicea2.SetActive(true);
                        Choiceb2.SetActive(true);
                        Choicec2.SetActive(true);
                        Choiced2.SetActive(true);
                        break;
                case 22:
                        Char1name.text = $"{name}";
                        Char1speech.text = "Well there are two simple ways to get your groceries, you can fight them, or charm them, ask me about it later.";
                        primeInt = 21;
                        break;
                case 23:
                        Char1name.text = $"{name}";
                        Char1speech.text = "So many that I can't name them all";
                        primeInt = 21;
                        break;
                case 24:
                        Char1name.text = $"{name}";
                        Char1speech.text = "Then you don't leave Tosto";
                        primeInt = 21;
                        break;
                case 25:
                        Char1name.text = $"{name}";
                        Char1speech.text = "No, you need groceries in order to leave. The more groceries you have from your list the better a chance you have to leave this forsaken place";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        ChoiceTxt2.text = "List? What list? What's on my list?";
                        Choiceb1.SetActive(true);
                        break;
                case 26:
                        Char1name.text = $"{name}";
                        Char1speech.text = "Boy I'm glad you asked. You have a total of 6 different items, but it's your list";
                        primeInt++;
                        break;
                case 27:
                        Char1name.text = $"{name}";
                        Char1speech.text = "I have no idea what those items were, I'm sure a walk through the store may help you find them. They’re hard to miss...";
                        primeInt = 5;
                        break;
                case 30:
                        //how the game works
                        Char1name.text = $"{name}";
                        Char1speech.text = "This game is a visual novel";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        ChoiceTxt1.text = "That's it?";
                        ChoiceTxt3.text = "What's a visual novel?";
                        Choiceb1.SetActive(false);
                        break;
                case 31:
                        Char1name.text = $"{name}";
                        Char1speech.text = "Well yeah, a visual novel has no wasd movement. What did you expect?";
                        primeInt = 33;
                        break;
                case 32:
                        Char1name.text = $"{name}";
                        Char1speech.text = "You don't know what a visual novel is? Are you actually stupid?";
                        primeInt = 33;
                        break;
                case 33:
                        Char1name.text = $"{name}";
                        Char1speech.text = "Anyways, click any of those options when they appear and you'll be fine.";
                        break;
        }
}

public void Choicea1Funct(){
        switch (primeInt) {
                case 2:
                        Char1name.text = "YOU";
                        Char1speech.text = "Yes, I have never been to such a place before";
                        primeInt = 4;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        break;
                case 5:
                        Char1name.text = "YOU";
                        Char1speech.text = "Why am I here?";
                        primeInt = 20;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        break;
                case 7:
                        Char1name.text = "YOU";
                        Char1speech.text = "I'm ready to get out of here";
                        primeInt = 8;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        break;
                case 8:
                        Char1name.text = "YOU";
                        Char1speech.text = "This place is pretty weird";
                        primeInt = 9;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        break;
                case 21:
                        Char1name.text = "YOU";
                        Char1speech.text = "How do I do that?";
                        primeInt = 22;
                        Choicea2.SetActive(false);
                        Choiceb2.SetActive(false);
                        Choicec2.SetActive(false);
                        Choiced2.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        break;
                case 30:
                        Char1name.text = "YOU";
                        Char1speech.text = "That's it?";
                        primeInt = 31;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        break;

        }
}
public void Choiceb1Funct(){
        switch (primeInt) {
                case 2:
                        Char1name.text = "YOU";
                        Char1speech.text = "You think I need help?";
                        primeInt = 4;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        break;
                case 5:
                        primeInt = 30;
                        Next();
                        break;
                case 8:
                        Char1name.text = "YOU";
                        Char1speech.text = "WAIT WAIT WAIT, I want to ask more questions please, I didn't mean to leave so soon :(";
                        primeInt = 5;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        break;
                case 11:
                        SceneManager.LoadScene("SceneStorage");
                        break;
                case 21:
                        Char1name.text = "YOU";
                        Char1speech.text = "What kind of groceries do they have here?";
                        primeInt = 23;
                        Choicea2.SetActive(false);
                        Choiceb2.SetActive(false);
                        Choicec2.SetActive(false);
                        Choiced2.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        break;
                case 25:
                        Char1name.text = "YOU";
                        Char1speech.text = "List? What list? What's on my list?";
                        primeInt++;
                        Choiceb1.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        break;
        }
}
public void Choicec1Funct(){
        switch (primeInt) {
                case 2:
                        Char1name.text = "YOU";
                        Char1speech.text = "Got something else for me?";
                        primeInt = 3;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        break;
                case 5:
                        primeInt = 6;
                        Next();
                        break;
                case 6:
                        primeInt = 7;
                        Next();
                        break;
                case 7:
                        primeInt = 5;
                        Next();
                        break;
                case 8:
                        Char1name.text = "YOU";
                        Char1speech.text = "Thanks for all the help, I will get all the groceries I came for";
                        primeInt = 9;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        break;
                case 21:
                        Char1name.text = "YOU";
                        Char1speech.text = "Can I leave without any groceries?";
                        primeInt = 25;
                        Choicea2.SetActive(false);
                        Choiceb2.SetActive(false);
                        Choicec2.SetActive(false);
                        Choiced2.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        break;
                case 30:
                        Char1name.text = "YOU";
                        Char1speech.text = "What's a visual novel?";
                        primeInt = 32;
                        Choicea1.SetActive(false);
                        Choiceb1.SetActive(false);
                        Choicec1.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        break;
        }
}
public void Choiced1Funct(){
        switch (primeInt) {
                case 21:
                        Char1name.text = "YOU";
                        Char1speech.text = "What if I don't want groceries…";
                        primeInt = 24;
                        Choicea2.SetActive(false);
                        Choiceb2.SetActive(false);
                        Choicec2.SetActive(false);
                        Choiced2.SetActive(false);
                        nextButton.SetActive(true);
                        allowSpace = true;
                        break;
        }
}
}