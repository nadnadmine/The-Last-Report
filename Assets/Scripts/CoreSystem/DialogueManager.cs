
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[Serializable]
public class DialogueChoice
{
    public string choiceText;
    public string nextDialogueID;
}

[Serializable]
public class DialogueNode
{
    public string dialogueID;
    public string speaker;

    [TextArea(2, 5)]
    public string dialogueText;

    public string nextDialogueID;
    public DialogueChoice[] choices;
}

public class DialogueManager : MonoBehaviour
{
    [Header("Dialogue UI")]
    public TMP_Text speakerNameText;
    public TMP_Text dialogueText;

    [Header("Branching Dialogue UI")]
    public Transform choicesContainer;
    public Button choiceButtonPrefab;

    [Header("Dialogue Data")]
    public string startDialogueID = "morning_001";
    public DialogueNode[] dialogueNodes;

    private Dictionary<string, DialogueNode> dialogueLookup =
        new Dictionary<string, DialogueNode>();

    private List<GameObject> activeButtons =
        new List<GameObject>();

    private bool waitingForChoice;
    private bool dialogueFinished;
    private string nextDialogueID;

    void Start()
    {
        if (dialogueNodes == null || dialogueNodes.Length == 0)
        {
            CreateTestDialogue();
        }

        foreach (DialogueNode node in dialogueNodes)
        {
            if (node == null || string.IsNullOrEmpty(node.dialogueID))
                continue;

            if (!dialogueLookup.ContainsKey(node.dialogueID))
                dialogueLookup.Add(node.dialogueID, node);
        }

        ShowDialogue(startDialogueID);
    }

    void Update()
    {
        if (waitingForChoice || dialogueFinished)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            NextDialogue();
        }
    }

    public void ShowDialogue(string dialogueID)
    {
        ClearChoices();

        if (!dialogueLookup.TryGetValue(dialogueID, out DialogueNode node))
        {
            FinishDialogue();
            return;
        }

        dialogueFinished = false;
        speakerNameText.text = node.speaker;
        dialogueText.text = node.dialogueText;
        nextDialogueID = node.nextDialogueID;

        if (node.choices != null && node.choices.Length > 0)
        {
            ShowChoices(node.choices);
        }
    }

    void ShowChoices(DialogueChoice[] choices)
    {
        waitingForChoice = true;

        if (choicesContainer == null || choiceButtonPrefab == null)
        {
            Debug.LogError("ChoicesContainer atau ChoiceButtonPrefab belum dihubungkan!");
            return;
        }

        foreach (DialogueChoice choice in choices)
        {
            if (choice == null)
                continue;

            Button newButton = Instantiate(
                choiceButtonPrefab,
                choicesContainer
            );

            newButton.gameObject.SetActive(true);

            TMP_Text buttonText =
                newButton.GetComponentInChildren<TMP_Text>(true);

            if (buttonText != null)
                buttonText.text = choice.choiceText;

            string targetID = choice.nextDialogueID;

            newButton.onClick.RemoveAllListeners();
            newButton.onClick.AddListener(() =>
            {
                waitingForChoice = false;
                ShowDialogue(targetID);
            });

            activeButtons.Add(newButton.gameObject);
        }
    }

    void ClearChoices()
    {
        foreach (GameObject button in activeButtons)
        {
            if (button != null)
            {
                button.SetActive(false);
                Destroy(button);
            }
        }

        activeButtons.Clear();
        waitingForChoice = false;
    }

    public void NextDialogue()
    {
        if (waitingForChoice || dialogueFinished)
            return;

        if (!string.IsNullOrEmpty(nextDialogueID))
            ShowDialogue(nextDialogueID);
        else
            FinishDialogue();
    }

    void FinishDialogue()
    {
        ClearChoices();
        dialogueFinished = true;
        speakerNameText.text = "";
        dialogueText.text = "Dialog selesai.";
    }

    void CreateTestDialogue()
    {
        dialogueNodes = new DialogueNode[]
        {
            new DialogueNode
            {
                dialogueID = "morning_001",
                speaker = "Daendels",
                dialogueText = "Ada ketidaksesuaian dalam laporan ini.",
                nextDialogueID = "morning_002"
            },

            new DialogueNode
            {
                dialogueID = "morning_002",
                speaker = "Daendels",
                dialogueText = "Menurutmu, apakah laporan ini dapat dipercaya?",
                choices = new DialogueChoice[]
                {
                    new DialogueChoice
                    {
                        choiceText = "Periksa bukti terlebih dahulu.",
                        nextDialogueID = "morning_003a"
                    },

                    new DialogueChoice
                    {
                        choiceText = "Saya mempercayai keputusan Anda.",
                        nextDialogueID = "morning_003b"
                    },

                    new DialogueChoice
                    {
                        choiceText = "Saya akan membantu menyelidikinya.",
                        nextDialogueID = "morning_003c"
                    }
                }
            },

            new DialogueNode
            {
                dialogueID = "morning_003a",
                speaker = "Daendels",
                dialogueText = "Baik. Ketelitian sangat penting dalam penyelidikan ini.",
                nextDialogueID = "morning_004"
            },

            new DialogueNode
            {
                dialogueID = "morning_003b",
                speaker = "Daendels",
                dialogueText = "Aku menghargai kepercayaanmu, tetapi kita tetap membutuhkan bukti.",
                nextDialogueID = "morning_004"
            },

            new DialogueNode
            {
                dialogueID = "morning_003c",
                speaker = "Daendels",
                dialogueText = "Kalau begitu, mari kita selesaikan bersama.",
                nextDialogueID = "morning_004"
            },

            new DialogueNode
            {
                dialogueID = "morning_004",
                speaker = "Player",
                dialogueText = "Saya akan mulai memeriksa laporan tersebut."
            }
        };
    }
}
