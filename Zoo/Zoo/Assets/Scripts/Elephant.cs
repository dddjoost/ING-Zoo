using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    public class Elephant : Animal
    {
        private const string eatLeavesText = "What about second breakfast?";
        private void Start()
        {
            message = "oh wee";
        }

        private void OnEnable()
        {
            EventManager.SayHello += SayHello;
            EventManager.EatLeaves += EatLeaves;
            EventManager.PerformTrick += PerformTrick;

        }

        private void OnDisable()
        {
            EventManager.SayHello -= SayHello;
            EventManager.EatLeaves -= EatLeaves;
            EventManager.PerformTrick -= PerformTrick;

        }
        
        private void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        private IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(2, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
        

        public void EatLeaves()
        {
            Balloon.SetActive(true);
            text.text = eatLeavesText;
        }
    }
}