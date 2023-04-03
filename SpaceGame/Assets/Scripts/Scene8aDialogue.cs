using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene8aDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		public Text Char3name;
		public Text Char3speech;
		public Text Char4name;
		public Text Char4speech;
        public GameObject DialogueDisplay;
        public GameObject GuardArtIdle;
		public GameObject GuardArtAlert;
		public GameObject GuardArtHostile;
		public GameObject GuardArtShooting;
        public GameObject ArtBG1;
        public GameObject Choice1a;                         // talk
        public GameObject Choice1b;                         // leave
		public GameObject Choice1c;                         // talk more
		public GameObject Choice1d;                         // flee
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       public AudioSource audioLaserMany;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        GuardArtIdle.SetActive(false);
		GuardArtAlert.SetActive(false);
		GuardArtHostile.SetActive(false);
		GuardArtShooting.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
		Choice1d.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
		GameHandler.armoryAlready = true;

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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You step carefully toward the open door, noticing that the wall directly across from it bears several burn marks, charred wiring visible through melted holes.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You lean forward just enough to peek through the door.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
				GuardArtIdle.SetActive(true);
				GuardArtAlert.SetActive(false);
				GuardArtHostile.SetActive(false);
				GuardArtShooting.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Within the armory are several crew members, flustered and disheveled.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The voices you hear come from a hushed but heated conversation between two of them, as the rest either sit dejectedly or scavenge the room.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
               Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "All appear to have armed themselves with laser rifles.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Assessing… \n Quandary detected.";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt ==8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Assessment: Crew is deranged. \n Directive: Avoid contact.";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt ==9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Assessment: Weapon recharging stations are connected to a dedicated power cell, located in the rear chamber of Armory. \n Directive: Retrieve power cell.";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt ==10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You duck away from the entrance for a moment.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt ==11){
                Char1name.text = "YOU";
                Char1speech.text = "Deranged? Are you sure? It looks like they’re hiding in here, maybe they’re just scared.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt ==12){
                Char1name.text = "YOU";
                Char1speech.text = "Even if they ARE mutineers or something, maybe I can negotiate. Surely they don’t want to die when the ships’s reserve power runs out.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt ==13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Estimated probability of success: low. Directive: Seek alternate route.";
				Char4name.text = "";
                Char4speech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // Choice 1a: TALK
                Choice1b.SetActive(true); // CHOICE 1b: LEAVE
        }

																// ENCOUNTER AFTER CHOICE #1a - TALK
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You step fully through the doorway, walking into the room and raising your hands in a gesture meant to be non–threatening.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 22){
                GameHandler.bigH = GameHandler.bigH + 1;
				Char1name.text = "YOU";
                Char1speech.text = "Excuse me? Are you alr-";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 23){
				GuardArtIdle.SetActive(false);
				GuardArtAlert.SetActive(true);
				GuardArtHostile.SetActive(false);
				GuardArtShooting.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The attention of everyone in the room snaps to you as you enter the armory.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 24){
                GuardArtIdle.SetActive(false);
				GuardArtAlert.SetActive(false);
				GuardArtHostile.SetActive(true);
				GuardArtShooting.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Immediately, several weapons are pointed toward you as other crew members scramble to take up their arms.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 25){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "Crewmate 1";
                Char4speech.text = "Stay back!";
        }
		else if (primeInt == 26){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "Crewmate 2";
                Char4speech.text = "What are you waiting for? Shoot it!";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1c.SetActive(true); // Choice 1c: TALK MORE
                Choice1d.SetActive(true); // CHOICE 1d: FLEE
        }
		else if (primeInt == 31){       
                audioLaserMany.Play();                                                  //Choice 1c: TALK MORE
                GuardArtIdle.SetActive(false);
				GuardArtAlert.SetActive(false);
				GuardArtHostile.SetActive(false);
				GuardArtShooting.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Several members of the crew open fire at the same time, the beams striking you simultaneously and sending you tumbling to the floor.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene2Button.SetActive(true);
        }
		else if (primeInt == 41){        
                audioLaserMany.Play();                                       //Choice 1d: Flee!
                GuardArtIdle.SetActive(false);
				GuardArtAlert.SetActive(false);
				GuardArtHostile.SetActive(false);
				GuardArtShooting.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You hurl yourself back toward the door just as several crew members open fire.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){                             // Choice 1a: Talk to Guards
                Char1name.text = "YOU";
                Char1speech.text = "They're people, not monsters. I'm sure I can work something out.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
                primeInt = 20;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){                              //Choice 1b: Leave Armory
                Char1name.text = "YOU";
                Char1speech.text = "I guess I can’t afford to take any risks right now. I’ll try to find another way to access the armory’s back room.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				NextScene1Button.SetActive(true);
        }
		public void Choice1cFunct(){                              //Choice 1c: Talk More
                Char1name.text = "YOU";
                Char1speech.text = "Please, listen! I'm-";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
                primeInt = 30;
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
				nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1dFunct(){                              //Choice 1d: FLEE
                Char1name.text = "YOU";
                Char1speech.text = "Uh oh...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
                primeInt = 40;
				GameHandler.guardsAlert = true;
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
				nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){                                        //Scene Change 1: Leave Armory
               SceneManager.LoadScene("Scene7");                      
        }
        public void SceneChange2(){                                        // Scene Change 2: Game Over
                SceneManager.LoadScene("End_LoseBlood");
        }
}