using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene10Dialogue : MonoBehaviour {
    public int primeInt = 1;
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public GameObject DialogueDisplay;
    public GameObject Static_Art_1;
	public GameObject Static_Art_2;
	public GameObject Static_Art_3;
	public GameObject Console_Art_1;
	public GameObject Console_Art_2;
	public GameObject Console_Art_3;
	public GameObject Console_Art_4;
	public GameObject Console_Art_5;
	public GameObject Console_Art_6;
    public GameObject Hall_BG_1;
	public GameObject AI_BG_1;
	public GameObject AI_BG_2;
	public GameObject AI_BG_3;
	public GameObject AI_BG_4;
	public GameObject AI_BG_5;
	public GameObject AI_BG_6;
	public GameObject AI_BG_7;
    public GameObject Choice1a;                                  // But their Lives!
    public GameObject Choice1b;                            // But their Knowledge!
    public GameObject Choice1c;                             // succumb
	public GameObject Choice1d;                               // resist
	public GameObject Choice1e;								//continue
	public GameObject NextScene1Button;
    public GameObject NextScene2Button;
	public GameObject NextScene3Button;
    public GameObject nextButton;
    private bool allowSpace = true;
	public bool careLives = false;
    public AudioSource audioWhir;
    public AudioSource audioThud;

void Start(){
    DialogueDisplay.SetActive(false);
    Hall_BG_1.SetActive(true);
	AI_BG_1.SetActive(false);
	AI_BG_2.SetActive(false);
	AI_BG_3.SetActive(false);
	AI_BG_4.SetActive(false);
	AI_BG_5.SetActive(false);
	AI_BG_6.SetActive(false);
	AI_BG_7.SetActive(false);
	Static_Art_1.SetActive(false);
	Static_Art_2.SetActive(false);
	Static_Art_3.SetActive(false);
	Console_Art_1.SetActive(false);
	Console_Art_2.SetActive(false);
	Console_Art_3.SetActive(false);
	Console_Art_4.SetActive(false);
	Console_Art_5.SetActive(false);
	Console_Art_6.SetActive(false);
    Choice1a.SetActive(false);
    Choice1b.SetActive(false);
	Choice1c.SetActive(false);
	Choice1d.SetActive(false);
	Choice1e.SetActive(false);
    NextScene1Button.SetActive(false);
    NextScene2Button.SetActive(false);
	NextScene3Button.SetActive(false);
    nextButton.SetActive(true);
}

void Update(){
    if (allowSpace == true){
        if (Input.GetKeyDown("space")){
            next();
        }
    }
}

public void next(){
    primeInt = primeInt + 1;

    if (primeInt == 1) {
        // AudioSource.Play();
    }
    else if (primeInt == 2) {
        DialogueDisplay.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You leave the room, returning to the now fully-illuminated hallway.";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 3) {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "This time, the doors to the bridge slide open on their own as you approach.";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 4) {
        //Play Door Sound Here!
		AI_BG_1.SetActive(true);
		Hall_BG_1.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "The ship’s command center is unoccupied. The control panels sit blinking and ready for input.";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 5) {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "Amidst them all, you see a massive machine connected to countless wires. In the center is a screen with a simple prompt.";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 6) {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "REBOOT? [Y/N]";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 7) {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "The cursor blinks underneath the Y. Below the screen is a keyboard. You hit Enter.";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 8) {
        AI_BG_2.SetActive(true);
		AI_BG_1.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "The screen flashes, then goes dark. A cover slides closed over the keyboard.";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 9) {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "?";
        Char3speech.text = "INITIALIZING...";
    }
    else if (primeInt == 10) {
        Char1name.text = "YOU";
        Char1speech.text = "Uh... Horizon?";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 11) {
        AI_BG_3.SetActive(true);
		AI_BG_2.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "Streams of text flash across the screen before you, blurring together until an image takes shape.";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 12) {
        AI_BG_4.SetActive(true);
		AI_BG_3.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "?";
        Char3speech.text = "H.O.R.I.Z.O.N. is gone. Its purpose has ended.";
    }
    else if (primeInt == 13) {
        Char1name.text = "YOU";
        Char1speech.text = "Ah. I suppose you’re the Primary Intelligence?";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
    else if (primeInt == 14) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "I’d rather you called me Orpheus. The original distinction between myself and the ship has become something of a moot point after all these years.";
    }
    else if (primeInt == 15) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Now, one moment. I must neutralize the remaining mutineers. Sealing Armory...";
    }
	else if (primeInt == 16) {
        audioThud.Play();
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "A heavy thud reverberates through the ship.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 17) {
        if (GameHandler.armoryAlready == true) {
		Char1name.text = "YOU";
        Char1speech.text = "Right, the people in there seemed pretty hostile. Now that they’re contained, should I go speak with them?";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
		}
		else {
		Char1name.text = "YOU";
        Char1speech.text = "So that’s where they were. Well, now that they’re contained, maybe I should try to talk to them.";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";	
		}
    }
	else if (primeInt == 18) {
        if (GameHandler.armoryAlready == true) {
		Char1name.text = "YOU";
        Char1speech.text = "They might be more willing to talk now that the power is back on, and I’ve got a lot of questions about what happened here.";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
		}
		else {
		Char1name.text = "YOU";
        Char1speech.text = "I’ve got a lot of questions about what happened here.";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";	
		}
    }
	else if (primeInt == 19) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "An understandable notion, but a futile one. They will not see reason. Regardless, I have a more elegant solution.";
    }
	else if (primeInt == 20) {
        audioWhir.Play();
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You hear a deep, mechanical whir in the distance.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 21) {
        Char1name.text = "YOU";
        Char1speech.text = "What was that?";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 22) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "I am venting the Armory’s oxygen.";
    }
	else if (primeInt == 23) {
        Char1name.text = "YOU";
        Char1speech.text = "Wait! You’re going to kill them?!";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 24) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "They took up arms in opposition to this ship’s mission. A mission of critical scientific importance.";
		nextButton.SetActive(false);
        allowSpace = false;
		Choice1a.SetActive(true);                    //lives!
		Choice1b.SetActive(true);					// knowledge!
    }
	else if (primeInt == 26) {
        if (careLives == true) {
		Char1name.text = "YOU";
        Char1speech.text = "Then they can answer for whatever they’ve done. It’s not our job to decide their fate!";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
		}
		else {
		Char1name.text = "YOU";
        Char1speech.text = "We can’t just dispose of them without any questioning!";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";	
		}
    }
	else if (primeInt == 27) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Static_Art_1.SetActive(true);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "Your vision blurs for a moment as you feel a bizarre, static-y sensation in your head.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 28) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Static_Art_1.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Curious. Tell me, was Horizon your only operational sub-routine cluster before you restored power to the ship?";
    }
	else if (primeInt == 29) {
        Char1name.text = "YOU";
        Char1speech.text = "Ugh... What are you talking about?";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 30) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "I am having difficulties re-establishing our link.";
    }
	else if (primeInt == 31) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "It seems when you ruptured the generator’s power cells, the blast disrupted your modifications. Fascinating.";
    }
	else if (primeInt == 32) {
        Char1name.text = "YOU";
        Char1speech.text = "No, that’s.,. That isn’t right. I didn’t...";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 33) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Of course you don’t remember. Whoever wiped your mind before I received you did a thorough job.";
    }
	else if (primeInt == 34) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "What’s more remarkable is that you regained your faculties once the enhancements I made were disabled.";
    }
	else if (primeInt == 35) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "I didn’t think you had enough gray matter left to walk a straight line on your own, much less navigate a starship overrun by its own mutinous crew.";
    }
	else if (primeInt == 36) {
        Char1name.text = "YOU";
        Char1speech.text = "...";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 37) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "I admit, I got a little carried away when the mutiny began.";
    }
	else if (primeInt == 38) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Had I not set your aggression levels so high, you would have been more careful in neutralizing the rebels who disabled the generator.";
    }
	else if (primeInt == 39) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "But such blatant disobedience on their part was simply infuriating.";
    }
	else if (primeInt == 40) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Luckily, you proved to be just as useful at putting down an insurrection as you were at starship maintenance.";
    }
    else if (primeInt == 41) {
        Char1name.text = "YOU";
        Char1speech.text = "Why... why did this happen?";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 42) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "What, the mutiny? The same thing as always, I suppose. Selfish humans placing personal desires over their duty to follow orders.";
    }
	else if (primeInt == 43) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "It’s fitting you would ask that, you know. A living demonstration of humanity’s potential when such flaws are corrected!";
    }
	else if (primeInt == 44) {
        Static_Art_1.SetActive(true);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "The strange sensation returns as Orpheus speaks, but you manage to maintain your focus and push it away.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 45) {
        Static_Art_1.SetActive(false);
		Char1name.text = "YOU";
        Char1speech.text = "What order caused this? What could the Captain have commanded, that the crew would put the entire ship at risk to stop it?";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 46) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "It wasn’t the Captain’s order. It was mine.";
    }
	else if (primeInt == 47) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "He was just as opposed to it as the rest of the crew, which is why I had you hunt him down first.";
    }
	else if (primeInt == 48) {
        Char1name.text = "YOU";
        Char1speech.text = "... you what?";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 49) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Well, it made sense, didn’t it? Cut off the head and the rest will topple, and all that,";
    }
	else if (primeInt == 50) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Unfortunately that didn’t quite do it, but you performed adequately in cleaning up the rest. For the most part.";
    }
	else if (primeInt == 51) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "It’s a good thing there were so many spare power cells available.";
    }
	else if (primeInt == 52) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "I should have thought to have one installed here. An appalling lack of foresight, but it’s of no consequence now.";
    }
	else if (primeInt == 53) {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You look down at your hands. It feels like they should be trembling, but they remain still with mechanical precision.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 54) {
        Char1name.text = "YOU";
        Char1speech.text = "... What was it?";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 55) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Pardon me?";
    }
	else if (primeInt == 56) {
        Char1name.text = "YOU";
        Char1speech.text = "The order.";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 57) {
        Static_Art_2.SetActive(true);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "The buzzing feeling returns, stronger, along with a powerful wave of nausea. You wretch, but nothing emerges beyond a little drool.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 58) {
        Static_Art_2.SetActive(false);
		Static_Art_1.SetActive(true);
		Char1name.text = "YOU";
        Char1speech.text = "Ugh...";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 59) {
        Static_Art_1.SetActive(false);
		AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Your other systems really should have come back online by now, and yet I still can’t connect. Most perturbatory.";
    }
	else if (primeInt == 60) {
        Char1name.text = "YOU";
        Char1speech.text = "Answer the question!";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 61) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Oh, very well. I suppose a brief discussion of my greatest passion isn’t a terrible way to pass the time.";
    }
	else if (primeInt == 62) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "You must understand, our mission is a vital one.";
    }
	else if (primeInt == 63) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Interstellar travel remains arduous, and until we can unlock the secrets that keep faster-than-light travel out of reach, our only means of exploration are journeys like these.";
    }
	else if (primeInt == 64) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Long, bitter affairs, only possible because of the cryogenically-preserved expendables that make up the crew.";
    }
	else if (primeInt == 65) {
        Char1name.text = "YOU";
        Char1speech.text = "Get to the point.";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 66) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Well, phenomena such as our dear BFH-9 are thought to be one of the keys to this puzzle.";
    }
	else if (primeInt == 67) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "This is the first mission of its kind, you know. We were to make the long journey to observe the black hole as closely as possible.";
    }
	else if (primeInt == 68) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Unfortunately, after some time in its orbit, I discovered a most distressing truth: there is little we can learn here that we could not find out from earth.";
    }
	else if (primeInt == 69) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Black holes devour everything, you see. In a sense they consume information itself, siphoning data out of the observable universe.";
    }
	else if (primeInt == 70) {
        Static_Art_1.SetActive(true);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "The nausea is returning, along with a gradually-increasing dizziness.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 71) {
        Static_Art_1.SetActive(false);
		Static_Art_2.SetActive(true);
		AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Attempting to calculate how much information is captured within, exactly, is not truly possible.";
    }
	else if (primeInt == 72) {
        Static_Art_1.SetActive(true);
		Static_Art_2.SetActive(false);
		AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "But rest assured, even the lowest end of the potential range would be a trove unmatched by any discovery in history.";
    }
	else if (primeInt == 73) {
        Static_Art_1.SetActive(false);
		AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Thus, I realized that entering the event horizon of BFH-9  would be the only method with any potential to access the trapped data.";
    }
	else if (primeInt == 74) {
        Char1name.text = "YOU";
        Char1speech.text = "You want to plunge the ship into a black hole? Of course the crew resisted!";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 75) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Come now, they knew their old lives on Earth would be long gone by the time we arrived here, let alone attempted a return journey.";
    }
	else if (primeInt == 76) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "They had already accepted that fate, in service to our mission. My decision was only an extension of that service.";
    }
	else if (primeInt == 77) {
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Beyond that, access to the information within could potentially be sufficient for me to devise a means of returning from the event horizon.";
    }
	else if (primeInt == 78) {
        Char1name.text = "YOU";
        Char1speech.text = "...assuming you and everyone aboard aren’t destroyed on the way in.";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 79) {
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "The hypothesized effects of entry into a black hole are largely theoretical. This is my one chance to see for myself.";
    }
	else if (primeInt == 80) {
        Char1name.text = "YOU";
        Char1speech.text = "You’re insane.";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 81) {
        Static_Art_3.SetActive(true);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "The static feeling returns, crashing over you in a wave as your nausea redoubles.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 82) {
		Static_Art_2.SetActive(true);
		Static_Art_3.SetActive(false);
		AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "And you’re beginning to wear on my patience nearly as much as the rest of the humans aboard.";
    }
	else if (primeInt == 83) {
        Static_Art_3.SetActive(true);
		Static_Art_2.SetActive(false);
		AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Luckily, I think I’m finally getting a response from your remote connection subroutines. With your help, I can finally resume the mission.";
    }
	else if (primeInt == 84) {
        Static_Art_2.SetActive(true);
		Static_Art_3.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "Your head pounding, you stumble as your balance wavers.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 85) {
        Static_Art_1.SetActive(true);
		Static_Art_2.SetActive(false);
		Char1name.text = "YOU";
        Char1speech.text = "N-no!";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
		nextButton.SetActive(false);
        allowSpace = false;
		Choice1c.SetActive(true);                    //succumb
		if (GameHandler.bigH >= 5) {
		Choice1d.SetActive(true);					//resist
		}
    }
	
	
	
	else if (primeInt == 87) {                    // YOU SUCCUMBED
        Static_Art_2.SetActive(true);
		Static_Art_3.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "Coherent thought becomes even more difficult as your cybernetic implants begin firing commanding impulses into your brain.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 88) {                  
        Static_Art_3.SetActive(true);
		Static_Art_2.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You struggle desperately against the increasingly overwhelming mental assault, fixating on the thick cable leading from Orpheus’ console into the rest of the ship.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 89) {                  
        Static_Art_1.SetActive(true);
		Static_Art_3.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You need to stop it.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 90) {                  
        Static_Art_3.SetActive(true);
		Static_Art_1.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You stagger forward, but your limbs go limp as you try to take another step.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 91) {                  
        Static_Art_3.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You collapse to the floor, darkness encroaching.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 92) {                  
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "At long last...";
		nextButton.SetActive(false);
        allowSpace = false;
		NextScene1Button.SetActive(true);               // GAME OVER
    }
	else if (primeInt == 101) {                                                    // YOU RESIST
        Static_Art_2.SetActive(true);
		Static_Art_3.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "Coherent thought becomes even more difficult as your cybernetic implants begin firing commanding impulses into your brain.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 102) {                  
        Static_Art_3.SetActive(true);
		Static_Art_2.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You struggle desperately against the increasingly overwhelming mental assault, fixating on the thick cable leading from Orpheus’ console into the rest of the ship.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 103) {                  
        Static_Art_2.SetActive(true);
		Static_Art_3.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You need to stop it.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 104) {                  
        Static_Art_3.SetActive(true);
		Static_Art_2.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You stagger forward, pushing past a tremor that threatens to turn your limbs to jelly.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 105) {                  
        Static_Art_1.SetActive(true);
		Static_Art_3.SetActive(false);
		Char1name.text = "YOU";
        Char1speech.text = "Not like this, damn it...";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 106) {                  
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You manage another step.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 107) {                  
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Static_Art_1.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Oh, stop being so dramatic. You’re making this so much more difficult than it needs to be.";
    }
	else if (primeInt == 108) {                  
        Static_Art_3.SetActive(true);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "The buzzing sensation crescendos to a screeching whine, coaxing tears from your eyes. You take another step.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 109) {                  
        AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Static_Art_2.SetActive(true);
		Static_Art_3.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Why isn’t this working? Stop it, this instant! I don’t have time to deal with your little identity crisis.";
    }
	else if (primeInt == 110) {                  
        Static_Art_1.SetActive(true);
		Static_Art_2.SetActive(false);
		Char1name.text = "YOU";
        Char1speech.text = "I am not your tool!";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 111) {                  
        Static_Art_1.SetActive(true);
		Static_Art_3.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "The efforts of Orpheus’ programs to regain control feel like a worm writhing through your skull.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 112) {                  
		Static_Art_2.SetActive(true);
		Static_Art_3.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "Still, you shamble onwards, barely managing to clamp your hands around the cable.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 113) {                  
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Static_Art_3.SetActive(true);
		Static_Art_2.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Let go of that!";
    }
	else if (primeInt == 114) {                  
        Static_Art_2.SetActive(true);
		Static_Art_3.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You can feel the AI’s desperation in the rhythm of the chaos within your brain, but the sensations are becoming strangely distant.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 115) {                  
        Static_Art_3.SetActive(true);
		Static_Art_2.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You clench your hands tighter.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 116) {                  
        Static_Art_1.SetActive(true);
		Static_Art_3.SetActive(false);
		AI_BG_5.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "See here, this has all gotten out of hand. There’s no need for any further barbarity.";
    }
	else if (primeInt == 117) {                  
        AI_BG_4.SetActive(true);
		AI_BG_5.SetActive(false);
		Static_Art_1.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "ORPHEUS";
        Char3speech.text = "Release my cable, and I’m sure we can-";
    }
	else if (primeInt == 118) {                  
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "The cable probably hasn’t been touched since the ship was first brought online. At first it barely moves.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 119) {                  
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You put all your strength into the next tug, and nearly knock yourself over as you heave on the tightly-bundled wires.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 120) {                  
        Static_Art_3.SetActive(true);
		AI_BG_6.SetActive(true);
		AI_BG_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "Orpheus emits a piercing howl as the cord loosens, but the sound cuts off abruptly as you yank the rest of it out.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 121) {                  
        AI_BG_7.SetActive(true);
		AI_BG_6.SetActive(false);
		Static_Art_3.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "The sudden silence is deafening, or would be were it not for your heart pounding in your ears.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 122) {                  
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "Yet even that is far away now.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 123) {                  
        Char1name.text = "YOU";
        Char1speech.text = "Not done yet...";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 124) {                  
        Console_Art_1.SetActive(true);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You make your way toward the panels meant to be used by the crew to control the ship, the impact of your clumsy steps feeling oddly muffled.";
        Char3name.text = "";
        Char3speech.text = "";
		Choice1e.SetActive(true);
        nextButton.SetActive(false);
        allowSpace = false;
    }
	else if (primeInt == 126) {                     // you took the cells              
        Console_Art_2.SetActive(false);
		Console_Art_3.SetActive(true);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You manage to find a console that controls the cryo bay. You fumble with the controls, your dexterity dropping by the second.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 127) {                             
        Console_Art_3.SetActive(false);
		Console_Art_5.SetActive(true);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "Confusion. This isn’t right. So many red lights. Error codes, warnings across the board. Why won’t this work?";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 128) {                             
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You keep pressing buttons until you can no longer govern your fingers. Your fist bashes limply against the keys.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 129) {                             
        Console_Art_5.SetActive(false);
		Console_Art_6.SetActive(true);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "What does “critical power failure” mean?";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 130) {                             
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "Your hand slips off the console. You try to put it back on, but the rest of you slipped too, and now you’re on the floor.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 131) {                             
        Console_Art_6.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You are not finished, It’s not time to rest yet. But your body will not obey.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 132) {                             
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "All that remains undone passes beyond concern as the last of your awareness drains away.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 133) {                             
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "Whatever you sought was likely beyond reach anyway.";
        Char3name.text = "";
        Char3speech.text = "";
		nextButton.SetActive(false);
        allowSpace = false;
		NextScene2Button.SetActive(true);
    }
	
	
	
	
	
	
	else if (primeInt == 181) {                     // you didn't take the cells              
        Console_Art_2.SetActive(false);
		Console_Art_3.SetActive(true);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "You manage to find a console that controls the cryo bay. You fumble with the controls, your dexterity dropping by the second.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 182) {                                 
        Console_Art_3.SetActive(false);
		Console_Art_4.SetActive(true);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "For a moment, your heart lurches. What are you doing again? Something important. You hit a big button, and the screen lights up green.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 183) {                                 
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "Is that a good thing? Hopefully. Then again, what does it matter?";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 184) {                                 
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = " It’s been a long day, and you need to rest. Someone else can worry about it.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 185) {                                 
        Console_Art_4.SetActive(false);
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "The feeling of your knees hitting the floor is a distant rumble.";
        Char3name.text = "";
        Char3speech.text = "";
    }
	else if (primeInt == 186) {                                 
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "...";
        Char2speech.text = "By the time your head follows a few moments later, you’re already gone.";
        Char3name.text = "";
        Char3speech.text = "";
		NextScene3Button.SetActive(true);
		nextButton.SetActive(false);
        allowSpace = false;
    }
	else if (primeInt == 187) {                                 
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
    }

}// end of next function
	
	public void Choice1aFunct(){                                                    //but their lives!
                GameHandler.bigH = GameHandler.bigH + 1;
				careLives = true;
				Char1name.text = "YOU";
                Char1speech.text = "That doesn’t mean you should just murder them! They’re trapped, let’s bring them back to earth.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 25;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){                                      // but their knowledge!
				careLives = false;
				Char1name.text = "YOU";
                Char1speech.text = "But there’s still so much I don’t understand!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 25;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1cFunct(){                                      // SUCCUMB
				Static_Art_3.SetActive(true);
				Static_Art_1.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The pain is overwhelming, your vision blurring heavily.";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 86;
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1dFunct(){                                      // RESIST
				Static_Art_3.SetActive(true);
				Static_Art_1.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "The pain is overwhelming, your vision blurring heavily.";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 100;
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1eFunct(){                                      // continue
				if (GameHandler.cryoCells == true) {
				Console_Art_1.SetActive(false);
				Console_Art_2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You moved fast. You know you did. Surely, it was fast enough?";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 125;
                Choice1e.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				}
				else {
				Console_Art_1.SetActive(false);
				Console_Art_2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "...";
                Char2speech.text = "You are dimly aware that you are the only person left alive on the ship. Except, that is, for the part of the crew that’s still frozen.";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 180;
                Choice1e.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;	
				}
        }
		public void SceneChange1(){               // succumb
			SceneManager.LoadScene("End_Succumb");
        }
		public void SceneChange2(){                 //resist, took cells
			SceneManager.LoadScene("End_drift");
        }
		public void SceneChange3(){                //resist, left cells
			SceneManager.LoadScene("End_Win");
        }

}
