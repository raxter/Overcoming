// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory(ActionCategory.Math)]
    [Tooltip("Adds a value to a Float Variable.")]
    public class FloatFloor : FsmStateAction
    {
        [RequiredField]
        [UIHint(UIHint.Variable)]
        [Tooltip("The Float variable to add to.")]
        public FsmFloat floatVariable;

        [Tooltip("Repeat every frame while the state is active.")]
        public bool everyFrame;

        [Tooltip("Used with Every Frame. Adds the value over one second to make the operation frame rate independent.")]
        public bool perSecond;

        public override void Reset()
        {
            floatVariable = null;
            everyFrame = false;
            perSecond = false;
        }

        public override void OnEnter()
        {
            DoFloatAdd();

            if (!everyFrame)
            {
                Finish();
            }
        }

        public override void OnUpdate()
        {
            DoFloatAdd();
        }

        void DoFloatAdd()
        {
            if (!perSecond)
            {
                floatVariable.Value = Mathf.Floor(floatVariable.Value);
            }
            else
            {

                floatVariable.Value = Mathf.Floor(floatVariable.Value * Time.deltaTime);
            }
        }
    }
}