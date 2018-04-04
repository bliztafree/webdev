﻿using bliztafree.Core.Animations.Base;
using Xamarin.Forms;

namespace bliztafree.Core.Triggers
{
    public class BeginAnimation : TriggerAction<VisualElement>
    {
        public AnimationBase Animation { get; set; }

        protected override async void Invoke(VisualElement sender)
        {
            if (Animation != null)
                await Animation.Begin();
        }
    }
}