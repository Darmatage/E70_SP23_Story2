using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
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
               ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "HORIZON";
                Char2speech.text = "Warning. Fire detected. Hazardous conditions likely.";
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "What's causing the fire?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "HORIZON";
                Char2speech.text = "Preliminary analysis suggests weapons damage.";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "HORIZON";
                Char2speech.text = "This would be consistent with visible damage";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "HORIZON";
                Char2speech.text = "to walls and floor, as well as two bodies on the floor.";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "Oh no, two more dead crew.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		       else if (primeInt ==8){
                Char1name.text = "YOU";
                Char1speech.text = "I don't recognize these either. Who are they?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		       else if (primeInt ==9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "HORIZON";
                Char2speech.text = "Data library offline. Restart generator to restore access.";
        }
		       else if (primeInt ==10){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah, I'm working on it. What do these doors lead to?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "HORIZON";
                Char2speech.text = "Available paths are to the air lock, the med bay, and the captain's quarters.";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true); // function Load Scene5a()
                NextScene2Button.SetActive(true); // function Load Scene5b()
				NextScene3Button.SetActive(true); // function Load Scene5c() 
				
        }
	}
}