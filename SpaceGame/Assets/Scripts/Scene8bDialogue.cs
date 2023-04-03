using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene8bDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		public Text Char3name;
		public Text Char3speech;
        public GameObject DialogueDisplay;
		public GameObject ToolboxArt;
        public GameObject ArtBG1;
        public GameObject Choice1a;                                 // search foot locker
        public GameObject Choice1b;                                 // search hanging uniforms)
        public GameObject NextScene1Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ToolboxArt.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        nextButton.SetActive(true);

     // Find the gameHandler:
     // gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       next();
                }
        }
   }

//Story Units! This is the main story function. Players hit [NEXT] to progress to the next primeInt:
public void next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
            //    ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "This room is in rough shape.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "It appears that crew members left quickly.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Assessment: Remnants of emergency evacuation.";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "What can we find here?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
               Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Assessing... \n There is a foot locker you may be able to open.";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "There is a rack of hanging uniforms that you can search. It is possible that you may find useful items or supplies.";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

																				//ENCOUNTER AFTER CHOICE 1a: foot locker
       else if (primeInt == 31){
                Char1name.text = "YOU";
                Char1speech.text = "Let's see what we've got...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 32){
                Char1name.text = "YOU";
                Char1speech.text = "Some playing cards, a few magazines, some basic toiletries...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 33){
                ToolboxArt.SetActive(true);
				Char1name.text = "YOU";
                Char1speech.text = "... and a small box.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 34){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Directive: Search box.";
        }
		else if (primeInt == 35){
                Char1name.text = "YOU";
                Char1speech.text = "Thanks for the tip...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 36){
                Char1name.text = "YOU";
                Char1speech.text = "Looks like a toolbox. Poorly maintained.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 37){
                Char1name.text = "YOU";
                Char1speech.text = "All that's left is this screw driver. Might come in handy though.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 38){
                ToolboxArt.SetActive(false);
				Char1name.text = "YOU";
                Char1speech.text = "Doesn't seem like there's much else in here. Time to move on.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);             // Back to Hallway
        }
																	// After choice 1b: search uniforms
		else if (primeInt == 71){
                Char1name.text = "YOU";
                Char1speech.text = "Nothing in the pockets. Just a bunch of uniforms";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 72){
                Char1name.text = "YOU";
                Char1speech.text = "I guess I'll see what's in the box.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 73){
				ToolboxArt.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Looks like a toolbox. Poorly maintained.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 74){
                Char1name.text = "YOU";
                Char1speech.text = "All that's left is this screw driver. Might come in handy though.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 75){
                ToolboxArt.SetActive(false);
				Char1name.text = "YOU";
                Char1speech.text = "Doesn't seem like there's much else in here. Time to move on.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);     // back to hallway
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){                                                  //search foot locker
                Char1name.text = "YOU";
                Char1speech.text = "I'll check the locker first.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 30;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){                                             // search uniforms
                Char1name.text = "YOU";
                Char1speech.text = "I'll check the clothes first.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 70;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
				 GameHandler.hasScrewdriver = true;
                 SceneManager.LoadScene("Scene7");
        }
}