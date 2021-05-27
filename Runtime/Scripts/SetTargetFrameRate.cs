using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AS.SetTargetFrameRate
{
    public class SetTargetFrameRate : MonoBehaviour
    {
        public int targetFrameRate = 120;
        void Awake()
        {
            Application.targetFrameRate = targetFrameRate;
        }
    }
}
