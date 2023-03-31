using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text PlayerYouName;
        public Text PlayerYouSpeech;
        public Text NarratorName;
        public Text NarratorSpeech;
		public Text HorizonName;
		public Text HorizonSpeech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);

     // Find the gameHandler:
     //audioSource = GetComponent<AudioSource>();
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
                DialogueDisplay.SetActive(true);
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "...";
                NarratorSpeech.text = "You enter the corridor marked “Resources,” doing your best to move quickly without making too much noise.";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
       else if (primeInt ==3){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "...";
                NarratorSpeech.text = "Compared to the area you just left, this hallway is almost pristine. Turning a corner, you find two more doors.";
				HorizonName.text = "";
                HorizonSpeech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "Let’s see… we’ve got the kitchen, and engineering storage.";
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
                HorizonSpeech.text = "Analyzing… \n Directive: Search engineering storage.";
        }
       else if (primeInt == 6){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "I’ll decide on my own, thanks.";
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
                HorizonSpeech.text = "WARNING: all crew members are advised to follow directives issued by this unit. Directives are optimally generated for maximum safety and efficiency.";
        }
		else if (primeInt == 8){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "I thought you said your data library was offline. How would you know which way to go if you can’t tell me anything about the ship’s status?";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt == 9){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "H.O.R.I.Z.O.N.";
                HorizonSpeech.text = "Unit: H.O.R.I.Z.O.N. is equipped with advanced deductive algorithms and logic calculators. ";
        }
		else if (primeInt == 10){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "…So, you’re guessing.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
        }
		else if (primeInt == 11){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "H.O.R.I.Z.O.N.";
                HorizonSpeech.text = "WARNING: Hardware Anthropomorphization detected.";
        }
		else if (primeInt == 12){
                PlayerYouName.text = "";
                PlayerYouSpeech.text = "";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "H.O.R.I.Z.O.N.";
                HorizonSpeech.text = "Do not assign human qualities to this unit’s calculations, which are calibrated to deliver mathematically optimized solutions with unmatched precision.";
        }
       else if (primeInt == 13){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "Yeah, well, it’s still a guess.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 16){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "That’s my guess too.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
        }
       else if (primeInt == 21){
                PlayerYouName.text = "You";
                PlayerYouSpeech.text = "Food is one of the most important things for the crew, so the facilities for storing and preparing it probably have their own backup power.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
				HorizonName.text = "";
                HorizonSpeech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "That being said, engineering storage does sound like the kind of place you’d find a power cell.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
                primeInt = 15;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                PlayerYouName.text = "YOU";
                PlayerYouSpeech.text = "I see why you’d pick engineering, but we’re going in here.";
                NarratorName.text = "";
                NarratorSpeech.text = "";
                primeInt = 20;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               audioSource.Play();
			   StartCoroutine(SceneChangeDelay("Scene4a"));
        }
        public void SceneChange2(){
            audioSource.Play();
				StartCoroutine(SceneChangeDelay("Scene4b"));
        }
		
		IEnumerator SceneChangeDelay(string newScene){
			yield return new WaitForSeconds(1f);
			SceneManager.LoadScene(newScene);
		}
}