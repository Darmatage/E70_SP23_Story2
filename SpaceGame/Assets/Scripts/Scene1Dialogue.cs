using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
        public int primeInt = 0;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		public Text Char3name;
		public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject GeneratorArt;
		public GameObject GenBodyArt_1;
		public GameObject GenBodyArt_2;
		public GameObject BrokenRifleArt;
		public GameObject ArrayArt;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice1c;
		public GameObject Choice1d;
		public GameObject Choice1e;
        public GameObject NextScene1Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       public AudioSource audioSource;
        private bool allowSpace = true;
		public bool seenGenerator = false;
		public GameObject theDarkness;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        GeneratorArt.SetActive(false);
		GenBodyArt_1.SetActive(false);
		GenBodyArt_2.SetActive(false);
		BrokenRifleArt.SetActive(false);
		ArrayArt.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
		Choice1d.SetActive(false);
		Choice1e.SetActive(false);
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
			
			theDarkness.SetActive(true);
                // AudioSource.Play();
        }
        else if (primeInt == 2){
               
			    StartCoroutine(FadeOut(theDarkness));
			    
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "...";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
				theDarkness.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "*BEEP*...BEEP*...BEEP*...BEEP*...BEEP*... \n BEEP*...";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "You";
                Char1speech.text = "What… what is that?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You find yourself in a dark room, illuminated only partially by red emergency lights along the edges of the floor.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The beeping sound continues steadily. Where is it coming from? As you look around, you suddenly hear a voice.";
        }
		else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "?";
                Char3speech.text = "Initializing...";
        }
		else if (primeInt == 8){
                Char1name.text = "You";
                Char1speech.text = "Who said that?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You look around the room. The beeping continues, but it appears you’re the only one here.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The voice speaks again, its tone stilted and digital.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "?";
                Char3speech.text = "Reboot complete. WARNING: Generator Offline.";
        }
		else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "?";
                Char3speech.text = "Emergency power only, reserves critically low. Restore main power immediately.";
        }
		else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Your memory is terribly foggy and unclear, but the words spark recognition within you.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You are part of the crew of the starship Orpheus, a research vessel.";
				Char3name.text = "";
                Char3speech.text = "";

        }
		else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Your mission is an exploratory one, to the black hole BFH-9 to gather data from a safe orbit.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 16){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The ship entered that orbit 4 months ago, and is meant to stay another 2 before making the return journey to Earth.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 17){
                Char1name.text = "You";
                Char1speech.text = "Generator offline… how could that have happened? Wait, who said that anyway?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 18){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Heuristic Optimization and Routing Intelligence Zone Operating Network.";
                Char3speech.text = "Designation: Heuristic Optimization and Routing Intelligence Zone Operating Network.";
        }
		else if (primeInt == 19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Heuristic Optimization and Routing Intelligence Zone Operating Network.";
                Char3speech.text = "Source of generator disruption: Unknown. Restore main power immediately.";
        }
		else if (primeInt == 20){
                Char1name.text = "You";
                Char1speech.text = "Heuristic Opti… what? Oh, I get it. Your name is supposed to be Horizon, right?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Colloquial designation recognized.";
        }
		else if (primeInt == 22){
                Char1name.text = "You";
                Char1speech.text = "Could have just gone with that to begin with… Anyway, why can I hear you? I don’t see anyone else here.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 23){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Function: guide and assist crew through cybernetic link.";
        }
		else if (primeInt == 24){
                Char1name.text = "You";
                Char1speech.text = "Ah, so you’re in my head. Strange, I don’t remember installing you. Come to think of it, I don’t remember much of anything…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 25){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "WARNING: Emergency power reserves critically low. Restore main power immediately.";
        }
		else if (primeInt == 26){
                Char1name.text = "You";
                Char1speech.text = "Right, you said the generator is offline. That’s not good.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 27){
                Char1name.text = "You";
                Char1speech.text = "Well, it appears we’re already in the generator room. Let me take a look around before life support systems start failing.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 28){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You look around the room, and quickly find the generator - a bulky, mechanical object that stretches nearly wall-to-wall at one end of the room.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 29){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You also notice a lumpy shape, slumped in the shadows against a wall. You look closer, your eyes adjusting to the low light.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The shape is a body, another crew member judging by the uniform. They are completely still.";
				Char3name.text = "";
                Char3speech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

// Investigate Generator Choice
       else if (primeInt == 101){
				GeneratorArt.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Aside from the steady beeping sound and the error message flashing on the control panel, the machine shows no signs of life.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "There are three large ports in the front, all empty.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 103){
                Char1name.text = "You";
                Char1speech.text = "Let’s see… Oh, well there’s the problem. The power cells are gone.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 104){
                Char1name.text = "You";
                Char1speech.text = "Without those, all we’re going to get out of this is error messages.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 105){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Assessment: Corroborated. Locate replacement power cells immediately.";
        }
		else if (primeInt == 106){
                Char1name.text = "You";
                Char1speech.text = "Yes, obviously.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 107){
				GeneratorArt.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You turn back towards the rest of the room, once again noticing the person lying against the wall.";
				Char3name.text = "";
                Char3speech.text = "";
				seenGenerator = true;
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1c.SetActive(true); // function Choice1cFunct()
        }
		
// Investigate Body Choice
       else if (primeInt == 201){
				GenBodyArt_1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You step closer. The person lies on their side, oddly tilted towards the wall.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 202){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "They do not seem to be breathing. Closer now, you can see faint tendrils of smoke rising from them.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 203){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You gently prod the figure, but there is no response.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 204){
				GenBodyArt_1.SetActive(false);
				GenBodyArt_2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Carefully, you turn them over onto their back to reveal the reason for their strange posture - the ruptured power cell array beneath them, burned and burst.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 205){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "It seems to have been destroyed by a powerful laser beam, likely from a weapon.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 206){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Judging by the scorched ruin of your crewmate’s chest, they were holding the array when it happened.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 207){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Strangely, you don’t recognize this person.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 208){
                Char1name.text = "You";
                Char1speech.text = "This… this wasn’t an accident. Who would do something like this? And why?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 209){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Assessment: Sabotage. Power cell damage: irreparable. Locate replacement power cells immediately.";
        }
		else if (primeInt == 210){
                Char1name.text = "You";
                Char1speech.text = "That’s not very helpful. I may not remember much of the voyage here, but I know something like this should never have happened.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 211){
                Char1name.text = "You";
                Char1speech.text = "I need to find some answers.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 212){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "WARNING: emergency power reserves critically low. Locate replacement power cells immediately.";
        }
		else if (primeInt == 213){
				GenBodyArt_2.SetActive(false);
                Char1name.text = "You";
                Char1speech.text = "Yes, I'll find those too.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
				allowSpace = false;
				if (seenGenerator == true){
					Choice1d.SetActive(true); // function Choice1dFunct()
				}
				else {
					Choice1e.SetActive(true); // function Choice1eFunct()	
				}
        }
		else if (primeInt == 220){
				GeneratorArt.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Aside from the steady beeping sound and the error message flashing on the control panel, the machine shows no signs of life.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 221){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "There are three large ports in the front, all empty.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 222){
                Char1name.text = "You";
                Char1speech.text = "Well, that’s where those cells came from. No wonder the power’s out.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 223){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Assessment: Corroborated. Locate replacement power cells immediately.";
        }
		else if (primeInt == 224){
                Char1name.text = "You";
                Char1speech.text = "Yes, obviously.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 225){
				GeneratorArt.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You turn back towards the rest of the room.";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
				allowSpace = false;
				Choice1d.SetActive(true); // function Choice1dFunct()
        }
		else if (primeInt == 250){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You look around for an exit, and see a single closed door in the wall opposite the generator.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 251){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "With only one way out, you make your way toward it.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 252){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Halfway there, there’s a sudden clatter as your foot bumps into something on the floor.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 253){
				BrokenRifleArt.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "What…? A laser rifle… completely empty. It must have been discharged all at once, considering how heat-warped the barrel is.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 254){
                Char1name.text = "You";
                Char1speech.text = "Must have belonged to whoever is responsible for this.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 255){
				BrokenRifleArt.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Leaving the now-useless weapon, you proceed to the door. Next to it, you notice some shelves.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 256){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "On them are several spare battery racks, which are used to connect multiple power cells together into a fully functional unit.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 257){
				ArrayArt.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "If I don’t want to be walking around with my arms full the whole time, I should take one of these.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 258){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = " You pick up a rack and sling the carrying strap over your shoulder, turning back towards the door.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 259){
				ArrayArt.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Though it can’t open on its own under emergency power, the latch to open it manually proves functional.";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

      //Please do NOT delete this MOST HOLY bracket that ends the next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "You";
                Char1speech.text = "I'll take a look at the generator.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 100;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Oh no...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 200;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1cFunct(){
				GeneratorArt.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Who is that, anyway?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 200;
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1dFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Doesn't look like I'll find what I need in this room. I'd better start looking around.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 249;
                Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1eFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I wonder if these cells came from the generator?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 219;
                Choice1e.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
            audioSource.Play();
			StartCoroutine(SceneChangeDelay("Scene2"));
        }
		
		IEnumerator SceneChangeDelay(string newScene){
			yield return new WaitForSeconds(1f);
			SceneManager.LoadScene(newScene);
		}
		
		IEnumerator FadeIn(GameObject fadeImage){
                float alphaLevel = 0;
                fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                for(int i = 0; i < 800; i++){
                        alphaLevel += 0.00125f;
                        yield return null;
                        fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                        Debug.Log("Alpha is: " + alphaLevel);
                }
        }

        IEnumerator FadeOut(GameObject fadeImage){
                float alphaLevel = 1;
                fadeImage.GetComponent<Image>().color = new Color(0, 0, 0, alphaLevel);
                for(int i = 0; i < 800; i++){
                        alphaLevel -= 0.00125f;
                        yield return null;
                        fadeImage.GetComponent<Image>().color = new Color(0, 0, 0, alphaLevel);
                        Debug.Log("Alpha is: " + alphaLevel);
                }
        } 
		
		
}