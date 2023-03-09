using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4aDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		public Text Char3name;
		public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;  // search desk choice
        public GameObject Choice1b; // move on to kitchen choice
		public GameObject Choice1c; // search drawer choice
        public GameObject NextScene1Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;
		public bool foundManual = false;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
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
               ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The room is even darker than the those you just left, thanks to the maze of boxes and crates obscuring many of the emergency lights.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "You";
                Char1speech.text = "Wow. There’s practically enough stuff in here to build a whole second second ship! I wonder how it all stays organized?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Analyzing… \n No digestible organization scheme detected.";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Internal records indicate lack of standardized system as a significant source of disagreement between Primary Intelligence and Chief Engineer.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
               Char1name.text = "You";
                Char1speech.text = "So the ship’s inventory wasn’t important enough to store in your internal database, but the fact that the ship’s AI hates the engineers’ mess was?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "You";
                Char1speech.text = "Interesting set of priorities.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "This unit’s programming was designated by the ship’s Primary Intelligence.";
        }
		else if (primeInt ==9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "For queries or suggestions regarding sub-unit programming, please re-activate the Primary Intelligence.";
        }
		else if (primeInt ==10){
                Char1name.text = "You";
                Char1speech.text = "I’m working on it. Unfortunately, none of these crates look like the kind you’d store a power cell in.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==11){
                Char1name.text = "You";
                Char1speech.text = "Hmm... \n Oh look, behind this shelf here. I wonder if this desk belonged to the chief engineer? A lot of papers around.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "No power source detected. \n Directive: Continue search elsewhere.";
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct() - search desk
                Choice1b.SetActive(true); // function Choice1bFunct() - move on to kitchen
        }

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 51){
				if (foundManual == true){
                Char1name.text = "You";
                Char1speech.text = "Let's go get that power cell.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
										}
				else {
                Char1name.text = "You";
                Char1speech.text = "Hopefully we can find a power cell elsewhere.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				}
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
        }

       else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You take a moment to shift around the papers on the desk, a few sheets slipping off and onto the floor.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "They’re mostly schematics or parts lists, many bearing scribbled notes in the margins.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 16){
                Char1name.text = "You";
                Char1speech.text = "Hmm, not much of this is immediately useful.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "WARNING: power reserves critically low. \n Directive: Continue search.";
				nextButton.SetActive(false);
				allowSpace = false;
                Choice1c.SetActive(true); // function Choice1cFunct() - search drawer
                Choice1b.SetActive(true); // function Choice1bFunct() - move on to kitchen
        }
		else if (primeInt == 19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You pull open the drawers to reveal more papers, mixed in with various nuts, bolts, and other spare mechanical parts.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 20){
                Char1name.text = "You";
                Char1speech.text = "I think I’m beginning to see where the Prime Intelligence’s dissatisfaction was coming from. Wait, what’s this?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 21){
                Char1name.text = "You";
                Char1speech.text = "Wow, that’s a thick manual. And what does this sticky note on it say? The handwriting is awful. Hmm…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 22){
                Char1name.text = "You";
                Char1speech.text = "“Just swapped the hydrator’s power cell, should be good for a while more. Take care of it yourself next time. Disconnection protocol is on p.480.”";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 23){
                Char1name.text = "You";
                Char1speech.text = "Sounds like this is about the kitchen’s hydrator. I’d better take this and see if the cell it mentions is still there.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				foundManual = true;
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1b.SetActive(true); // function Choice1bFunct() - move on to kitchen
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "You";
                Char1speech.text = "Now hold on a moment, there might be something useful here.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 13;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "You";
                Char1speech.text = "Ok, time to keep moving.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 50;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1cFunct(){
                Char1name.text = "You";
                Char1speech.text = "I know, just a moment longer. I haven’t looked in here yet.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 18;
                Choice1c.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene4b");
        }
}