using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6cDialogue : MonoBehaviour {
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
        public GameObject Choice1a;                             // TAKE CELLS
        public GameObject Choice1b;                                 // LEAVE
        public GameObject NextScene1Button;
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
            //    ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You slide open the thick double doors, frosty mist immediately slipping through the gap and pooling across the floor.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "Cold in here.";
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
                Char3speech.text = "Temperature readings indicate that the Cryogenic Stasis Chamber remains functional.";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Assessing... \n Power source detected.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
               Char1name.text = "YOU";
                Char1speech.text = "Wait, a lot of these still have people in them!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Cryogenic Stasis enables staggered service periods, allowing for long journeys such as this.";
        }
		else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Teams are removed from stasis to maintain the ship in shifts, while extraneous crew remain suspended.";
        }
		else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Upon arrival in orbit of BFH-9, the active maintenance team re-entered stasis, while the research team awakened.";
        }
		else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Currently, the Captain and research team are the only crew out of stasis.";
        }
		else if (primeInt == 11){
                Char1name.text = "YOU";
                Char1speech.text = "I guess it makes sense then, that this place would have its own emergency power.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 12){
                Char1name.text = "YOU";
                Char1speech.text = "It must be that big machine in the back. In fact, I think I see a couple power cells sticking out of it.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Directive: Retrieve power cells.";
        }
		else if (primeInt == 14){
                Char1name.text = "YOU";
                Char1speech.text = "With those two, we’d have enough to re-start the generator.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 15){
                Char1name.text = "YOU";
                Char1speech.text = "But… then the cryo bays would lose power.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 16){
                Char1name.text = "YOU";
                Char1speech.text = "Could we wake everyone first? No, it takes a long time to come out of suspended animation.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 17){
                Char1name.text = "YOU";
                Char1speech.text = "We don’t have that time right now. But if we just take the power cells, there’s no way that will end well for everyone still frozen.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 18){
                Char1name.text = "YOU";
                Char1speech.text = "I don’t want those lives on my hands.";
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
                Char3speech.text = "Once restored, the Orpheus’ power grid should be sufficient to maintain the stasis bays.";
        }
		else if (primeInt == 20){
                Char1name.text = "YOU";
                Char1speech.text = "Maybe, but what if the lapse in power is too long? And that’s assuming that the portion of the grid that connects to this chamber is uncompromised.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 21){
                Char1name.text = "YOU";
                Char1speech.text = "People have been shooting in the corridors, the network could be damaged.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "The situation demands decisive action. Failure to restore power endangers the lives of all aboard.";
        }
       else if (primeInt == 23){
                Char1name.text = "YOU";
                Char1speech.text = "I don't know...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // TAKE CELLS
                Choice1b.SetActive(true); // LEAVE
        }

													// ENCOUNTER AFTER CHOICE 1b
       else if (primeInt == 101){
                Char1name.text = "YOU";
                Char1speech.text = "There have to be more cells we can find somewhere.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }

       else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You return to the hallway.";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
		else if (primeInt == 51){
                Char1name.text = "YOU";
                Char1speech.text = "If I return to the generator room immediately and get these plugged in, the cryo chamber should only be without power for a few minutes.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 52){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You walk through the misty room, coming to a stop before the central console. It emits a low, droning hum.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 53){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You give one cell a tug, but it remains solidly in place.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 54){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "A firm twist disengages the locking mechanism, and you withdraw the cell as the machine’s hum sputters, warnings flashing across the display panels.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 55){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You slot the power cell into your array, and move on to the next one.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 56){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "It pulls free just like the first, the machine’s lights fading along with its hum.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 57){
                Char1name.text = "YOU";
                Char1speech.text = "Time to move, we don’t have long.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 58){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You make your way back to the door, your footsteps echoing loudly through the mist of the now-quiet chamber.";
				Char3name.text = "";
                Char3speech.text = "";
				GameHandler.cryoCells = true;
				GameHandler.batteries = GameHandler.batteries + 2;
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
     }                                                       // END OF NEXT FUNCTION

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){                                      // TAKE EM
                Char1name.text = "YOU";
                Char1speech.text = "Maybe you’re right. It’s a risk that must be taken.";
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
        public void Choice1bFunct(){                               // LEAVE
                Char1name.text = "YOU";
                Char1speech.text = "No, it’s too risky. We need the rest of the crew to get back to earth.";
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

        public void SceneChange1(){
				GameHandler.cryoAlready = true;
                audioSource.Play();    
                StartCoroutine(SceneChangeDelay("Scene5"));
        }

		IEnumerator SceneChangeDelay(string newScene){
			yield return new WaitForSeconds(1f);
			SceneManager.LoadScene(newScene);
		}
		
		
}