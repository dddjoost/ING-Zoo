using System;
using UnityEngine;

namespace Zoo
{
    public static class EventManager
    {
        public static Action EatLeaves;
        public static Action EatMeat;
        public static Action<string> SayHello;
        public static Action PerformTrick;

    }
}