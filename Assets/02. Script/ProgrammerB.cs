using DevA;
using UnityEngine;

namespace DevB
{
    public class ProgrammerB : MonoBehaviour
    {
        public ProgrammerA pA = new ProgrammerA();

        private void Start()
        {
            //pA.number1 = 10;

            pA.number2 = 20;

            //pA.number3 = 30;

            //pA.number4 = 40;

            //pA.number5 = 50;
        }
    }
}
