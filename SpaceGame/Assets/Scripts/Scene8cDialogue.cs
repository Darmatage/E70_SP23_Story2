using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene8cDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		public Text Char3name;
		public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject VentArt;
        public GameObject TubeArt;
        public GameObject ArtBG1;
        public GameObject Choice1a;                   //CHOICE 1a: Search crates
        public GameObject Choice1b;					//CHOICE 1B: Search Shaft
		public GameObject Choice1c;					//CHOICE 1C: leave crates
		public GameObject Choice1d;					//CHOICE 1D: leave room
        public GameObject NextScene1Button;          //enter vents
        public GameObject NextScene2Button;           // leave room
        public GameObject nextButton;
       //public GameHandler gameHandler;
       public AudioSource audioVentOpen;
       public AudioSource audioDoor;
       
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        VentArt.SetActive(false);
		TubeArt.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
		Choice1d.SetActive(false);
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
	if (GameHandler.cargoAlready == false) {
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "The Cargo Bay appears undisturbed. Regardless, proceed with caution.";
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "This place is big. I wonder how long it would take to search.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Assessing... \n Unknown.";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "There are options for investigation.";
        }
       else if (primeInt == 6){
               Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "You could search the crates for supplies.";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // search crates
				if (GameHandler.armoryAlready == true) {
                Choice1b.SetActive(true); // search shaft
				}
				if (GameHandler.hasScrewdriver == true) {
                Choice1b.SetActive(true); // search shaft
				}
        }

