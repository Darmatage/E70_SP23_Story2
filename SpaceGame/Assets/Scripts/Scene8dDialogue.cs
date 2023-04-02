using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene8dDialogue : MonoBehaviour {
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
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
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
                Char1name.text = "YOU";
                Char1speech.text = "I'm not sure if we'll find what we need here, but it's worth a look I suppose.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Power source detected.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "Huh, I guess the airlock is important enough to have its own power too.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "Look at this cell though. It's not just slotted into a port, it looks hardwired in there.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
				Char1name.text = "YOU";
                Char1speech.text = "I'm not sure I could get this disconnected safely, even with all the time and tools in the universe.";
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
                Char3speech.text = "Directive: Retrieve power cell.";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // try to take cell
                Choice1b.SetActive(true); // leave
        }

// ENCOUNTER AFTER CHOICE B
       else if (primeInt == 11){
                Char1name.text = "YOU";
                Char1speech.text = "If we're going to save the ship in time, we'll have to find what we need elsewhere.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 15){
                Char1name.text = "YOU";
                Char1speech.text = "So many wires.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 16){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You do your best to understand the complex network of connections, but it's not easy.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "To make matters worse, the connections seem to have been locked in with some kind of specialized tool - you can't find a way to unplug anything by hand.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 18){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You try yanking anything that looks promising, but nothing works.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Absorbed by the puzzle, you lose track of time until a faint noise behind you catches your attention.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 20){
                Char1name.text = "YOU";
                Char1speech.text = "What was that?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You spin around just in time to see the airlock being sealed behind you.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Through the window in the door, you can see a crewmate on the other side.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 23){
                Char1name.text = "YOU";
                Char1speech.text = "Hey! Let me out!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "They say something, but it's inaudible through the thick door. You try banging on it.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 25){
                Char1name.text = "YOU";
                Char1speech.text = "Let me out! I can help you!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 26){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "An alarm sounds as the airlock begins cycling.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 27){
                Char1name.text = "YOU";
                Char1speech.text = "Don't! Let-";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 28){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You are thrown back as the outer doors open, tumbling into the cold void as the air in the room decompresses.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 29){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You will not survive.";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Sorry, but this one just isn't going to work.";
                Char2name.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 10;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I guess I can try...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 14;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){                                    // leave
				GameHandler.airlockAlready = true;
				SceneManager.LoadScene("Scene7");
        }
        public void SceneChange2(){                         // game over
				GameHandler.airlockAlready = true;
                SceneManager.LoadScene("End_Ejected");
        }
}