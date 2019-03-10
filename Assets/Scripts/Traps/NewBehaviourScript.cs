using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
     if (position.x >= 49){
      transform.rotation.y = -180;
 }
 //On the way back, switch the 49s for what ever distance you want!
 
 if (position.x <= -49){
      transform.rotation.y = 180;
 }