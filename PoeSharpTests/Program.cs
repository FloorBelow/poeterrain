﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POESharp;

namespace PoeSharpTests {
    class Program {
        static void Main(string[] args) {
            Arm arm = new Arm(@"F:\Extracted\PathOfExile\3.17.Siege\Camp\Rooms\camp.arm");
            Console.WriteLine(arm.name);
        }
    }
}