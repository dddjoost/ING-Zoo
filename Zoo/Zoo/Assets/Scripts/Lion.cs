using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Lion : Animal
    {
        private void Start()
        {
            message = "roooaoaaaaar";
        }

        private void OnEnable()
        {
            EventManager.SayHello += SayHello;
            EventManager.EatMeat += EatMeat;
        }

        private void OnDisable()
        {
            EventManager.SayHello -= SayHello;
            EventManager.EatMeat -= EatMeat;
        }

        private void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "nomnomnom thx mate";
        }
    }
}