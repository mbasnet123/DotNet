using System;

class NullCollaescingOperator6{
    static void Main(string[] args)
    {
        int ?ticketsOnSale = null;
        
        int availableTickets = ticketsOnSale ?? 0;
        Console.WriteLine($"Available tickets = {availableTickets}");
    }
}