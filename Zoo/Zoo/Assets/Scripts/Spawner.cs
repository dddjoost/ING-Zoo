using System;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra, elephant, giraffe;
        private void Start()
        {
            Lion henk = Instantiate(lion, transform).GetComponent<Lion>();
            henk.AnimalName = "henk";
            Hippo elsa = Instantiate(hippo, transform).GetComponent<Hippo>();
            elsa.AnimalName = "elsa";
            Pig dora = Instantiate(pig, transform).GetComponent<Pig>();
            dora.AnimalName = "dora";
            Tiger wally = Instantiate(tiger, transform).GetComponent<Tiger>();
            wally.AnimalName = "wally";
            Zebra marty = Instantiate(zebra, transform).GetComponent<Zebra>();
            marty.AnimalName = "marty";
            Elephant frodi = Instantiate(elephant, transform).GetComponent<Elephant>();
            frodi.AnimalName = "frodi";
            Giraffe sammy = Instantiate(giraffe, transform).GetComponent<Giraffe>();
            sammy.AnimalName = "sammy";
        }
    }
}
