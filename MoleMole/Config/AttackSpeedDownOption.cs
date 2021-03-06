﻿namespace MoleMole.Config
{
    using MoleMole;
    using System;

    public class AttackSpeedDownOption : ConfigAbilityStateOption
    {
        public DynamicFloat AttackSpeedRatio;

        public override void ChangeModifierConfig(ConfigAbilityModifier modifier)
        {
            modifier.Properties.Add("Entity_AttackSpeed", this.AttackSpeedRatio);
        }

        public override AbilityState GetMatchingAbilityState()
        {
            return AbilityState.AttackSpeedDown;
        }
    }
}

