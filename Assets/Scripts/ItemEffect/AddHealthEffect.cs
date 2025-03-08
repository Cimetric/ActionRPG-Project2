using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class AddHealthEffect : UsableItem.UsageEffect
{
    public int healthAmount;
    public override bool Use(CharacterData user)
    {
        if(user.Stats.CurrentHealth == 20){
            return false;
        }
        user.Stats.ChangeHealth(healthAmount);
        return true;
    }
}
