
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [Header("Dialogue UI")]
    public TMP_Text speakerNameText;
    public TMP_Text dialogueText;

    [Header("Test Dialogue")]
    public string[] speakers =
    {
        "Daendels",
        "Player",
        "Daendels"
    };

    [TextArea(2, 5)]
    public string[] dialogues =
    {
        "Ada ketidaksesuaian dalam laporan ini.",
        "Saya akan memeriksa dokumen tersebut.",
        "Baiklah. Laporkan hasil pemeriksaanmu."
    };

    private int currentDialogueIndex = 0;

    void Start()
    {
        ShowDialogue();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            NextDialogue();
        }
    }

    void ShowDialogue()
    {
        if (currentDialogueIndex >= dialogues.Length)
        {
            dialogueText.text = "Dialog selesai.";
            speakerNameText.text = "";
            return;
        }

        speakerNameText.text = speakers[currentDialogueIndex];
        dialogueText.text = dialogues[currentDialogueIndex];
    }

    public void NextDialogue()
    {
        if (currentDialogueIndex < dialogues.Length)
        {
            currentDialogueIndex++;
            ShowDialogue();
        }
    }
}
