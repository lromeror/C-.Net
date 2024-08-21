using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class TestDelegate
    {
        int num=0;

        public int Sumar(int a, int b){
            num=a+b;
            return num;
        }

        public int multipplicacion(int a,int b){
            num=a*b;
            return num;
        }

    }
}