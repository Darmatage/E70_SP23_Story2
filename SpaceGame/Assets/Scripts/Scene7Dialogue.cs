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
        public GameObject ArtBG1;
		public GameObject ArtBG2;
		public GameObject ArtBG3;
		public GameObject ArtBG4;
        public GameObject Choice1a;             //armory
        public GameObject Choice1b;             // barracks
		public GameObject Choice1c;            // cargo
        public GameObject Choice1d;           // airlock
		public GameObject Choice1e;            // move on
		public GameObject Choice1f;            // post-alert decider
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
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
		Choice1d.SetActive(false);
		Choice1e.SetActive(false);
		Choice1f.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
		NextScene4Button.SetActive(false);
		NextScene5Button.SetActive(false);
        nextButton.SetActive(true);
		if (GameHandler.corridorCAlready == false) {
			ArtBG1.SetActive(true);
			ArtBG2.SetActive(false);
			ArtBG3.SetActive(false);
			ArtBG4.SetActive(false);
		}
		else {
			if (GameHandler.guardsAlert == false) {
			ArtBG2.SetActive(true);
			ArtBG1.SetActive(false);
			ArtBG3.SetActive(false);
			ArtBG4.SetActive(false);
			}
			else {
				if (GameHandler.guardsTension == true) {
					ArtBG4.SetActive(true);
					ArtBG2.SetActive(false);
					ArtBG3.SetActive(false);
					ArtBG1.SetActive(false);
				}
				else {
					ArtBG2.SetActive(true);
					ArtBG1.SetActive(false);
					ArtBG3.SetActive(false);
					ArtBG4.SetActive(false);
				}
			}
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
	if (GameHandler.corridorCAlready == false) {
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You travel through hallways spattered with laser burns. Occasionally, you pass another body.";
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
                ArtBG1.SetActive(false);
				ArtBG2.SetActive(true);
				ArtBG3.SetActive(false);
				ArtBG4.SetActive(false);
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
                NextScene5Button.SetActive(true);        // Proceed to Generator Return(s9), or Corridor B(s5)
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
				nextButton.SetActive(false);
				allowSpace = false;
				NextScene1Button.SetActive(true);				
			}
			else{
                Char1name.text = "YOU";
                Char1speech.text = "Sounds like there's people in there...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
				allowSpace = false;
				NextScene1Button.SetActive(true);
			}
        }
		
     }
	 else {                                                               // if you're here, corridorCAlready must be true, and you've been here before!
		if (GameHandler.guardsAlert == true) {							// and oh dear, you've alerted the guards!
			if (GameHandler.guardsTension == true) {                    // not your first time back!
				primeInt = primeInt + 1;
				if (primeInt == 1){
                // AudioSource.Play();
				}
				else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You return to the corridor. There is a tense silence in the air.";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
				allowSpace = false;
					if (GameHandler.hasScrewdriver == false) {
						Choice1b.SetActive(true);                         // ChoiceB: Investigate Barracks, if you haven't gotten the screwdriver yet
					}
					if (GameHandler.airlockAlready == false) {
						Choice1d.SetActive(true);                             // ChoiceD: Investigate Airlock, if you haven't decided it's not helpful yet.	
					}
					if (GameHandler.armoryCell == false) {
						Choice1c.SetActive(true);                             // ChoiceC: Investigate Cargo, if you haven't retrieved the battery from the armory's back room yet
					}
					if (GameHandler.corridorBAlready == true) {            // if you've already been through the central bottleneck, then you need 3 batts to move on
						if (GameHandler.batteries > 2) {
							Choice1e.SetActive(true); // ChoiceE: Move On
						}
					}
					else {                                                 // but if you haven't seen the midpoint yet, then you only need 1 battery to move on!
						if (GameHandler.batteries > 0) {
							Choice1e.SetActive(true); // ChoiceE: Move On
						}	
					}
				}
				
			}
			else {                                         // The alert just happened! dodge those beams!
				primeInt = primeInt + 1;
				if (primeInt == 1){
                // AudioSource.Play();
				}
				else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You stumble back into the corridor, narrowly avoiding several laser beams.";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You scramble away from the door, losing your footing as you try to run. You fall hard.";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You try to get back to your feet and keep moving, but as you do, you know it's too late.";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You can't fight so many at once, and there's no way you'll make it to the end of the hall before they rush from the room.";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You try to make it anyway, finding your footing and hurrying back the way you came.";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Each second feels like an eternity as you move, expecting the searing pain of a laser beam to hit you at any moment.";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "And yet, it never comes. You nearly make it to the bend in the corridor before riskng a glance back over your shoulder.";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The hallway remains empty, the echoes of the crew's shouts ringing through it.";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 10){
                ArtBG2.SetActive(false);
				ArtBG3.SetActive(true);
				ArtBG1.SetActive(false);
				ArtBG4.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Suddenly a laser beam is fired through the armory door, along with an incomprehensible shout. Smoke curls from the already ruined wall panel as it melts even further.";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 11){
                ArtBG3.SetActive(false);
				ArtBG4.SetActive(true);
				ArtBG1.SetActive(false);
				ArtBG2.SetActive(false);
				Char1name.text = "YOU";
                Char1speech.text = "They're... they're not chasing me.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Assessment: the mutineers are likely unwilling to risk their current stronghold. \n Directive: Continue search.";
				}
				else if (primeInt == 13){
                Char1name.text = "YOU";
                Char1speech.text = "Why would they shoot at me? They have to know the ship can't last much longer like this, I'm only trying to help.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Crew behavior corroborates this unit's earlier assessment of deranged mutiny.";
				}
				else if (primeInt == 15){
                Char1name.text = "YOU";
                Char1speech.text = "Well, whatever's wrong with them, if I let them stop me then we're all dead. Maybe they'll calm down if I can fix things.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 16){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Directive: employ Stealth to continue search.";
				nextButton.SetActive(false);
				allowSpace = false;
				Choice1f.SetActive(true); // ChoiceF: Continue dialogue, dependent on story status
				}
				else if (primeInt == 18){
                Char1name.text = "YOU";
                Char1speech.text = "That being said, I still need that battery from the armory, and I don't think any amount of tip-toeing will get me through that door without them noticing.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Directive: search for alternate route.";
				}
				else if (primeInt == 20){
                Char1name.text = "YOU";
                Char1speech.text = "Hmmm. I guess that's all I can do, really. Good thing I don't have to go by the armory again to look in these other rooms.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				GameHandler.guardsTension = true;
				nextButton.SetActive(false);
				allowSpace = false;
				if (GameHandler.hasScrewdriver == false) {
					Choice1b.SetActive(true);                         // ChoiceB: Investigate Barracks, if you haven't gotten the screwdriver yet
				}
				if (GameHandler.airlockAlready == false) {
					Choice1d.SetActive(true);                             // ChoiceD: Investigate Airlock, if you haven't decided it's not helpful yet.	
				}
				if (GameHandler.armoryCell == false) {
					Choice1c.SetActive(true);                             // ChoiceC: Investigate Cargo, if you haven't retrieved the battery from the armory's back room yet
				}
				}
				else if (primeInt == 26){
					if (GameHandler.corridorBAlready == true) {
						Char1name.text = "YOU";
						Char1speech.text = "Besides, I've got all the power cells I need to re-start the ship.";
						Char2name.text = "";
						Char2speech.text = "";
						Char3name.text = "";
						Char3speech.text = "";
					}
					else {
						Char1name.text = "YOU";
						Char1speech.text = "It's too risky to stick around here anyway. I bet I can sneak past and find what I need elsewhere.";
						Char2name.text = "";
						Char2speech.text = "";
						Char3name.text = "";
						Char3speech.text = "";
					}
				}
				else if (primeInt == 27){
                Char1name.text = "YOU";
                Char1speech.text = "If I can quietly get back towards the armory, I can probably dash past the door before they realize I'm there.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 28){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You make your way back down the hall. The tense silence holds, all traces of the earlier muffled conversation gone.";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 29){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Almost at the armory door, you pause, preparing yourself.";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You step back a moment and then hurl yourself forward, surging past the opening as you sprint down the hall.";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You hear someone shout, and feel heat on your back as a laser punches through the space you occupied a moment before.";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 32){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Legs pumping beneath you, you pelt down the hall, quickly reaching the next turn and hurtling around it.";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 33){
                Char1name.text = "YOU";
                Char1speech.text = "They were waiting for me! Not quick enough though!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				}
				else if (primeInt == 34){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You hurry on, fairly confident that you won't be followed but eager to put some distance between yourself and the crew regardless.";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
				allowSpace = false;
				NextScene5Button.SetActive(true);
				}
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
                Char2speech.text = "You return to the corridor, which is still quiet other than the hushed conversation coming from the armory.";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
				allowSpace = false;
				if (GameHandler.hasScrewdriver == false) {
                Choice1b.SetActive(true);                         // ChoiceB: Investigate Barracks, if you haven't gotten the screwdriver yet
				}
				if (GameHandler.airlockAlready == false) {
				Choice1d.SetActive(true);                             // ChoiceD: Investigate Airlock, if you haven't decided it's not helpful yet.	
				}
				if (GameHandler.armoryCell == false) {
				Choice1c.SetActive(true);                             // ChoiceC: Investigate Cargo, if you haven't retrieved the battery from the armory's back room yet
				}
				if (GameHandler.armoryAlready == false) {
				Choice1a.SetActive(true);                             // ChoiceA: Investigate Armory, if you haven't looked there yet.	
				}
				if (GameHandler.corridorBAlready == true) {            // if you've already been through the central bottleneck, then you need 3 batts to move on
					if (GameHandler.batteries > 2) {
						Choice1e.SetActive(true); // ChoiceE: Move On
					}
				}
				else {                                                 // but if you haven't seen the midpoint yet, then you only need 1 battery to move on!
					if (GameHandler.batteries > 0) {
						Choice1e.SetActive(true); // ChoiceE: Move On
					}	
				}
			}
			else if (primeInt == 30){
					if (GameHandler.armoryAlready == true) {
						Char1name.text = "";
						Char1speech.text = "";
						Char2name.text = "...";
						Char2speech.text = "The voices continue their hushed argument.";
						Char3name.text = "";
						Char3speech.text = "";
						nextButton.SetActive(false);
						allowSpace = false;
						NextScene1Button.SetActive(true);				
					}
					else{
						Char1name.text = "YOU";
						Char1speech.text = "Sounds like there's people in there...";
						Char2name.text = "";
						Char2speech.text = "";
						Char3name.text = "";
						Char3speech.text = "";
						nextButton.SetActive(false);
						allowSpace = false;
						NextScene1Button.SetActive(true);
					}
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
				NextScene2Button.SetActive(true);
        }
		public void Choice1cFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You go toward the cargo bay.";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 49;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
				Choice1d.SetActive(false);
				Choice1e.SetActive(false);
				NextScene3Button.SetActive(true);
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
				NextScene4Button.SetActive(true);
        }
		public void Choice1eFunct(){        // Choice E: Move On
                Char1name.text = "You";
                Char1speech.text = "We don't have any more time to look around.";
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
				NextScene5Button.SetActive(true);
        }
		public void Choice1fFunct(){        // Choice F: After alerting guards, this determines the dialogue that you'll see based on where you are in the story.
                Char1name.text = "YOU";
                Char1speech.text = "You're right, hopefully if I stay quiet they won't realize I'm still out here.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Choice1f.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				if (GameHandler.corridorBAlready == true) {           //already been through midpoint, can only move on if 3 batts already
					if (GameHandler.batteries > 2) {                  // and you have those 3 batts!
						primeInt = 25 ;
					}
					else {                                            //don't have 3 batts yet, keep working on this hall!
						primeInt = 17;	
					}
				}
				else {                                               // haven't been through midpoint yet, thus you only need 1 batt to progress!
					if (GameHandler.batteries > 0) {                 // and you have that 1 batt!
						primeInt = 25 ;	
					}
					else {                                           // no bats yet, gotta get one!
						primeInt = 17;
					}
				}
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
		public void SceneChange5(){                  		// After Choice E: Proceed onward, to generator return (3 batteries) or to Corridor B
				GameHandler.corridorCAlready = true;
				if (GameHandler.corridorBAlready == true) {
                SceneManager.LoadScene("Scene9");
				}
				else {
				SceneManager.LoadScene("Scene5");	
				}
        }
}