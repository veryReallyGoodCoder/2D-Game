using Articy.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    [SerializeField]
    private DiaglogueManager dialogueManager;

    [SerializeField]
    private GameObject GreetButton;

    [SerializeField]
    private GameObject GlucoseGuardianButton;

    [SerializeField]
    private GameObject BranchButton;

    private ArticyObject GetArticyObject(GameObject npc)
    {
        var articyRef = npc.GetComponent<ArticyReference>();

        if(articyRef != null)
        {
            return articyRef.reference.GetObject();
        }

        return null;
    }
    
    public void TalkToJohn()
    {
        dialogueManager.StartDialogue(GetArticyObject(GreetButton));
    }

    public void TalkToGG()
    {
        dialogueManager.StartDialogue(GetArticyObject(GlucoseGuardianButton));
    }

    public void BranchTalk()
    {
        dialogueManager.StartDialogue(GetArticyObject(BranchButton));
    }
}
