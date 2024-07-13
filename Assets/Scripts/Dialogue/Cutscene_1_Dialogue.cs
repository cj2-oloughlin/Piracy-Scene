using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene_1_Dialogue : Dialogue
{
    [SerializeField] private DialogManager DialogManager;

    public override void Talk()
    {
        if (DialogManager.Printer.activeSelf)
        {
            return;
        }

        var dialogData = new List<DialogData>();

        dialogData.Add(new DialogData("Ugh.../wait:0.1/ I still haven't found a job.../wait:0.1/ And my landlord's just put up my rent by 16%.../wait:0.5//close/", "Timeline", isSkipable: false));
        dialogData.Add(new DialogData("I need cash. Fast./wait:0.3//close/", "Timeline", isSkipable: false));
        dialogData.Add(new DialogData("Unless.../wait:0.3//close/", "Timeline", isSkipable: false));
        dialogData.Add(new DialogData("It'll break Ma's heart but.../wait:0.3//close/", "Timeline", isSkipable: false));
        dialogData.Add(new DialogData("I could always get back into my old.../wait:0.2/ /color:(Red)/hobby/color:(Black)/./wait:0.5//close/", "Timeline", isSkipable: false));
        dialogData.Add(new DialogData("I wouldn't steal a car./wait:0.2//close/", "Timeline", isSkipable: false));
        dialogData.Add(new DialogData("I wouldn't steal a handbag./wait:0.2//close/", "Timeline", isSkipable: false));
        dialogData.Add(new DialogData("I wouldn't steal a mobile phone./wait:0.2//close/", "Timeline", isSkipable: false));
        dialogData.Add(new DialogData("I /size:up/would/size:init/ steal a movie./wait:0.2//close/", "Timeline", isSkipable: false));
        dialogData.Add(new DialogData("Is it really piracy if I don't get caught?/wait:0.5//close/", "Timeline", isSkipable: false));



        DialogManager.Show(dialogData);
    }
}

