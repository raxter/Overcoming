// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory(ActionCategory.Math)]
    [Tooltip("Adds a value to a Float Variable.")]
    public class ChangeSnapshot : FsmStateAction
    {
        [RequiredField]
        [UIHint(UIHint.Variable)]
        [Tooltip("The Float variable to add to.")]
        public AudioMixerSnapshot audioMixerSnapshotVariable;

        [UIHint(UIHint.Variable)]
        [Tooltip("The Float variable to add to.")]
        public FsmFloat delayVariable;

        [UIHint(UIHint.Variable)]
        [Tooltip("The Float variable to add to.")]
        public FsmFloat floatVariable;

        public override void Reset()
        {
            audioMixerSnapshotVariable = null;
            floatVariable = null;
        }

        public override void OnEnter()
        {
            DoFloatAdd();
        }

        public override void OnUpdate()
        {
            DoFloatAdd();
        }

        void DoFloatAdd()
        {
            StartCoroutine(playDelayed(delayVariable.Value));
        }

        IEnumerator playDelayed(float time)
        {
            yield return new WaitForSeconds(time);
            audioMixerSnapshotVariable.TransitionTo(floatVariable.Value);
            yield return null;

        }
    }
}