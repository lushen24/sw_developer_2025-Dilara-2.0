namespace arroyGL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl;

            ///Deklaration
            int[] zahlen;   //int-Arrays so heißt es mit der eckigen klammer
                            // eine liste von int werken in der "tabelle"stringstring
            string[] namen;


            //dimension
            zahlen = new int[5];     // 5 ist die anzahl der elemente 
                                    // {2,-3,2543,1560,0,} so kann man es auch schriben gleich neben der 5
            zahlen[0] = 2;
            zahlen[1] = -3;
            zahlen[2] = 2543;
            zahlen[3] = 1560;

            Console.WriteLine("Wert 1 = " + zahlen[0]);


 
        }
    }
}
