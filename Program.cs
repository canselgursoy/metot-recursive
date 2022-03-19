using System;
namespace metotlar_extension_recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            //rekürsif -öz yinelemeli
            //3 üssü 4 =3*3*3*3

            int result =1;
            for (int i = 1; i < 5; i++)
            {
                result=result*3;
            
            }
            Console.WriteLine(result);
            Islemler instance = new Islemler();
            Console.WriteLine(instance.Expo(3,4));
        }

    }
    public class Islemler
    {
        public int Expo(int sayi,int üs)
        {
            if(üs<2)
               return sayi;
            return Expo(sayi,üs-1)*sayi;

        }
    }
}


