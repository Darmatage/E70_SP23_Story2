using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene8eDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		public Text Char3name;
		public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
		public GameObject ArtChar2;
		public GameObject ArtChar3;
		public GameObject ArtChar4;
		public GameObject ArtChar5;
		public GameObject ArtChar6;
        public GameObject ArtBG1;
		public GameObject ArtBG2;
		public GameObject ArtBG3;
		public GameObject ArtBG4;
		public GameObject ArtBG5;
		public GameObject ArtBG6;
        public GameObject NextScene1Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtChar3.SetActive(false);
		ArtChar4.SetActive(false);
		ArtChar5.SetActive(false);
		ArtChar6.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
		ArtBG4.SetActive(false);
		ArtBG5.SetActive(false);
		ArtBG6.SetActive(false);
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
                Char2speech.text = "You shimmy through the narrow ventilation shaft, trying not to make too much noise.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                
				Char1name.text = "YOU";
                Char1speech.text = "Phew, warm in here. Luckily, it can't be that far to the grate in the armory.";
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
                Char2speech.text = "You climb around a few tight turns before finding yourself facing a metal grate like the one you just came through.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "Oh, please don't be screwed shut...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
               Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You give the grate a careful prod.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "Thank goodness. Some kind of fastener clip. I'll just take these off...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==8){
                ArtBG3.SetActive(true);
				ArtBG2.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The grate comes loose in your hands, and you set it aside as you gingerly crawl through the new opening.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Power source detected.";
        }
		else if (primeInt ==10){
                ArtBG4.SetActive(true);
				ArtBG3.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You open your mouth to respond, but you stop yourself as you take in the space you're crawling into.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You're on the floor between a couple boxes. By the sound of voices coming through the open doorway of this small room, this must be the back room of the armory.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The boxes give you some cover as you right yourself and peer over them. You can see several crewmembers in the larger room beyond the doorway.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Thankfully, none of them seem to be paying attention to the back room.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Power source detected. \n Directive: Retrieve power cell.";
        }
		else if (primeInt ==15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You suppress an annoyed response to the AI's obvious statement, looking around the room.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==16){
				ArtChar1.SetActive(true);
                ArtBG5.SetActive(true);
				ArtBG4.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "And there is is. Against the back wall of the small room sits a charging rack for the laser rifles held by the crew.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "For a moment you entertain the idea of attempting to communicate with them, but you push it aside.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==18){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You're about to have what you need. Better not to risk complications.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The cell is slotted into a mercifully simple port on the side of the charging rack.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==20){
                ArtChar1.SetActive(false);
				ArtChar2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You take hold of the exposed end, clenching the handle tight as you begin withdrawing it.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==21){
                ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You move agonizingly slowly to avoid making noise.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==22){
                ArtChar3.SetActive(false);
				ArtChar4.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "All the while, you keep an ear aimed at the door behind you, waiting for any change in the muffled conversation happening in the other room.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==23){
                ArtChar4.SetActive(false);
				ArtChar5.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Your luck holds. Finally, the full weight of the cell settles into your hands as the last few inches pull free.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt ==24){
                ArtChar5.SetActive(false);
				ArtChar6.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Power cell retrieved. \n Directive: Continue on.";
        }
		else if (primeInt ==25){
                ArtChar6.SetActive(false);
				ArtBG4.SetActive(true);
				ArtBG5.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You hold back a sigh as you nestle the cell into your battery array and turn back toward the grate you came through.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 26){
				ArtBG6.SetActive(true);
				ArtBG4.SetActive(false);
			    Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The journey through the cramped space is easier the second time around, and you soon find yourself crawling out into the cargo bay and returning to the corridor.";
				Char3name.text = "";
                Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
       

        public void SceneChange1(){
				GameHandler.batteries = GameHandler.batteries + 1;
				GameHandler.armoryCell = true;
				SceneManager.LoadScene("Scene7");
        }
}