using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Zebra : Animal
    {

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

        private void Start()
        {
            message = "zebra zebra";
        }
        
        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch zank yee bra";
        }
    }
}
