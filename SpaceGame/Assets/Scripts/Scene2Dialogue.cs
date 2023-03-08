using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        
		public GameObject ArtChar1a;
        public GameObject ArtChar1b;
	    public GameObject ArtEngine;
        
		public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice1c;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtEngine.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
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
        primeInt += 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                ArtEngine.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You emerge into a sizeable corridor.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "You";
                Char1speech.text = "So many scorch marks on the walls… and two more of the crew cut down...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "You";
                Char1speech.text = "It looks like a battlefield out here. Was there a mutiny or something?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Analyzing… Result: Probable.";
        }
      else if (primeInt == 6){
                Char1name.text = "You";
                Char1speech.text = "You don’t know? Shouldn’t you be connected to the rest of the ship? What do the logs show?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Data library offline. Re-start generator to restore access.";
        }
       else if (primeInt == 8){
                Char1name.text = "You";
                Char1speech.text = "Right. But as far as I can tell, whoever did this is probably still around somewhere. You really don’t have any useful information about what happened?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		
		else if (primeInt ==9){
                Char1name.text = "You";
                Char1speech.text = "If I’m going to be searching all over for replacement batteries, I’d like to have some idea of what I might be running into, or at least how extensive any damage is.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Data library offline. Re-start generator to restore access.";
        }
		else if (primeInt == 11){
                Char1name.text = "You";
                Char1speech.text = "Great, just great… \n Wait, that door over there! That leads to the bridge.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 12){
                Char1name.text = "You";
                Char1speech.text = "The ship’s computer will probably be offline, but maybe the Captain’s still in there? There’s got to be some useful information, at least.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You approach the nearby door, and try to open it manually. It doesn’t move at all.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Bridge Bulkead Status: Lockdown. Re-start generator to restore access.";
        }
		else if (primeInt == 15){
                Char1name.text = "You";
                Char1speech.text = "It’s been sealed? A mutiny sounds more and more likely. If someone locked themselves in here, it would probably be the Captain.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()  Button: "Bang On Door"
                Choice1b.SetActive(true); // function Choice1bFunct()  Button: "Search Elsewhere"
        }
		
		
		// after CHOICE #1a - bang on door:
		else if (primeInt == 17){
                Char1name.text = "You";
                Char1speech.text = "Hello? Is anyone in there? I don’t know what’s going on, but the ship is in danger!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 18){
                Char1name.text = "You";
                Char1speech.text = "We need to get the power up and running again, before we start losing gravity and life support!”";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		       else if (primeInt == 19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You wait for a response, but hear nothing from behind the door. It remains firmly closed.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		       else if (primeInt == 20){
                Char1name.text = "You";
                Char1speech.text = "Well, if anyone’s in there, they must not be able to hear me. There probably won’t be a spare power cell on the bridge anyway.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1c.SetActive(true); // function Choice1cFunct()  Button: "Continue"
        }
		
				// after CHOICE #1b or #1c:
       else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You turn away from the door to the bridge. Aside from the entrance back into the generator room, the corridor leads off in two different directions.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 23){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Signs indicate that they go towards “Resources” and “Crew Quarters,” respectively.";
				Char3name.text = "";
                Char3speech.text = "";
				// Turn off "Next" button, turn on "Scene change" buttons
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
				NextScene2Button.SetActive(true);
			
			}		

		// useful examples from jason
		//else if (primeInt == 41){
               // Char1name.text = "";
                //Char1speech.text = "";
                //Char2name.text = "AI";
                //Char2speech.text = "We have " + GameHandler.batteries + " so far.";
       // }

       //else if (primeInt == 43){
                //Char1name.text = "";
                //Char1speech.text = "";
               // Char2name.text = "";
               // Char2speech.text = "";
			
                //nextButton.SetActive(false);
                //allowSpace = false;
				// Turn off "Next" button, turn on "Scene change" buttons
				//DialogueDisplay.SetActive(false);
				//if (GameHandler.sawCorridorA == false){NextScene1Button.SetActive(true);} // function SceneChange1()  Button: "Search Corridor A"
               // if (GameHandler.sawCorridorB == false){NextScene2Button.SetActive(true);} // function SceneChange2()  Button: "Search Corridor B"
				//if (GameHandler.sawCorridorC == false){NextScene3Button.SetActive(true);} // function SceneChange3()  Button: "Search Corridor C"
        //}

      //Please do NOT delete this MOST HOLY bracket that ends the next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You knock on the thick metal door a few times, hard. It barely vibrates.";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 16;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "You";
                Char1speech.text = "No way to get through a door that thick, and there probably won’t be a spare power cell on the bridge anyway. I should search elsewhere.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 21;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1cFunct(){
                Char1name.text = "You";
                Char1speech.text = "I don’t have much time, I’d better look elsewhere.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 21;
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene3");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene5");
        }	
		
}