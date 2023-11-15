namespace HesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum, secondNum;
            char işlem;
            Console.WriteLine("1.sayıyı giriniz:");
            firstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:(Toplama için:+,Çıkarma için:-,Çarpma için:*,Bölme için:/");
            işlem = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz:");
            secondNum = Convert.ToDouble(Console.ReadLine());

            switch (işlem)
            {
                case '+':
                    {
                        Console.WriteLine("Toplama: " + (firstNum + secondNum));
                    }
                    break;
                case '-':
                    {
                        Console.WriteLine("Çıkarma: " + (firstNum - secondNum));
                    }
                    break;
                case '*':
                    {
                        Console.WriteLine("Çarpma: " + (firstNum * secondNum));
                    }
                    break;
                case '/':
                    {
                        try
                        {
                            Console.WriteLine("Bölme: " + (firstNum / secondNum));
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Sayı sıfıra bölünemez.");
                        }

                    }
                    break;
                default:
                    {
                        Console.WriteLine("Böyle bir işlem yok.");
                    }
                    break;

            }
        }
    }
}