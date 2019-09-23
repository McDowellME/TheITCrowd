using System;
using System.Collections.Generic;
using System.Text;

namespace TheITCrowd
{
    class Moss : Staff
    {
        public void FirstAnswer()
        {
            Console.WriteLine("Have you tried forcing an unexpected reboot?");
        }

        public void SecondAnswer()
        {
            Console.WriteLine("See the driver hooks a function by patching the system call table" +
                ", so it's not safe to unload it unless another thread's about to jump in there and do its stuff" +
                ", and you don't want to end up in the middle of invalid memory!");
        }
    }
}
