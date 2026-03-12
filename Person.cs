namespace knightmoves;

public class Person{
   public string FirstName;
   public string LastName;
   public string[] Hobbies;

   public Person(string firstName, string lastName){
      FirstName = firstName;
      LastName = lastName;
   }
   public void AddHobbies(params string[] hobbies)
    {
        if (Hobbies == null)
            Hobbies = hobbies;
        else
            Hobbies = Hobbies.Concat(hobbies).ToArray();
    }
}
}


















