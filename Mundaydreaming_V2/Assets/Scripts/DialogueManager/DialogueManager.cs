using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    [TextArea(3, 10)]
    public string[] sentenceContainer;

    private Queue<string> sentences;

    private float countDownTimer;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        countDownTimer = 5;

        healthMonitor.onplayerLowHealth += StartDialogue;
    }

    void Update()
    {
        countDownTimer -= Time.deltaTime;
        if (countDownTimer <= 0)
        {
            EndDialogue();
        }
    }

    public void StartDialogue(string name, int number)
    {
        animator.SetBool("IsOpen", true);
        nameText.text = name;

        DisplayNextSentence(number);
    }

    public void DisplayNextSentence(int number)
    {
        countDownTimer = 5;
        string sentence = sentenceContainer[number];
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    } 

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForFixedUpdate();
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }
}
