using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public AnimationClip[] idleAnimations;  // Array of idle animations
    public float timeBetweenAnimations = 1f;  // Time between each animation in seconds

    private int currentAnimationIndex = 0;
    private Animator animator;
    private float timer = 0f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        // Check if it's time to switch to the next animation
        if (timer >= timeBetweenAnimations)
        {
            // Play the current animation and increment the index
            animator.Play(idleAnimations[currentAnimationIndex].name);
            currentAnimationIndex = (currentAnimationIndex + 1) % idleAnimations.Length;
            timer = 0f;
        }
    }
}
