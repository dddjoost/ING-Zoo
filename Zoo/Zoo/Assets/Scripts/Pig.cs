using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Pig : Animal
    {

        private void Start()
        {
            message = "oink oink";
        }

        private void OnEnable()
        {
            EventManager.SayHello += SayHello;
            EventManager.EatLeaves += EatLeaves;
            EventManager.EatMeat += EatMeat;
            EventManager.PerformTrick += PerformTrick;
        }


        private void EatMeat()
        {
            Balloon.SetActive(true);
            text.text = "nomnomnom oink thx";
        }

        private void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        private IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }

        private void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = "munch munch oink";
        }
    }
}
