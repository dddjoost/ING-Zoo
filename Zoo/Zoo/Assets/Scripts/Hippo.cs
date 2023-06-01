using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Hippo : Animal
    {

        private void Start()
        {
            message = "splash";
        }

        private void OnEnable()
        {
            EventManager.SayHello += SayHello;
            EventManager.EatLeaves += EatLeaves;
            
        }

        private void OnDisable()
        {
            EventManager.SayHello -= SayHello;
            EventManager.EatLeaves -= EatLeaves;
            
        }

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch lovely";
        }

        
    }
}