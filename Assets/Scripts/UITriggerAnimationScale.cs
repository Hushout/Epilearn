using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITriggerAnimationScale : MonoBehaviour
{
    public UnityEngine.XR.Interaction.Toolkit.AR.ARPlacementInteractable ARScript;

    public void TriggerScaleAnimation()
    {
        Animator animator = ARScript.placementPrefab.GetComponentInChildren<Animator>();
        bool scale = animator.GetBool("Scale");
        animator.SetBool("Scale",true);
        Debug.Log(animator.GetBool("Scale"));
    }
}
