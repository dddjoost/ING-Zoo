using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace Zoo
{
    public class AnimalsUI : MonoBehaviour
    {
        [SerializeField] private InputField name;

        public void InvokeHello()
        {
            EventManager.SayHello(name.text);
        }

        public void InvokePerformTrick()
        {
            EventManager.PerformTrick();
        }

        public void InvokeEatingLeaves()
        {
            EventManager.EatLeaves();
        }

        public void InvokeEatingMeat()
        {
            EventManager.EatMeat();
        }
    }
}