using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is used to connect script and condition parameters in Animator Controller 
/// Attach this code to characters
/// </summary>


public class CharacterAnimations : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        // Initialise the Animator component for anim;
        anim = GetComponent<Animator>();
    }

    // Set the condition value for Walk animation, 
    // so Walk animation plays
    public void Walk(bool walk)
    {
        anim.SetBool("Walk", walk);
    }

    #region Animations for Warrior .................

    //set the condition value for Warrior attack
    public void Attack_Warrior()
    {
        anim.SetTrigger("Attack Warrior");
    }

    //set the condition value for Warrior DEFEND
    public void Defend(bool defend)
    {
        anim.SetBool("Defend", defend);
    }

    #endregion

    #region Animations for Rogue ...................

    //set the condition value for Rogue attack
    public void Attack_Rogue()
    {
        anim.SetTrigger("Attack Rogue");
    }


    public void Attack_Shoot()
    {
        anim.SetTrigger("Attack Shoot");
    }

    #endregion

    #region Animations for Mage ....................

    //set the condition value for Mage Attack
    public void Attack_Mage()
    {
        anim.SetTrigger("Attack Mage");
    }

    public void Cast_Mage()
    {
        anim.SetTrigger("Cast Mage");
    }

    #endregion



                 

}
