using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6aDialogue : MonoBehaviour {
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
        public GameObject ArtChar1;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;           // talk
        public GameObject Choice1b;               // shoot
		public GameObject Choice1c;             //vent
		public GameObject Choice1d;             //work
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       public AudioSource audioSource;
	   public AudioSource audioSourceLaser;
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
                Char2name.text = "...";
                Char2speech.text = "As you open the medbay door, you are met by the sound of cloth rustling, items tumbling about within boxes - the sound of rummaging.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Power source detected.";
				Char4name.text = "";
                Char4speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Peering through the half-open door reveals a figure, crouched between rows of empty cots.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Mutineer detected. Proceed with caution.";
				Char4name.text = "";
                Char4speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
               Char1name.text = "YOU";
                Char1speech.text = "I don’t recognize him either. But look how he’s dressed, I think that’s the doctor.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "You think he's a part of this too?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Assessment: Probable.";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 9){
                Char1name.text = "YOU";
                Char1speech.text = "Hmm. He seems pretty frantic.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 10){
                Char1name.text = "YOU";
                Char1speech.text = "But if there’s a power cell in here, we need it. Maybe I can talk to him.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You open the door fully, taking a few steps inside. The doctor doesn’t seem to notice you.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 12){
                Char1name.text = "YOU";
                Char1speech.text = "Hello?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The doctor shoots upright, a bundle of items tumbling from his arms.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "His eyes go wide as he sees you, hands fumbling with something within his coat.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "DOCTOR";
                Char4speech.text = "Y-you! Stay back!";
        }
		else if (primeInt == 16){
                Char1name.text = "YOU";
                Char1speech.text = "Calm down. I’m just trying to- whoah!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The doctor pulls a pistol from within his coat, the barrel swinging toward you as he struggles with the safety for a moment.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
				Choice1a.SetActive(true);
				if (GameHandler.capsGun == true) {
				Choice1b.SetActive(true);
				}
        }
		else if (primeInt == 21){                      // you chose to talk
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The doctor finally manages to flip the switch, letting loose an enraged shout as a laser sears through your body.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Your words die on your lips as you crumple backward.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene2Button.SetActive(false);
        }
       else if (primeInt == 101){                            // you chose to shoot
                Char1name.text = ""; 
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The doctor finally manages to flip the switch, but his shot goes wide as yours catches him squarely in the chest.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 102){                     
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "His gun blazes a line across the ceiling as he falls back, finally shutting off as the fall knocks it from his twitching hand.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 103){                     
                Char1name.text = "YOU";
                Char1speech.text = "Damn it...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 104){                     
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You approach the prone figure as his last breath rattles free.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 105){                     
                Char1name.text = "YOU";
                Char1speech.text = "I didn’t want to do that, but there wasn’t much of a choice! Why was he so intent on shooting me?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 106){                     
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Power source detected. Directive: Retrieve power cell.";
				Char4name.text = "";
                Char4speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
				Choice1c.SetActive(true);              //vent
				Choice1d.SetActive(true);              //work
        }
		else if (primeInt == 110){                 //you're working.       
                Char1name.text = "YOU";
                Char1speech.text = "Just gotta keep moving… Gotta save the ship.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 111){                            
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You look around the now-quiet room. The diagnostic equipment is still online, and the refrigerated medicine box glows faintly.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 112){                            
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "It doesn’t take you long to find the source: a power cell, slotted into a generator in the corner.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 113){                            
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "It pulls free without much trouble, and you slot it into your array.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 114){                            
                Char1name.text = "YOU";
                Char1speech.text = "Time to go. Nothing left for us here.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 115){                            
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You leave the med-bay, shutting the door behind you.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
        }
		else if (primeInt == 151){               //you're venting.                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "A necessary procedure. Completion of your objective is paramount.";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 152){                     
                Char1name.text = "YOU";
                Char1speech.text = "Somehow, that doesn’t make me feel much better…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 153){                     
                Char1name.text = "YOU";
                Char1speech.text = "How am I going to explain this? I just shot a doctor!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 154){                     
                Char1name.text = "YOU";
                Char1speech.text = "Yes, he was trying to do the same to me, but I don’t even know why!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 155){                     
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "The objective takes precedence over all other concerns. The fate of this vessel hinges upon you restoring power.";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 156){                     
                Char1name.text = "YOU";
                Char1speech.text = "Even if that explanation satisfies others, it doesn’t do much for me.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 157){                     
                Char1name.text = "YOU";
                Char1speech.text = "There has to have been a better way…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 158){                     
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "H.O.R.I.Z.O.N.";
                Char3speech.text = "Emergency power reserves critically low. Restore main power immediately.";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 159){                     
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 160){                     
                Char1name.text = "YOU";
                Char1speech.text = "Just gotta keep moving… Gotta save the ship.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 161){                            
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You look around the now-quiet room. The diagnostic equipment is still online, and the refrigerated medicine box glows faintly.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 162){                            
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "It doesn’t take you long to find the source: a power cell, slotted into a generator in the corner.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 163){                            
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "It pulls free without much trouble, and you slot it into your array.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 164){                            
                Char1name.text = "YOU";
                Char1speech.text = "Time to go. Nothing left for us here.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 165){                            
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You leave the med-bay, shutting the door behind you.";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
        }
     }                                                       // END OF NEXT FUNCTION

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){                          // talk
                Char1name.text = "YOU";
                Char1speech.text = "Please, listen! I'm not going to-";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 20;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){                       // shoot
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "Your reflex is nearly automatic. As the doctor raises his weapon, your hand closes on the grip of the Captain's gun.";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 100;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1cFunct(){                       // vent
                Char1name.text = "YOU";
                Char1speech.text = "I just killed someone!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 150;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1dFunct(){                       // work
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You push aside your internal tumult, focusing on the task at hand.";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 109;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){                           // leave
				GameHandler.medbayAlready = true;
				GameHandler.batteries = GameHandler.batteries + 1;
			   audioSource.Play();    
                StartCoroutine(SceneChangeDelay("Scene5"));   
        }
		
        public void SceneChange2(){                 		//DEATH
		        audioSourceLaser.Play();    
                StartCoroutine(SceneChangeDelay("End_LoseBlood"));
        }

		IEnumerator SceneChangeDelay(string newScene){
			yield return new WaitForSeconds(1f);
			SceneManager.LoadScene(newScene);
		}
}