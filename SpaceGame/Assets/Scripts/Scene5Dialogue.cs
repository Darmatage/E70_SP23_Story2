using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		public Text Char3name;
		public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtBG1;
		public GameObject ArtBG2;
        public GameObject Choice1a;                  // MEDBAY
        public GameObject Choice1b;                   // CAPTAINS QUARTERS
		public GameObject Choice1c;                  // cryo
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		public GameObject NextScene3Button;
		public GameObject NextScene4Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        if (GameHandler.corridorBAlready == false) {
		DialogueDisplay.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
		NextScene4Button.SetActive(false);
        nextButton.SetActive(true);
		}
		else {
		DialogueDisplay.SetActive(false);
        ArtBG2.SetActive(true);
		ArtBG1.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
		NextScene4Button.SetActive(false);
        nextButton.SetActive(true);	
		}
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
	if (GameHandler.corridorBAlready == false) {
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You hurry through the depths of the ship, moving as fast as you can through the dim halls.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "Looks like the hallway opens up ahead. Let’s see what we can find.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                ArtBG2.SetActive(true);
				ArtBG1.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You find yourself in a wider hall, with doors set in the walls.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "It appears you have found the Medical Bay, the Captain’s Quarters, and the Cryogenic Stasis Chamber.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
               Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "All three doors are closed, but don’t appear to be locked.";
				Char3name.text = "";
                Char3speech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // CHOICE: MEDBAY
                Choice1b.SetActive(true); // CHOICE: CAPTAIN'S QUARTERS
				Choice1c.SetActive(true); //  CHOICE: CRYO
	   } 
     }
	 else {                                                            // not your first time in corridor B!
		primeInt = primeInt + 1;
        if (primeInt == 1){
            ArtBG2.SetActive(true);
			ArtBG1.SetActive(false);
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You find yourself in the wide hall once more.";
				Char3name.text = "";
                Char3speech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
				
				if (GameHandler.batteries >= 2) {        // got cells? then git!
					if (GameHandler.cryoAlready == true) {
						NextScene4Button.SetActive(true);
					}
					else {
						NextScene4Button.SetActive(true);
						Choice1c.SetActive(true); //  CHOICE: CRYO
					}
				}
				else {
					if (GameHandler.medbayAlready == false) {
						Choice1a.SetActive(true); // CHOICE: MEDBAY
					}
					if (GameHandler.capQuartersAlready == false) {
						Choice1b.SetActive(true); // CHOICE: CAPTAIN'S QUARTERS
					}
					if (GameHandler.cryoAlready == false) {
						Choice1c.SetActive(true); //  CHOICE: CRYO
					}	
				}
        }
	 }
}  // end of next function

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){                            // SEARCH MEDBAY
                Char1name.text = "YOU";
                Char1speech.text = "Might be some useful supplies there.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                NextScene1Button.SetActive(true);
        }
        public void Choice1bFunct(){                         // SEARCH CAPTAIN'S QUARTERS
                Char1name.text = "YOU";
                Char1speech.text = "I wonder if the Captain's hiding in there? Maybe not, doesn't look locked.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                NextScene2Button.SetActive(true);
        }
		public void Choice1cFunct(){                             // SEARCH CRYO
                Char1name.text = "YOU";
                Char1speech.text = "What's in here?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                NextScene3Button.SetActive(true);
        }

        public void SceneChange1(){                                //medbay
				GameHandler.corridorBAlready = true;
               audioSource.Play();
			   StartCoroutine(SceneChangeDelay("Scene6a"));
        }
        public void SceneChange2(){                            //captain
				GameHandler.corridorBAlready = true;
                audioSource.Play();
				StartCoroutine(SceneChangeDelay("Scene6b"));
        }
		public void SceneChange3(){                             //cryo
				GameHandler.corridorBAlready = true;
                audioSource.Play();
				StartCoroutine(SceneChangeDelay("Scene6c"));
        }
		public void SceneChange4(){                         //onward
				GameHandler.corridorBAlready = true;
				if (GameHandler.batteries >= 3) {
					SceneManager.LoadScene("Scene9");
				}
				else if (GameHandler.corridorCAlready == true){
					SceneManager.LoadScene("Scene3");
				}
				else {
					SceneManager.LoadScene("Scene7");
				}
        }
		
		IEnumerator SceneChangeDelay(string newScene){
			yield return new WaitForSeconds(2f);
			SceneManager.LoadScene(newScene);
		}
}