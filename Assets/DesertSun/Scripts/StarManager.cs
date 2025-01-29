using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarManager : MonoBehaviour
{
   [SerializeField] private GameObject Camplayer;
   [SerializeField] private GameObject player;
   [SerializeField] private GameObject startUi;
   [SerializeField] private GameObject CamStartUi;

   private void Awake()
   {
        
   }

   public void StartGame()
   {
      startUi.SetActive(false);  
      
     
       player.GetComponent<PlayerController>().enabled = true;
       
       CamStartUi.SetActive(false);  
       
      Camplayer.SetActive(true);  
      
     
      
   }
 
}
