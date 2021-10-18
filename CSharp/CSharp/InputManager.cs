using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    // Observer Pattern
    class InputManager
    {
        public delegate void OnInputKey();
        public event OnInputKey InputKey;

        public void Update()
        {
            if (Console.KeyAvailable)
                return;

            ConsoleKeyInfo info = Console.ReadKey();
            if(info.Key == ConsoleKey.A)
            {
                // 모두에게 알려준다.
                InputKey();
            }
        }
    }
}
