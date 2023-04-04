using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4aDialogue : MonoBehaviour {
		public GameHandler gameHandler;
		public int primeInt = 1;         // This integer drives game progress!
        public Text PlayerYouName;
        public Text PlayerYouSpeech;
        public Text NarratorName;
        public Text NarratorSpeech;
		public Text HorizonName;
		public Text HorizonSpeech;
        public GameObject DialogueDisplay;
        public GameObject DeskArt_1;
		public GameObject DeskArt_2;
		public GameObject DeskArt_3;
		public GameObject DeskArt_4;
		public GameObject BookArt;
        public GameObject ArtBG1;
        public GameObject Choice1a;  // search desk choice
        public GameObject Choice1b; // move on to kitchen choice
		public GameObject Choice1c; // search drawer choice
        public GameObject NextScene1Button;
        public GameObject nextButton;
        public AudioSource audioSource;
        private bool allowSpace = true;
		//public bool engiSetup = false;
		
// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        DeskArt_1.SetActive(false);
		DeskArt_2.SetActive(false);
		DeskArt_3.SetActive(false);
		DeskArt_4.SetActive(false);
		BookArt.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        NextScene1Button.SetActive(false);
        nextButton.SetActive(true);
        //audioSource = GetComponent<AudioSource>();
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
	if(GameHandler.engiAlready == false) {
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "...";
                NarratorSpeech.text = "The room is even darker than those you just left, occupied by a dense maze of boxes and crates.";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
       else if (primeInt ==3){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "Wow. There’s practically enough stuff in here to build a whole second ship! I wonder how it all stays organized?";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "H.O.R.I.Z.O.N.";
                HorizonSpeech.text = "Analyzing... \n No digestible organization scheme detected.";
        }
       else if (primeInt == 5){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "H.O.R.I.Z.O.N.";
                HorizonSpeech.text = "Internal records indicate lack of standardized system as a significant source of disagreement between Primary Intelligence and Chief Engineer.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "So the ship’s inventory wasn’t important enough to store in your internal database, but the fact that the ship’s AI hates the engineers’ mess was?";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
       else if (primeInt ==7){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "Interesting set of priorities.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt ==8){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "H.O.R.I.Z.O.N.";
                HorizonSpeech.text = "This unit’s programming was designated by the ship’s Primary Intelligence.";
        }
		else if (primeInt ==9){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "H.O.R.I.Z.O.N.";
                HorizonSpeech.text = "For queries or suggestions regarding sub-unit programming, please re-activate the Primary Intelligence.";
        }
		else if (primeInt ==10){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "I’m working on it. Unfortunately, none of these crates look like the kind you’d store a power cell in.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt ==11){
				PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "Hmm... \n Oh look, behind this shelf here. I wonder if this desk belonged to the chief engineer? A lot of papers on it.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";	
        }
		else if (primeInt ==12){
				DeskArt_1.SetActive(true);
				PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "H.O.R.I.Z.O.N.";
                HorizonSpeech.text = "No power source detected. \n Directive: Continue search elsewhere.";	
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct() - search desk
                Choice1b.SetActive(true); // function Choice1bFunct() - move on to kitchen
        }

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 51){
				if (GameHandler.foundManual == true){
				DeskArt_1.SetActive(false);
				DeskArt_3.SetActive(false);
				DeskArt_4.SetActive(false);
				BookArt.SetActive(false);
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "Let's go get that power cell.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
										}
				else {
				DeskArt_1.SetActive(false);
				DeskArt_3.SetActive(false);
				DeskArt_4.SetActive(false);
				BookArt.SetActive(false);
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "Hopefully my luck improves.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
				}
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
        }

       else if (primeInt == 14){
				DeskArt_1.SetActive(false);
				DeskArt_2.SetActive(true);
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "...";
                NarratorSpeech.text = "You take a moment to shift around the papers on the desk, a few sheets slipping off and onto the floor.";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt == 15){
				DeskArt_2.SetActive(false);
				DeskArt_3.SetActive(true);
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "...";
                NarratorSpeech.text = "They’re mostly schematics or parts lists, many bearing scribbled notes in the margins.";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt == 16){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "Hmm, not much of this is immediately useful.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt == 17){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "H.O.R.I.Z.O.N.";
                HorizonSpeech.text = "WARNING: power reserves critically low. \n Directive: Continue search.";
				nextButton.SetActive(false);
				allowSpace = false;
                Choice1c.SetActive(true); // function Choice1cFunct() - search drawer
                Choice1b.SetActive(true); // function Choice1bFunct() - move on to kitchen
        }
		else if (primeInt == 19){
				DeskArt_3.SetActive(false);
				DeskArt_4.SetActive(true);
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "...";
                NarratorSpeech.text = "You pull open the drawers to reveal more papers, mixed in with various nuts, bolts, and other spare mechanical parts.";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt == 20){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "I think I’m beginning to see where the Prime Intelligence’s dissatisfaction was coming from. Wait, what’s this?";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt == 21){
				BookArt.SetActive(true);
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "Wow, that’s a thick manual. And what does this sticky note on it say? The handwriting is awful. Hmm...";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt == 22){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "'Just swapped the hydrator’s power cell, should be good for a while more. Take care of it yourself next time. Disconnection protocol is on p.480.'";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
       else if (primeInt == 23){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "Sounds like this is about the kitchen’s hydrator. I’d better take this and see if the cell it mentions is still there.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
				GameHandler.foundManual = true;
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1b.SetActive(true); // function Choice1bFunct() - move on to kitchen
        }
     }
	 else {    // if you're here, engiAlready must be true!
		primeInt = primeInt + 1;
		if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "...";
                NarratorSpeech.text = "The engineering storage room is just as cluttered as you left it.";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
       else if (primeInt ==3){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "So many crates, and no time to dig through them. Maybe that desk I saw earlier will have something useful.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt ==4){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "...";
                NarratorSpeech.text = "You make your way between shelves and stacks of boxes, returning to the messy desk.";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt ==5){
				DeskArt_3.SetActive(true);
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "So many papers. Nothing immediately useful, but what's in the drawers?";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt ==6){
				DeskArt_3.SetActive(false);
				DeskArt_4.SetActive(true);
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "...";
                NarratorSpeech.text = "You pull open the drawers to reveal more papers, mixed in with various nuts, bolts, and other spare mechanical parts.";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt == 7){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "There's got to be a better way to store all this. Wait, what’s under these papers?";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt == 8){
				BookArt.SetActive(true);
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "Wow, that’s a thick manual. And what does this sticky note on it say? The handwriting is awful. Hmm...";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt == 9){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "“Just swapped the hydrator’s power cell, should be good for a while more. Take care of it yourself next time. Disconnection protocol is on p.480.”";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
       else if (primeInt == 10){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "Sounds like this is about the kitchen’s hydrator. There was something useful here after all!";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
				GameHandler.foundManual = true;
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1b.SetActive(true); // function Choice1bFunct() - move on to kitchen
        }
		else if (primeInt == 51){
				if (GameHandler.foundManual == true){
				DeskArt_1.SetActive(false);
				DeskArt_3.SetActive(false);
				DeskArt_4.SetActive(false);
				BookArt.SetActive(false);
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "Let's go get that power cell.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
										}
				else {
				DeskArt_1.SetActive(false);
				DeskArt_3.SetActive(false);
				DeskArt_4.SetActive(false);
				BookArt.SetActive(false);
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "Hopefully my luck improves.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
				}
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
        }
	 }
}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "Now hold on a moment, there might be something useful here.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
                primeInt = 13;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "Ok, time to keep moving.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
                primeInt = 50;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1cFunct(){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "I know, just a moment longer. I haven’t looked in here yet.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
                primeInt = 18;
                Choice1c.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
            audioSource.Play();
			GameHandler.engiAlready = true;
			StartCoroutine(SceneChangeDelay("Scene4b"));
        }
		
		IEnumerator SceneChangeDelay(string newScene){
			yield return new WaitForSeconds(2f);
			SceneManager.LoadScene(newScene);
		}
		
}