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
    public string[] sentenceSpeakers;

    private Queue<string> sentences;
    private Queue<string> names;

    private float countDownTimer;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        names = new Queue<string>();
        countDownTimer = 3;
    }

    void Update()
    {
        countDownTimer -= Time.deltaTime;
        if (countDownTimer <= 0)
        {
            DisplayNextSentence();
        }
    }

    public void StartDialogue(int numStart, int numEnd)
    {
        animator.SetBool("IsOpen", true);

        names.Clear();
        sentences.Clear();
        for (int s = numStart; s <= numEnd; s++)
        {
            sentences.Enqueue(sentenceContainer[s]);
            names.Enqueue(sentenceSpeakers[s]);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        countDownTimer = 3;
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        nameText.text = names.Dequeue();
        string sentence = sentences.Dequeue();
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
