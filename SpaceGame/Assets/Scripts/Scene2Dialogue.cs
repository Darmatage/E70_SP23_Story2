using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text PlayerYouName;
        public Text PlayerYouSpeech;
        public Text NarratorName;
        public Text NarratorSpeech;
        public Text HorizonName;
        public Text HorizonSpeech;
        public GameObject DialogueDisplay;
        
		public GameObject ArtPlayerYoua;
        public GameObject ArtPlayerYoub;
	    
        
		public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice1c;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
        public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        // Just enable the background and next button 
        DialogueDisplay.SetActive(false);
        ArtPlayerYoua.SetActive(false);
		ArtPlayerYoub.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);

        //audioSource = GetComponent<AudioSource>();
     // Find the gameHandler:
     // gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
   }

void Update()
    {         
        // use spacebar as Next button
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
                
                DialogueDisplay.SetActive(true);
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "...";
                NarratorSpeech.text = "You emerge into a sizeable corridor.";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
       else if (primeInt ==3){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "So many scorch marks on the walls… and two more of the crew cut down...";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "It looks like a battlefield out here. Was there a mutiny or something?";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
       else if (primeInt == 5){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "H.O.R.I.Z.O.N.";
                HorizonSpeech.text = "Analyzing… Result: Probable.";
        }
      else if (primeInt == 6){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "You don’t know? Shouldn’t you be connected to the rest of the ship? What do the logs show?";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
       else if (primeInt == 7){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "H.O.R.I.Z.O.N.";
                HorizonSpeech.text = "Data library offline. Re-start generator to restore access.";
        }
       else if (primeInt == 8){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "Right. But as far as I can tell, whoever did this is probably still around somewhere. You really don’t have any useful information about what happened?";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		
		else if (primeInt ==9){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "If I’m going to be searching all over for replacement power cells, I’d like to have some idea of what I might be running into, or at least how extensive any damage is.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
        }
		else if (primeInt == 10){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "H.O.R.I.Z.O.N.";
                HorizonSpeech.text = "Data library offline. Re-start generator to restore access.";
        }
		else if (primeInt == 11){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "Great, just great… \n Wait, that door over there! That leads to the bridge.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt == 12){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "The ship’s computer will probably be offline, but maybe the Captain’s still in there? There’s got to be some useful information, at least.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt == 13){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "...";
                NarratorSpeech.text = "You approach the nearby door, and try to open it manually. It doesn’t move at all.";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt == 14){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "H.O.R.I.Z.O.N.";
                HorizonSpeech.text = "Bridge Bulkhead Status: Lockdown. Re-start generator to restore access.";
        }
		else if (primeInt == 15){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "It’s been sealed? A mutiny sounds more and more likely. If someone locked themselves in here, it would probably be the Captain.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()  Button: "Bang On Door"
                Choice1b.SetActive(true); // function Choice1bFunct()  Button: "Search Elsewhere"
        }
		
		
		// after CHOICE #1a - bang on door:
		else if (primeInt == 17){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "Hello? Is anyone in there? I don’t know what’s going on, but the ship is in danger!";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
       else if (primeInt == 18){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "We need to get the power up and running again, before we start losing gravity and life support!";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		       else if (primeInt == 19){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "...";
                NarratorSpeech.text = "You wait for a response, but hear nothing from behind the door. It remains firmly closed.";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		       else if (primeInt == 20){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "Well, if anyone’s in there, they must not be able to hear me. There probably won’t be a spare power cell on the bridge anyway.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1c.SetActive(true); // function Choice1cFunct()  Button: "Continue"
        }
		
				// after CHOICE #1b or #1c:
       else if (primeInt == 22){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "...";
                NarratorSpeech.text = "You turn away from the door to the bridge. Aside from the entrance back into the generator room, the corridor leads off in two different directions.";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		 else if (primeInt == 23){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "...";
                NarratorSpeech.text = "Signs indicate that they go towards “Resources” and “Crew Quarters,” respectively.";
				HorizonName.text = "";
                HorizonSpeech.text = "";
				// Turn off "Next" button, turn on "Scene change" buttons
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
				NextScene2Button.SetActive(true);
			
			}		

		// useful examples from jason
		//else if (primeInt == 41){
               // PlayerYouName.text = "";
                //PlayerYouSpeech.text = "";
                //NarratorName.text = "AI";
                //NarratorSpeech.text = "We have " + GameHandler.batteries + " so far.";
       // }

       //else if (primeInt == 43){
                //PlayerYouName.text = "";
                //PlayerYouSpeech.text = "";
               // NarratorName.text = "";
               // NarratorSpeech.text = "";
			
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
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "...";
                NarratorSpeech.text = "You knock on the thick metal door a few times, hard. It barely vibrates.";
				HorizonName.text = "";
                HorizonSpeech.text = "";
                primeInt = 16;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "No way to get through a door that thick, and there probably won’t be a spare power cell on the bridge anyway. I should search elsewhere.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
                primeInt = 21;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1cFunct(){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "I don’t have much time, I’d better look elsewhere.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
                primeInt = 21;
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               // TODO: Add door open close sound. 
               audioSource.Play();
               StartCoroutine(SceneChangeDelay("Scene3"));
        }
        public void SceneChange2(){
                // TODO: Add door open close sound. 
                audioSource.Play();    
                StartCoroutine(SceneChangeDelay("Scene7"));
        }

		IEnumerator SceneChangeDelay(string newScene){
			yield return new WaitForSeconds(1f);
			SceneManager.LoadScene(newScene);
		}

		
		
}