// ENCOUNTER AFTER CHOICE #1 - crates
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "The most effective way to determine that would be to search them.";
        }
		else if (primeInt == 12){
                Char1name.text = "YOU";
                Char1speech.text = "Was that sass?";
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
                Char3speech.text = "This unit is incapable of 'sass'.";
        }
		else if (primeInt == 14){
                Char1name.text = "YOU";
                Char1speech.text = "Right.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 15){
				TubeArt.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Anyway, I've got one open. What's in these tubes?";
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
                Char3speech.text = "Those tubes appear to contain Quasarite. This material is converted to energy by the generator, allowing the ship to move.";
        }
		else if (primeInt == 17){
                Char1name.text = "YOU";
                Char1speech.text = "Can we use it to re-start the generator?";
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
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Negative. The process requires an external power source.";
        }
		else if (primeInt == 19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "The generator will not re-start without the battery array.";
        }
		else if (primeInt == 20){
                Char1name.text = "YOU";
                Char1speech.text = "Then I'm wasting time here.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				GameHandler.cratesAlready = true;
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1c.SetActive(true); // leave crates
        }
		else if (primeInt == 30){             					// you've left the crates!
                TubeArt.SetActive(false);
				Char1name.text = "YOU";
                Char1speech.text = "Hmm...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
				if (GameHandler.armoryAlready == true) {
				Choice1b.SetActive(true); // investigate vent
				}
				if (GameHandler.hasScrewdriver == true) {
                Choice1b.SetActive(true); // search shaft
				}
				Choice1d.SetActive(true); // leave room
        }
		else if (primeInt == 41){              // you're investigating the shaft, and you have the screwdriver!
                if (GameHandler.armoryAlready == true) {
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "The ventilation shaft likely connects to the rear of the armory.";
				}
				else {
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "The ventilation shaft may be useful for navigating the ship.";	
				}
        }
		else if (primeInt == 42){              
                Char1name.text = "YOU";
                Char1speech.text = "Looks big enough for me to slip through. Let's see about getting this grate open...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 43){              
                Char1name.text = "YOU";
                Char1speech.text = "Good thing I found this screwdriver!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 44){              
                VentArt.SetActive(true);
                audioVentOpen.Play();
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The screws holding the grate in place are quite stiff, but no match for your new tool. The metal sheet clangs to the floor a moment later.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 45){              
                if (GameHandler.armoryAlready == true) {
				Char1name.text = "YOU";
                Char1speech.text = "If I crawl quietly, they won't even know I'm there. Probably.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				GameHandler.ventAlready = true;
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);     // on to the rear armory!
				}
				else {
				Char1name.text = "YOU";
                Char1speech.text = "Here goes nothing.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				GameHandler.ventAlready = true;
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);     // on to the rear armory!	
				}
		}
		else if (primeInt == 61){                 // you at the grate, no screwdriver tho! rekt
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "The ventilation shaft likely connects to the rear of the armory.";
        }
		else if (primeInt == 62){ 
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The screws holding the grate in place are a bit rusty.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 63){    
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You fiddle with them for a moment, but they're quite stiff. There's no way to turn them with your bare hands.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 64){    
                Char1name.text = "YOU";
                Char1speech.text = "...crap.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 65){    
                Char1name.text = "YOU";
                Char1speech.text = "Maybe I can find another way.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				GameHandler.ventAlready = true;
				nextButton.SetActive(false);
                allowSpace = false;
				Choice1d.SetActive(true); // leave room
        }
       
	}
	else {                                                      // it's not your first time here!
		primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You return to the cargo bay.";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
				Choice1d.SetActive(true); // leave room
				Choice1b.SetActive(true); // investigate vent
				if (GameHandler.cratesAlready == false) {
					Choice1a.SetActive(true); // search crates
				}
        }
		// ENCOUNTER AFTER CHOICE #1 - crates
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "The most effective way to determine that would be to search them.";
        }
		else if (primeInt == 12){
                Char1name.text = "YOU";
                Char1speech.text = "Was that sass?";
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
                Char3speech.text = "This unit is incapable of 'sass'.";
        }
		else if (primeInt == 14){
                Char1name.text = "YOU";
                Char1speech.text = "Right.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 15){
				TubeArt.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Anyway, I've got one open. What's in these tubes?";
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
                Char3speech.text = "Those tubes appear to contain Quasarite. This material is converted to energy by the generator, allowing the ship to move.";
        }
		else if (primeInt == 17){
                Char1name.text = "YOU";
                Char1speech.text = "Can we use it to re-start the generator?";
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
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Negative. The process requires an external power source.";
        }
		else if (primeInt == 19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "The generator will not re-start without the battery array.";
        }
		else if (primeInt == 20){
                Char1name.text = "YOU";
                Char1speech.text = "Then I'm wasting time here.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				GameHandler.cratesAlready = true;
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1c.SetActive(true); // leave crates
        }
		else if (primeInt == 30){             					// you've left the crates!
                TubeArt.SetActive(false);
				Char1name.text = "YOU";
                Char1speech.text = "Hmm...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
				if (GameHandler.armoryAlready == true) {
				Choice1b.SetActive(true); // investigate vent
				}
				if (GameHandler.hasScrewdriver == true) {
                Choice1b.SetActive(true); // search shaft
				}
				Choice1d.SetActive(true); // leave room
        }
		else if (primeInt == 41){              // you're investigating the shaft, and you have the screwdriver!
                if (GameHandler.armoryAlready == true) {
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "The ventilation shaft likely connects to the rear of the armory.";
				}
				else {
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "The ventilation shaft may be useful for navigating the ship.";	
				}
        }
		else if (primeInt == 42){              
                Char1name.text = "YOU";
                Char1speech.text = "Looks big enough for me to slip through. Let's see about getting this grate open...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 43){              
                Char1name.text = "YOU";
                Char1speech.text = "Good thing I found this screwdriver!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 44){              
                audioVentOpen.Play();
				VentArt.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The screws holding the grate in place are quite stiff, but no match for your new tool. The metal sheet clangs to the floor a moment later.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 45){              
					if (GameHandler.armoryAlready == true) {
						Char1name.text = "YOU";
						Char1speech.text = "If I crawl quietly, they won't even know I'm there. Probably.";
						Char2name.text = "";
						Char2speech.text = "";
						Char3name.text = "";
						Char3speech.text = "";
						GameHandler.ventAlready = true;
						nextButton.SetActive(false);
						allowSpace = false;
						NextScene1Button.SetActive(true);     // on to the rear armory!
					}
					else {
					Char1name.text = "YOU";
					Char1speech.text = "Here goes nothing.";
					Char2name.text = "";
					Char2speech.text = "";
					Char3name.text = "";
					Char3speech.text = "";	
					GameHandler.ventAlready = true;
					nextButton.SetActive(false);
					allowSpace = false;
					NextScene1Button.SetActive(true);     // on to the rear armory!
				}
		}
		else if (primeInt == 61){                 // you at the grate, no screwdriver tho! rekt
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "The ventilation shaft likely connects to the rear of the armory.";
        }
		else if (primeInt == 62){ 
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The screws holding the grate in place are a bit rusty.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 63){    
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You fiddle with them for a moment, but they're quite stiff. There's no way to turn them with your bare hands.";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 64){    
                Char1name.text = "YOU";
                Char1speech.text = "...crap.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		else if (primeInt == 65){    
                Char1name.text = "YOU";
                Char1speech.text = "Maybe I can find another way.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				GameHandler.ventAlready = true;
				nextButton.SetActive(false);
                allowSpace = false;
				Choice1d.SetActive(true); // leave room
        }
	}
}                             //end of Next function

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){                                  // search crates
                Char1name.text = "YOU";
                Char1speech.text = "What's in the crates?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 10;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
		
		
		
		
        public void Choice1bFunct(){                             // investigate vent
			if (GameHandler.armoryAlready == true) {               // you already saw the armory
				if (GameHandler.hasScrewdriver == true) {
					Char1name.text = "YOU";
					Char1speech.text = "I wonder...";
					Char2name.text = "";
					Char2speech.text = "";
					Char3name.text = "";
					Char3speech.text = "";
					primeInt = 40;
					Choice1a.SetActive(false);
					Choice1b.SetActive(false);
					Choice1c.SetActive(false);
					Choice1d.SetActive(false);
					nextButton.SetActive(true);
					allowSpace = true;
				}
				else {                                       // no screwdriver? :^(
					Char1name.text = "YOU";
					Char1speech.text = "Hmm...";
					Char2name.text = "";
					Char2speech.text = "";
					Char3name.text = "";
					Char3speech.text = "";
					primeInt = 60;
					Choice1a.SetActive(false);
					Choice1b.SetActive(false);
					Choice1c.SetActive(false);
					Choice1d.SetActive(false);
					nextButton.SetActive(true);
					allowSpace = true;
				}
			}
			else {                                          // you haven't seen the armory!
				if (GameHandler.hasScrewdriver == true) {
				Char1name.text = "YOU";
				Char1speech.text = "Hm...";
				Char2name.text = "";
				Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				primeInt = 40;
				Choice1a.SetActive(false);
				Choice1b.SetActive(false);
				Choice1c.SetActive(false);
				Choice1d.SetActive(false);
				nextButton.SetActive(true);
				allowSpace = true;
				}
				else {                             // no armory, no screwdriver
				Char1name.text = "YOU";
				Char1speech.text = "Pretty big grate. Must be good for airflow. Not much help to me right now though.";
				Char2name.text = "";
				Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				primeInt = 200;
				Choice1a.SetActive(false);
				Choice1b.SetActive(false);
				Choice1c.SetActive(false);
				Choice1d.SetActive(true);	
				}
			}
        }
		
		
		
		
		
		public void Choice1cFunct(){                                  // leave crates
                Char1name.text = "YOU";
                Char1speech.text = "Let's look elsewhere.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 29;
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1dFunct(){                                  // leave room
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You turn to leave the room.";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 300;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
				Choice1d.SetActive(false);
				NextScene2Button.SetActive(true);
        }

        public void SceneChange1(){                     // into the vents!
			 GameHandler.cargoAlready = true;
             SceneManager.LoadScene("Scene8e");         
        }
        public void SceneChange2(){                 // back to corridor
				GameHandler.cargoAlready = true;
                // SceneManager.LoadScene("Scene7");
                audioDoor.Play();    
               StartCoroutine(SceneChangeDelay("Scene7"));         
        }

        IEnumerator SceneChangeDelay(string newScene){
			yield return new WaitForSeconds(2f);
			SceneManager.LoadScene(newScene);
		} 
}