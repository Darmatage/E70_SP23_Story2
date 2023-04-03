using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6bDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		public Text Char3name;
		public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject CapArt_01;
		public GameObject CapArt_02;
		public GameObject CapArt_03;
        public GameObject ArtBG1;
        public GameObject Choice1a;               // leave
        public GameObject Choice1b;              // investigate body
		public GameObject Choice1c;               // take gun?
		public GameObject Choice1d;               // leave gun
		public GameObject Choice1e;               // TAKE GUN!
		public GameObject Choice1f;               // LEAVE GUN!
        public GameObject NextScene1Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        CapArt_01.SetActive(true);
		CapArt_02.SetActive(false);
		CapArt_03.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        Choice1d.SetActive(false);
		Choice1e.SetActive(false);
        Choice1f.SetActive(false);
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
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The interior is dark, but the emergency lights are enough to make out a few details.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "Is that someone lying on the floor? Hello?";
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
                Char3speech.text = "Assessing… No life-signs detected.";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "That uniform… I think that’s the Captain.";
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
                Char3speech.text = "No power source detected. Directive: Continue search elsewhere.";
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // leave
                Choice1b.SetActive(true); // investigate body
        }
       else if (primeInt == 8){                   //you chose to investigate!
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You approach the still figure.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 9){
				CapArt_01.SetActive(false);
				CapArt_02.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "His arm slips off the dresser, thudding limply to the floor as you gently tug open the top drawer.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 10){
                Char1name.text = "YOU";
                Char1speech.text = "A laser pistol.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Directive: Take it.";
				nextButton.SetActive(false);
                allowSpace = false;
				Choice1c.SetActive(true); // take it?
                Choice1d.SetActive(true); // leave it?
        }
       else if (primeInt == 51){            // you left it
                GameHandler.bigH = GameHandler.bigH + 1;
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "This unit’s calculations estimate a high likelihood of violent contact with hostile entities. \n Directive: Take the weapon.";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1e.SetActive(true); // TAKE IT
                Choice1f.SetActive(true); // LEAVE IT
        }
		else if (primeInt == 61){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You turn from the grisly scene, re-entering the hallway and closing the door behind you.";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
        }
     }                                                       // END OF NEXT FUNCTION

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){            			//Choice 1a : leave immediately
                Char1name.text = "YOU";
                Char1speech.text = "I guess I won't find help here...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				NextScene1Button.SetActive(true);
        }
        public void Choice1bFunct(){                      //choice 1b: investigate body
                Char1name.text = "YOU";
                Char1speech.text = "Hang on. It looks like he was reaching for something, in the drawers there.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 7;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1cFunct(){                      //choice 1c: take gun?
				CapArt_02.SetActive(false);
				CapArt_03.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Whoever did this is still out there. I’ll have a better chance of defending myself with this.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 500;
				GameHandler.capsGun = true;
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
				NextScene1Button.SetActive(true);
        }
		public void Choice1dFunct(){                      //choice 1d: leave gun?
                Char1name.text = "YOU";
                Char1speech.text = "I'm not sure if that's the best idea.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 50;
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1eFunct(){                      //choice 1e: TAKE GUN!
                CapArt_02.SetActive(false);
				CapArt_03.SetActive(true);
				Char1name.text = "YOU";
                Char1speech.text = "I guess I’ll be safer this way, at least.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 60;
				GameHandler.capsGun = true;
                Choice1e.SetActive(false);
                Choice1f.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1fFunct(){                      //choice 1f: LEAVE GUN!
                Char1name.text = "YOU";
                Char1speech.text = "I don’t need this. I’m leaving.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 60;
                Choice1e.SetActive(false);
                Choice1f.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
				GameHandler.capQuartersAlready = true;
                audioSource.Play();    
                StartCoroutine(SceneChangeDelay("Scene5"));
        }

		IEnumerator SceneChangeDelay(string newScene){
			yield return new WaitForSeconds(1f);
			SceneManager.LoadScene(newScene);
		}
		
		
}