using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4bDialogue : MonoBehaviour {
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
        public GameObject Choice1a;  // search panty
        public GameObject Choice1b;     // search hydrator
		public GameObject Choice1c;   // leave hydrator
		public GameObject Choice1d;     //red wire
		public GameObject Choice1e; // green wire
		public GameObject Choice1f;    // blue wire
		public GameObject Choice1g;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;
		public bool redPull = false;
		public bool greenPull = false;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
		Choice1d.SetActive(false);
		Choice1e.SetActive(false);
		Choice1f.SetActive(false);
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
                Char2speech.text = "You enter a moderately sized mess hall, with simple tables and benches bolted to the floor.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Analyzing??? Power source detected. \n Directive: Proceed to kitchen.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "You";
                Char1speech.text = "Hmm, a few plates left on the tables, meals unfinished. Whatever happened must have started suddenly.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "At the back of the room are a series of cabinets, and a boxy machine emitting a soft hum.";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
               Char1name.text = "You";
                Char1speech.text = "A pantry, and the hydrator. Not much of a kitchen, but you make do when you???re in space.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct() - search pantry
                Choice1b.SetActive(true); // function Choice1bFunct() - investigate hydrator
        }
  
		else if (primeInt ==61){
                Char1name.text = "You";
                Char1speech.text = "Time to look around.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // Choice1aFunct() - search pantry
                Choice1b.SetActive(true); //  Choice1bFunct() - investigate hydrator
				Choice1g.SetActive(true); //  Choice1gFunct() - back to engineering
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

// ENCOUNTER AFTER pantry choice
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The cabinets are full of dried rations, the primary source of sustenance for such voyages.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Composed of reconstructed proteins, they???re made to taste and feel somewhat like real food after being re-moisturized in the hydrator.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==23){
                Char1name.text = "You";
                Char1speech.text = "Beef, chicken, even chocolate. Not a bad selection. ";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==24){
                Char1name.text = "You";
                Char1speech.text = "Huh. For some reason, I can???t remember which of these was my favorite.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==25){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "WARNING: Emergency Power Reserves critically low. Restore Main Power immediately.";
        }
		else if (primeInt ==26){
                Char1name.text = "You";
                Char1speech.text = "Yeah yeah, I know. I can eat when the ship???s out of danger. Not hungry anyway.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		// ENCOUNTER AFTER hydrator choice
		else if (primeInt ==51){
                Char1name.text = "You";
                Char1speech.text = "Ah, here we go. The power cell, hooked up to the back. There???s a few different cables, actually.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==52){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "DANGER: Hyper-concentrated energy source detected. Improper discharge may result in lethal injury.";
        }
		else if (primeInt ==53){
                Char1name.text = "You";
                Char1speech.text = "Hopefully I do this right.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1c.SetActive(true); // leave hydrator
                Choice1d.SetActive(true); // red
				Choice1e.SetActive(true); // green
				Choice1f.SetActive(true); // blue
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){   // search pantry
                Char1name.text = "You";
                Char1speech.text = "Let's see what's in here.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 20;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){     // investigate hydrator
                Char1name.text = "You";
                Char1speech.text = "A simple machine, but an important one. And it???s still on. Let???s see???";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 50;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1cFunct(){     // leave hydrator
                Char1name.text = "You";
                Char1speech.text = "Ok, one moment. If I get fried, I can???t get the ship back online. Maybe I can figure out a better way.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 60;
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
				Choice1e.SetActive(false);
                Choice1f.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1dFunct(){     // red wire
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 50;
                Choice1d.SetActive(false);
        }
		public void Choice1eFunct(){     //green wire
                Char1name.text = "You";
                Char1speech.text = "A simple machine, but an important one. And it???s still on. Let???s see???";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 50;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1fFunct(){     // blue wire
                Char1name.text = "You";
                Char1speech.text = "A simple machine, but an important one. And it???s still on. Let???s see???";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 50;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1gFunct(){     // back to engineering
                Char1name.text = "You";
                Char1speech.text = "A simple machine, but an important one. And it???s still on. Let???s see???";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 50;
                Choice1a.SetActive(false); // Choice1aFunct() - search pantry
                Choice1b.SetActive(false); //  Choice1bFunct() - investigate hydrator
				Choice1g.SetActive(false); //  Choice1gFunct() - back to engineering
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}