using System;

namespace CSharp
{
    class Program
    {
        // 주석을 달 수 있다.
        static void Main(string[] args)
        {
            // byte(1바이트 0 ~ 255), short(2바이트 -3만 ~ 3만), int(4바이트 -21억 ~ 21억), long(8바이트)
            // sbyte(1바이트 -128 ~ 127), ushort(2바이트 0 ~ 6만), uint(4바이트 0 ~ 43억), ulong(8바이트)


            // 1. 바구니의 크기가 다른 경우
            int a = 0x0FFFFFFF;
            short b = (short)a;

            // ﻿2. 바구니의 크기는 같지만 부호가 다른 경우
            byte c = 255;
            sbyte sb = (sbyte)c;
        }
    }
}
