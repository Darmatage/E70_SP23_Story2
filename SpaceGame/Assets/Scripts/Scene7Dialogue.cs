using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene7Dialogue : MonoBehaviour {
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
        public GameObject Choice1a;             //armory
        public GameObject Choice1b;             // barracks
		public GameObject Choice1c;            // cargo
        public GameObject Choice1d;           // airlock
		public GameObject Choice1e;            // move on
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		public GameObject NextScene3Button;
		public GameObject NextScene4Button;
		public GameObject NextScene5Button;
        public GameObject nextButton;
        public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

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
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
		NextScene4Button.SetActive(false);
		NextScene5Button.SetActive(false);
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
	if (GameHandler.corridorCAlready == false) {
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
                Char2speech.text = "You enter the corridor marked “Crew Quarters,” moving through hallways spattered with laser burns. Occasionally, you pass another body.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "Things look worse and worse… And I haven’t recognized anyone we’ve found. What is going on?";
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
                Char3speech.text = "Data Library Offline. Re-start generator to restore access.";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "There sure is a lot you don’t know. Is there anything useful you CAN tell me?";
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
                Char3speech.text = "Mass of BFH-9 is roughly equivalent to mass of Earth’s Sun. Therefore, BFH-9 contains roughly 1.514 x 10\u2077\u2077 bits of information.";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "I’m not really sure what that means, or how it’s supposed to be useful.";
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
                Char3speech.text = "If one encoded all human speech since species origin as 16-bit audio, it would only occupy an estimated 3.36 x 10²¹ bits.";
        }
		else if (primeInt ==9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Comparing this to the 1.514 x 10\u2077\u2077 bits of information that BFH-9 has absorbed from the universe demonstrates the magnitude of information trapped within BFH-9.";
        }
		else if (primeInt ==10){
                Char1name.text = "YOU";
                Char1speech.text = "That’s all very interesting, but it doesn’t do much to help me fix the ship. Besides, it’s not like we’ll ever be able to access any of that information anyway. It’s gone.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "It has been hypothesized that energy absorbed by black holes remains trapped within the event horizon.";
        }
		else if (primeInt ==12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Destruction of that energy would violate the law of conservation of energy.";
        }
		else if (primeInt ==13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Therefore, the information is not lost, only inaccessible.";
        }
		else if (primeInt ==14){
                Char1name.text = "YOU";
                Char1speech.text = "Well, given that we’re talking about a literal black hole, the difference seems semantic.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You round a corner to discover that the next stretch of hallway contains several doors.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==16){
                Char1name.text = "YOU";
                Char1speech.text = "Time to focus. Wait, what’s that sound?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The doors are labeled Barracks, Cargo Bay, Airlock, and Armory. The armory door is stuck partially open, and you hear the faint murmur of voices from within.";
				Char3name.text = "";
                Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // ChoiceA: Investigate Armory
                Choice1b.SetActive(true); // ChoiceB: Investigate Barracks
				Choice1c.SetActive(true); // ChoiceC: Investigate Cargo Bay
                Choice1d.SetActive(true); // ChoiceD: Investigate Airlock
				if (GameHandler.batteries > 2) {
				Choice1e.SetActive(true); // ChoiceE: Move On (only if 3 batteries already)	
				}
        }

// ENCOUNTER AFTER CHOICE E: Move On
       else if (primeInt == 201){
                Char1name.text = "YOU";
                Char1speech.text = "I’ve got enough power cells already, let’s get this ship running again before it’s too late.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene5Button.SetActive(true);        // Proceed to Generator Return
        }
       
	   
	   
// ENCOUNTER AFTER CHOICE A: Investigate Armory
       else if (primeInt == 30){
			if (GameHandler.armoryAlready == true) {
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The voices continue their hushed argument.";
				Char3name.text = "";
                Char3speech.text = "";	
			}
			else{
                Char1name.text = "YOU";
                Char1speech.text = "Sounds like there's people in there...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
			}
			nextButton.SetActive(false);
            allowSpace = false;
			NextScene1Button.SetActive(true);
        }
		
     }
	 else {                                                               // if you're here, corridorCAlready must be true, and you've been here before!
		if (GameHandler.guardsAlert == true) {							// and oh dear, you've alerted the guards!
			primeInt = primeInt + 1;
			if (primeInt == 1){
                // AudioSource.Play();
			}
			else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You stumble back into the corridor, narrowly avoiding several laser beams. ";
				Char3name.text = "";
                Char3speech.text = "";
			}
		}
		else {                                                      //phew, you didn't alert the guards!
			primeInt = primeInt + 1;
			if (primeInt == 1){
                // AudioSource.Play();
			}
			else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
			}
		}
	 }
}                    // bottom of next function

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You approach the open door.";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
				Choice1d.SetActive(false);
				Choice1e.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You enter the barracks.";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 39;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
				Choice1d.SetActive(false);
				Choice1e.SetActive(false);
        }
		public void Choice1cFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You enter the cargo bay.";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 49;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
				Choice1d.SetActive(false);
				Choice1e.SetActive(false);
        }
		public void Choice1dFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You enter the airlock.";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 59;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
				Choice1d.SetActive(false);
				Choice1e.SetActive(false);
        }
		public void Choice1eFunct(){        // Choice E: Move On
                Char1name.text = "You";
                Char1speech.text = "We don't have time to look around.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 200;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
				Choice1d.SetActive(false);
				Choice1e.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){							// After Choice A:enter armory
			   GameHandler.corridorCAlready = true;
               SceneManager.LoadScene("Scene8a");          
        }
        public void SceneChange2(){                        // After Choice B:proceed to barracks
				GameHandler.corridorCAlready = true;
                SceneManager.LoadScene("Scene8b");
        }
		public void SceneChange3(){							//After Choice C:proceed to cargo
				GameHandler.corridorCAlready = true;
                SceneManager.LoadScene("Scene8c");      
        }
		public void SceneChange4(){							//After Choice D: proceed to airlock
				GameHandler.corridorCAlready = true;
                SceneManager.LoadScene("Scene8d");   
        }
		public void SceneChange5(){                  		// After Choice E: Proceed to generator return (3 batteries)
				GameHandler.corridorCAlready = true;
                SceneManager.LoadScene("Scene9");
        }
}