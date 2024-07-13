using System.Collections;
using System.Collections.Generic;
using Doublsb.Dialog;
using UnityEngine;

public class Cashier : Dialogue
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

        dialogData.Add(new DialogData("/size:down//size:down//size:down/Ugh not this guy- /wait:0.1//close/", "Cashier", isSkipable: false));
        dialogData.Add(new DialogData("/size:init/Hey. What d'ya want? /wait:0.3//close/", "Cashier", isSkipable: false));
        dialogData.Add(new DialogData("/speed:down/ . . . /speed:init//wait:0.3//close/", "Cashier", isSkipable: false));
        dialogData.Add(new DialogData("Look pal,/wait:0.2/ can we not? /wait:0.3/My shift's only just started and you're honestly the /size:up/LAST/size:down/ person I wanna deal with. /wait:0.3//close/", "Cashier", isSkipable: false));
        dialogData.Add(new DialogData("Here, let's make this easy, /wait:0.3//speed:down//speed:down/ popcorn /wait:0.1//speed:init/or/speed:down//speed:down//wait:0.1/ fruit? /wait:0.3//speed:init//close/", "Cashier", isSkipable: false));
        dialogData.Add(new DialogData("/speed:down/ . . . /speed:init//wait:0.3//close/", "Cashier", isSkipable: false));
        dialogData.Add(new DialogData("You're getting nothing,/wait:0.3/ end of discussion. Now leave me alone. /size:down//size:down//size:down//wait:0.3/Why do I always get the nutjobs?/wait:0.3//close/", "Cashier", () => animator.SetBool("Talk", false), isSkipable: false));

        DialogManager.Show(dialogData);
    }
}
