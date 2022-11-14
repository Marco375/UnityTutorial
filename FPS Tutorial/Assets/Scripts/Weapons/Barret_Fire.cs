using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barret_Fire : MonoBehaviour
{
  public GameObject goBarret;
  public bool bFiring = false;

    // Update is called once per frame
  void Update()
  {
    if (Input.GetButtonDown("Fire1"))
    {
      if (bFiring == false)
      {
        StartCoroutine(FireTheBarret());  
      }
    }  
  }

  IEnumerator FireTheBarret()
  { 
    bFiring = true;
    goBarret.GetComponent<Animator>().Play("M107_Fire_Animation");
    yield return new WaitForSeconds(0.35F);
    goBarret.GetComponent<Animator>().Play("New State");
    bFiring = false;
  }
}
