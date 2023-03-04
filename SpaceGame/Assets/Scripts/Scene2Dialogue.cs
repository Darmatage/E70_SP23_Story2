using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        
		public GameObject ArtChar1a;
        public GameObject ArtChar1b;
	    public GameObject ArtEngine;
        
		public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		public GameObject NextScene3Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtEngine.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
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
        primeInt += 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                ArtEngine.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GEN. ROOM";
                Char2speech.text = "You awaken in a darkened room as your eyes struggle to adjust to the dim light filtering in through the damaged walls.";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GEN. ROOM";
                Char2speech.text = "You have no memory of how you got here, but the sight before you leaves little doubt that something terrible has happened.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GEN. ROOM";
                Char2speech.text = "The room is in shambles, with gaping holes in the walls and scorch marks on the floor";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GEN. ROOM";
                Char2speech.text = "You look to the source of the ship's power - the generator.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GEN. ROOM";
                Char2speech.text = "It's clear that it has been sabotaged, with wires and circuitry hanging haphazardly from the exposed machinery.";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GEN. ROOM";
                Char2speech.text = "But nothing looks damaged, just pulled out of place. Perhaps you could repair it?";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "GEN. ROOM";
                Char2speech.text = "You walk to the back, to find the battery.";
        }
		
		else if (primeInt ==9){
			 ArtEngine.SetActive(false);
			 ArtChar1a.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Is that a dead body?";
                Char2name.text = "";
                Char2speech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()  Button: "Investigate the body"
                Choice1b.SetActive(true); // function Choice1bFunct()  Button: "Look somewhere else"
        }
		
		
		// after CHOICE #1a:
		else if (primeInt == 20){
			 ArtEngine.SetActive(false);
			 ArtChar1a.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Ugh. I hate how corpes in space just float.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AI";
                Char2speech.text = "Can you tell who it is?";
        }
		       else if (primeInt == 22){
                Char1name.text = "YOU";
                Char1speech.text = "I don't recognize him. He's got a beard?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		       else if (primeInt == 23){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AI";
                Char2speech.text = "Oh, no! That's Bobby, our engineer!";
        }
		 else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AI";
                Char2speech.text = "He always took such good care of me.";
        }		

       else if (primeInt == 25){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AI";
                Char2speech.text = "Plase move the body to see the status of the battery";
        }
		 else if (primeInt == 26){
			 ArtChar1a.SetActive(false);
			 ArtChar1a.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "OK. I am at the battery array console. It's been wrecked by laser fire? ";
                Char2name.text = "";
                Char2speech.text = "";
        }		

       else if (primeInt == 27){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AI";
                Char2speech.text = "We need to find replacement batteries.";
				primeInt = 39;
        }		
		

		// after CHOICE #1b:
       else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AI";
                Char2speech.text = "Well, we could try to start the engine without chcking the batteries...?";
        }
       else if (primeInt == 31){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah. Lert's do that.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 32){
			ArtChar1a.SetActive(false);
			ArtEngine.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "OK. I am back at the engine. \n Wow, it's pretty lasered, too.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 33){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AI";
                Char2speech.text = "Try firing it up from the battery array. the red button";
        }
		else if (primeInt == 34){
                Char1name.text = "YOU";
                Char1speech.text = "I'm pressing it. Nothign is happening.";
                Char2name.text = "";
                Char2speech.text = "";
        }
			else if (primeInt == 35){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AI";
                Char2speech.text = "(...)";
        }
		else if (primeInt == 36){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AI";
                Char2speech.text = "I'm going to need you to move a body.";
				primeInt = 19;
        }

		//after cstory hoices
       else if (primeInt == 40){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AI";
                Char2speech.text = "To fix the battery array we need 3 batteries";
        }
		
		else if (primeInt == 41){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "AI";
                Char2speech.text = "We have " + GameHandler.batteries + " so far.";
        }
		
		else if (primeInt == 42){
                Char1name.text = "YOU";
                Char1speech.text = "Where can I go look?";
                Char2name.text = "";
                Char2speech.text = "";
        }

       else if (primeInt == 43){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				//
                nextButton.SetActive(false);
                allowSpace = false;
				// Turn off "Next" button, turn on "Scene change" buttons
				DialogueDisplay.SetActive(false);
				if (GameHandler.sawCorridorA == false){NextScene1Button.SetActive(true);} // function SceneChange1()  Button: "Search Corridor A"
                if (GameHandler.sawCorridorB == false){NextScene2Button.SetActive(true);} // function SceneChange2()  Button: "Search Corridor B"
				if (GameHandler.sawCorridorC == false){NextScene3Button.SetActive(true);} // function SceneChange3()  Button: "Search Corridor C"
        }

      //Please do NOT delete this MOST HOLY bracket that ends the next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "OK. Checking the battery array. I can do this.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I am not comfortable aroudnd dead bodies. How else can I help?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene3a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3b");
        }
	    public void SceneChange3(){
                SceneManager.LoadScene("Scene3c");
        }	
		
}