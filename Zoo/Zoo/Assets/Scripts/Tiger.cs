using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Tiger : Animal
    {
        private void Start()
        {
            message = "rraaarww";
        }
        private void OnEnable()
        {
            EventManager.SayHello += SayHello;
            EventManager.EatMeat += EatMeat;
            EventManager.PerformTrick += PerformTrick;
        }
        
        private void OnDisable()
        {
            EventManager.SayHello -= SayHello;
            EventManager.EatMeat -= EatMeat;
            EventManager.PerformTrick -= PerformTrick;
        }

        public void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "nomnomnom thx wubalubadubdub";
        }

        public void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}