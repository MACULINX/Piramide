
using System;

namespace Piramide{
    public static class Piramide {

        public static int Piani( int mattoni )
        {
            if(mattoni <= 0)
                return 0;
            
            bool flag = true;
            int piani = 1;
            int mattnec = 0;
            int matt = 1;

            while(flag)
            {
                flag = (Math.Pow((matt),2)) + mattnec <= mattoni ? true : false;
                
                if(flag){

                    mattnec = mattnec + (int)(Math.Pow((matt),2));
                    matt+=2;
                    piani++;
                }
                
            }
            
            return piani-1;
        }
        public static int Rimanenti( int mattoni )
        {
            if(mattoni <= 0)
                return 0;
            
            bool flag = true;
            int piani = 1;
            int mattnec = 0;
            int matt = 1;

            while(flag)
            {
                flag = (Math.Pow((matt),2)) + mattnec <= mattoni ? true : false;
                
                if(flag){

                    mattnec = mattnec + (int)(Math.Pow((matt),2));
                    matt+=2;
                    piani++;
                }
                
            }
            
            int mattrem = mattoni - mattnec;

            return mattrem;
        }

    }
}