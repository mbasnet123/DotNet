class SwapByReference{
    static void Main(string[] args){
        int a = 4;
        int b = 5;
        Console.WriteLine($"Before swapping, a = {a}, b = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"After Swapping, a = {a}, b = {b}");
    }
    static void Swap(ref int x, ref int y){
        int temp = x;
        x = y;
        y = temp;
    }
}
