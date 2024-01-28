using System;

namespace Lab2.Go {

  class Goto {

    static void Main() {
    for(int i = 0; i <= 10; i++) {

      if(i == 5) {
        // transfers control to End label
        goto End;
      }

      Console.WriteLine(i);
    }

    // End label
    End:
      Console.WriteLine("Loop End");
      Console.ReadLine();
    }
  }
}