using Doublsb.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketChecker : Dialogue
{
    [SerializeField] private DialogManager DialogManager;
    [SerializeField] private Animator animator;

    public override void Talk()
    {
        if (DialogManager.Printer.activeSelf)
        {
            return;
        }

        animator.SetBool("Talk", true);

        var dialogData = new List<DialogData>();

        dialogData.Add(new DialogData("/size:down//size:down//size:down/I'm just saying, Jessica isn't gonna make a move unless-/wait:0.5//close/", "Ticket Checker", isSkipable: false));
        dialogData.Add(new DialogData("/size:init/.../wait:0.3//close/", "Ticket Checker", isSkipable: false));
        dialogData.Add(new DialogData("What./wait:0.5//close/", "Ticket Checker", isSkipable: false));
        dialogData.Add(new DialogData("Oh,/wait:0.2/ ugh. /wait:0.2/It's you./wait:0.5//close/", "Ticket Checker", isSkipable: false));
        dialogData.Add(new DialogData("/speed:down/Sigh.../speed:init/ Ticket please./wait:0.5//close/", "Ticket Checker", isSkipable: false));
        dialogData.Add(new DialogData("Okay, so,/wait:0.1/ please be aware that you will be escorted from the premises if you're recording./wait:0.2/ Any cameras will be confiscated./wait:0.5//close/", "Ticket Checker", isSkipable: false));
        dialogData.Add(new DialogData("Enjoy.../wait:0.2/ I guess./wait:0.3/ /size:down//size:down//size:down/So Tony when're you gonna go talk to-/wait:0.2//close/", "Ticket Checker", () => animator.SetBool("Talk", false), isSkipable: false));

        DialogManager.Show(dialogData);
    }
}
